function Check-MemoryProtection
{
##################################################################
#.Synopsis
# Retrieves the memory protections of an arbitrary address.
# 
# Author: Matthew Graeber (@mattifestation)
# License: GNU GPL v2
#.Description
# The Check-MemoryProtection cmdlet returns the memory protections of any memory address.
#
# Check-MemoryProtection is just a wrapper for the Windows API VirtualQuery function that outputs protections in a human-readable format.
#.Parameter Address
# Specifies the address whose memory protections are to be queried.
#.Parameter ProcessId
# Queries the memory of the provided process ID.
#.Parameter PageSize
# Specifies the memory page size. This can safely be left to its default of 0x1000 bytes.
#.Outputs
# Winapi.Kernel32+MEMORY_BASIC_INFORMATION
#     By default, Check-MemoryProtection returns a MEMORY_BASIC_INFORMATION structure.
#.Example
# C:\PS>$proc = [System.Diagnostics.Process]::GetCurrentProcess()
# 
# C:\PS>$module = $proc.MainModule
# 
# C:\PS>$base = $module.BaseAddress
# 
# C:\PS>Check-MemoryProtection $base
# 
# BaseAddress       : 5363597312
# AllocationBase    : 5363597312
# AllocationProtect : PAGE_EXECUTE_WRITECOPY
# RegionSize        : 4096
# State             : MEM_COMMIT
# Protect           : PAGE_READONLY
# Type              : MEM_IMAGE
# 
# 
# Description
# -----------
# This command returns the memory protections of the currently loaded process' base address. In this example, the memory address queried is the base address of powershell.exe
#.Example
# C:\PS>$proc = ps cmd
# 
# C:\PS>$base = $proc.MainModule.BaseAddress
# 
# C:\PS>Check-MemoryProtection $base $proc.Id
# 
# BaseAddress       : 1246035968
# AllocationBase    : 1246035968
# AllocationProtect : PAGE_EXECUTE_WRITECOPY
# RegionSize        : 4096
# State             : MEM_COMMIT
# Protect           : PAGE_READONLY
# Type              : MEM_IMAGE
# 
# 
# Description
# -----------
# This command returns the memory protections of cmd.exe.
#.Example
# C:\PS>Check-MemoryProtection 0x00000000
# 
# BaseAddress       : 0
# AllocationBase    : 0
# AllocationProtect : 0
# RegionSize        : 65536
# State             : MEM_FREE
# Protect           : PAGE_NOACCESS
# Type              : 0
# 
# 
# Description
# -----------
# This command returns the memory protections of the null page.
#.Link
# My blog: http://www.exploit-monday.com/
# MEMORY_BASIC_INFORMATION structure info: http://msdn.microsoft.com/en-us/library/windows/desktop/aa366775%28v=vs.85%29.aspx
##################################################################
    [CmdletBinding()] Param (
        [Parameter(Position = 0, Mandatory = $True)] [System.IntPtr] $Address,
        [Parameter(Position = 1)] [Int] $ProcessId,
        [Parameter(Position = 2)] [Int] $PageSize = 0x1000
    )
    
    try
    {
        $mem = New-Object Winapi.Kernel32+MEMORY_BASIC_INFORMATION
    }
    catch
    {
        $code = @"
        using System;
        using System.Runtime.InteropServices;

        namespace Winapi
        {
            public class Kernel32
            {
                [Flags]
                public enum ProcessAccessFlags : uint
                {
                    PROCESS_VM_READ = 0x00000010,
                    PROCESS_QUERY_INFORMATION = 0x00000400,
                    ALL = 0x001F0FFF
                }
            
                [Flags]
                public enum AllocationProtectEnum : uint
                {
                    PAGE_EXECUTE = 0x00000010,
                    PAGE_EXECUTE_READ = 0x00000020,
                    PAGE_EXECUTE_READWRITE = 0x00000040,
                    PAGE_EXECUTE_WRITECOPY = 0x00000080,
                    PAGE_NOACCESS = 0x00000001,
                    PAGE_READONLY = 0x00000002,
                    PAGE_READWRITE = 0x00000004,
                    PAGE_WRITECOPY = 0x00000008,
                    PAGE_GUARD = 0x00000100,
                    PAGE_NOCACHE = 0x00000200,
                    PAGE_WRITECOMBINE = 0x00000400,
                }
                
                [Flags]
                public enum StateEnum : uint
                {
                    MEM_COMMIT = 0x00001000,
                    MEM_FREE = 0x00010000,
                    MEM_RESERVE = 0x00002000,
                }
                
                [Flags]
                public enum TypeEnum : uint
                {
                    MEM_IMAGE = 0x01000000,
                    MEM_MAPPED = 0x00040000,
                    MEM_PRIVATE = 0x00020000,
                }
            
                [StructLayout(LayoutKind.Sequential)]
                public struct MEMORY_BASIC_INFORMATION
                {
                    public UIntPtr BaseAddress;
                    public UIntPtr AllocationBase;
                    public AllocationProtectEnum AllocationProtect;
                    public IntPtr RegionSize;
                    public StateEnum State;
                    public AllocationProtectEnum Protect;
                    public TypeEnum Type;
                }

                [DllImport("kernel32.dll")]
                public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);
                [DllImport("kernel32.dll")]
                public static extern int VirtualQuery(IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);
                [DllImport("kernel32.dll")]
                public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);
                [DllImport("kernel32.dll")]
                public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out, MarshalAs(UnmanagedType.AsAny)] object lpBuffer, int dwSize, [Out] int lpNumberOfBytesRead);
                [DllImport("kernel32.dll")]
                public static extern bool CloseHandle(IntPtr hObject);
            }
        }
"@

        $codeProvider = New-Object Microsoft.CSharp.CSharpCodeProvider
        $location = [PsObject].Assembly.Location
        $compileParams = New-Object System.CodeDom.Compiler.CompilerParameters
        $assemblyRange = @("System.dll", $location)
        $compileParams.ReferencedAssemblies.AddRange($assemblyRange)
        $compileParams.GenerateInMemory = $True
        $codeProvider.CompileAssemblyFromSource($compileParams, $code) | Out-Null
    }

    $mem = New-Object Winapi.Kernel32+MEMORY_BASIC_INFORMATION

    if ($ProcessId)
    {
        $ProcHandle = [Winapi.Kernel32]::OpenProcess([Winapi.Kernel32+ProcessAccessFlags]::PROCESS_QUERY_INFORMATION, 0, $ProcessId)
        [Winapi.Kernel32]::VirtualQueryEx($ProcHandle, $Address, [ref] $mem, $PageSize) | Out-Null
        [Winapi.Kernel32]::CloseHandle($ProcHandle) | Out-Null
    }
    else
    {
        [Winapi.Kernel32]::VirtualQuery($Address, [ref] $mem, $PageSize) | Out-Null
    }
    
    return $mem
}

function Dump-Memory
{
##################################################################
#.Synopsis
# Dumps memory contents to stdout or to disk.
# 
# Author: Matthew Graeber (@mattifestation)
# License: GNU GPL v2
#.Description
# The Dump-Memory cmdlet displays the contents of memory to stdout. You also have the option to dump raw memory to disk.
#.Parameter Address
# Specifies the base address of memory that is to be dumped.
#.Parameter Offset
# Specifies the number of bytes to dump.
#.Parameter ProcessId
# Dumps the memory of the process whose ID was specified.
#.Parameter Width
# Specifies how many bytes to print per line when outputting to stdout
#.Parameter DumpToFile
# Specifies the path to the output file.
# 
# When this option is specified, memory will not be displayed on stdout.
# 
# This parameter can be in the for of an absolute or relative file path.
#.Example
# $proc = ps cmd
# 
# $module = $proc.MainModule
# 
# $base = $module.BaseAddress
# 
# Dump-Memory $base 0x98 -ProcessId $proc.Id
# 
# 00000000h  4D 5A 90 00 03 00 00 00 04 00 00 00 FF FF 00 00  MZ..........ÿÿ..
# 00000010h  B8 00 00 00 00 00 00 00 40 00 00 00 00 00 00 00  ,.......@.......
# 00000020h  00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00  ................
# 00000030h  00 00 00 00 00 00 00 00 00 00 00 00 F0 00 00 00  ............d...
# 00000040h  0E 1F BA 0E 00 B4 09 CD 21 B8 01 4C CD 21 54 68  ..º..'.I!,.LI!Th
# 00000050h  69 73 20 70 72 6F 67 72 61 6D 20 63 61 6E 6E 6F  is.program.canno
# 00000060h  74 20 62 65 20 72 75 6E 20 69 6E 20 44 4F 53 20  t.be.run.in.DOS.
# 00000070h  6D 6F 64 65 2E 0D 0D 0A 24 00 00 00 00 00 00 00  mode....$.......
# 00000080h  4D 7C A4 8A 09 1D CA D9 09 1D CA D9 09 1D CA D9  M|☼...EU..EU..EU
# 00000090h  00 65 4E D9 08 1D CA D9                          .eNU..EU
# 
# 
# Description
# -----------
# This command dumps the first 0x98 bytes of the main module of cmd.exe to stdout.
#.Example
# C:\PS>$proc = [System.Diagnostics.Process]::GetCurrentProcess()
# 
# C:\PS>$module = $proc.MainModule
# 
# C:\PS>$base = $module.BaseAddress
# 
# C:\PS>Dump-Memory $base 0x120
# 
# 00000000h  4D 5A 90 00 03 00 00 00 04 00 00 00 FF FF 00 00  MZ..........ÿÿ..
# 00000010h  B8 00 00 00 00 00 00 00 40 00 00 00 00 00 00 00  ,.......@.......
# 00000020h  00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00  ................
# 00000030h  00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00  ................
# 00000040h  0E 1F BA 0E 00 B4 09 CD 21 B8 01 4C CD 21 54 68  ..º..'.I!,.LI!Th
# 00000050h  69 73 20 70 72 6F 67 72 61 6D 20 63 61 6E 6E 6F  is.program.canno
# 00000060h  74 20 62 65 20 72 75 6E 20 69 6E 20 44 4F 53 20  t.be.run.in.DOS.
# 00000070h  6D 6F 64 65 2E 0D 0D 0A 24 00 00 00 00 00 00 00  mode....$.......
# 00000080h  FF 54 CD 72 BB 35 A3 21 BB 35 A3 21 BB 35 A3 21  ÿTIr»5£!»5£!»5£!
# 00000090h  9C F3 D8 21 B9 35 A3 21 B2 4D 36 21 BA 35 A3 21  .óO!.5£!.M6!º5£!
# 000000A0h  B2 4D 27 21 AB 35 A3 21 B2 4D 30 21 AA 35 A3 21  .M'!«5£!.M0!ª5£!
# 000000B0h  BB 35 A2 21 20 35 A3 21 B2 4D 20 21 FF 35 A3 21  »5¢!.5£!.M.!ÿ5£!
# 000000C0h  B2 4D 29 21 BD 35 A3 21 9C F3 DD 21 BA 35 A3 21  .M)!.5£!.óY!º5£!
# 000000D0h  B2 4D 37 21 BA 35 A3 21 B2 4D 32 21 BA 35 A3 21  .M7!º5£!.M2!º5£!
# 000000E0h  52 69 63 68 BB 35 A3 21 00 00 00 00 00 00 00 00  Rich»5£!........
# 000000F0h  00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00  ................
# 00000100h  50 45 00 00 64 86 05 00 F3 C7 5B 4A 00 00 00 00  PE..d...óÇ[J....
# 00000110h  00 00 00 00 F0 00 22 00 0B 02 09 00 00 DC 00 00  ....d."......Ü..
# 
# 
# Description
# -----------
# This command dumps the first 0x120 bytes of the main module of the currently loaded process (powershell.exe) to stdout.
#.Example
# C:\PS>$proc = [System.Diagnostics.Process]::GetCurrentProcess()
# 
# C:\PS>$module = $proc.MainModule
# 
# C:\PS>$size = $module.ModuleMemorySize
# 
# C:\PS>$base = $module.BaseAddress
# 
# C:\PS>Dump-Memory $base $size -DumpToFile .\out.exe
# 
# 
# Description
# -----------
# This command dumps the entire memory image of powershell.exe to disk in binary format.
# 
# Note: Execution of the dumped memory image requires fixing up the PE header.
#.Link
# My blog: http://www.exploit-monday.com/
##################################################################
    [CmdletBinding()] Param (
        [Parameter(Position = 0, Mandatory = $True)] [System.IntPtr] $Address,
        [Parameter(Position = 1, Mandatory = $True)] [Int] $Offset,
        [Parameter()] [Int] $ProcessId,
        [Parameter()] [Int] $Width = 16,
        [Parameter()] [String] $DumpToFile
    )
    
    $BaseAddress = $Address.ToInt64()
        
    for ($PageOffset = 0; $PageOffset -lt $Offset; $PageOffset += 0x1000)
    {
        $PageBaseAddress = [IntPtr]($BaseAddress + $PageOffset)
            
        if ($ProcessId)
        {
            $MemProtect = Check-MemoryProtection $PageBaseAddress $ProcessId
        }
        else
        {
            $MemProtect = Check-MemoryProtection $PageBaseAddress
        }
            
        if ($MemProtect.Protect -eq [Winapi.Kernel32+AllocationProtectEnum]::PAGE_NOACCESS)
        {
            throw "Memory region at base address 0x$($PageBaseAddress.ToString('X16')) is inaccessible!`n `nMemory Protection Information:`n$($MemProtect | Out-String)`n `n"
        }
    }
    
    [Byte[]] $ByteArray = New-Object Byte[]($Offset)
    
    if ($ProcessId)
    {
        $BytesRead = 0
        $ProcHandle = [Winapi.Kernel32]::OpenProcess(([Winapi.Kernel32+ProcessAccessFlags]::PROCESS_VM_READ), 0, $ProcessId)
        [Winapi.Kernel32]::ReadProcessMemory($ProcHandle, $Address, $ByteArray, $Offset, $BytesRead) | Out-Null
        [Winapi.Kernel32]::CloseHandle($ProcHandle) | Out-Null
    }
    else
    {
        [System.Runtime.InteropServices.Marshal]::Copy($Address, $ByteArray, 0, $Offset)
    }
    
    $Position = 0
    $Padding = ($Width * 2) + $Width
    
    if($DumpToFile)
    {
  
        if ($FilePath = Split-Path $DumpToFile)
        {
            if (Test-Path $FilePath)
            {
                $File = "$(Resolve-Path $FilePath)\$DumpToFile"
            }
            else
            {
                throw "Invalid file path!"
            }
        }
        else
        {
            $File = "$(Resolve-Path .)\$DumpToFile"
        }
        
        $Stream = New-Object System.IO.FileStream($File, [System.IO.FileMode]::Create)
        $Stream.Write($ByteArray, 0, $Offset)
        $Stream.Close()
    }
    else
    {
        while ($Position -le ($Offset-1))
        {
            $Line = ""

            $Line = "$($Position.ToString('X8'))h  "
            $PrintBytes = ""
            $Text = ""

            foreach ($i in 0..($Width-1))
            {
                if ($Position -ge $Offset) {break}
            	
                $PrintBytes += "$($ByteArray[$Position].ToString('X2')) "

                if ( [Char]::IsLetterOrDigit($ByteArray[$Position]) -or [Char]::IsPunctuation($ByteArray[$Position]) -or [Char]::IsSymbol($ByteArray[$Position]) )
                {
                    $Text += [Char] $ByteArray[$Position]
                }
                else
                {
                    $Text += '.'
                }
                
                $Position++
            }

            $Line += $PrintBytes.PadRight($Padding, ' ')
                        
            $Line += " $Text"

            $Line
        }
    }
    
}

function Dump-Strings
{
##################################################################
#.Synopsis
# Retrieves strings from memory.
# 
# Author: Matthew Graeber (@mattifestation)
# License: GNU GPL v2
#.Description
# The Dump-Strings cmdlet retrieves strings from the memory of any process.
#
# Dump-Strings will print both ASCII and Unicode strings to stdout. Its functionality is similar to Sysinternals strings.exe but it operates in memory.
#.Parameter Address
# Specifies the memory base address.
#.Parameter Offset
# Specifies the number of bytes to process.
#.Parameter ProcessId
# Dumps the strings of the process whose ID was specified. Not specifying a process ID will result in querying the address space of powershell.exe.
#.Parameter Encoding
# Specifies the string encoding to use. The default option is 'DEFAULT' which will return both ASCII and Unicode. The other options are 'ASCII' and 'UNICODE'
#.Parameter MinimumLength
# Specifies the minimum length string to return. The default length is 3.
#.Parameter StringOffset
# Specifies the offset in memory where the string occurs.
#.Example
# C:\PS>$proc = Get-Process cmd
# 
# C:\PS>$module = $proc.MainModule
# 
# C:\PS>$size = $module.ModuleMemorySize
# 
# C:\PS>$base = $module.BaseAddress
# 
# C:\PS>Dump-Strings $base $size -MinimumLength 20 -ProcessId $proc.Id
# 
# !This program cannot be run in DOS mode.
# api-ms-win-core-processthreads-l1-1-0.DLL
# SetConsoleInputExeNameW
# APerformUnaryOperation: '%c'
# APerformArithmeticOperation: '%c'
# NtQueryInformationProcess
# SaferComputeTokenFromLevel
# ImpersonateLoggedOnUser
# SaferRecordEventLogEntry
# CreateProcessAsUserW
# GetSecurityDescriptorOwner
# WNetCancelConnection2W
# __C_specific_handler
# RtlLookupFunctionEntry
# ...
# 
# 
# Description
# -----------
# This command prints all Ascii and Unicode strings of length > 19 in the memory space of the main module of cmd.exe.
#.Example
# C:\PS>$proc = [System.Diagnostics.Process]::GetCurrentProcess()
# 
# C:\PS>$module = $proc.Modules | ? { $_.ModuleName -eq 'ntdll.dll' }
# 
# C:\PS>$size = $module.ModuleMemorySize
# 
# C:\PS>$base = $module.BaseAddress
# 
# C:\PS>Dump-Strings $base $size -StringOffset -Encoding 'UNICODE'
# 
# 57416:LdrResFallbackLangList Enter
# 57448:LdrResFallbackLangList Exit
# 136960:KnownDllPath
# 136976:\KnownDlls
# 136992:\SystemRoot
# 137008:\System32\
# 183672:\Registry\Machine\System\CurrentControlSet\Control\MUI\Settings
# 183736::%u.%u.%u.%u
# 183856:%u.%u.%u.%u
# 183872::%u
# 184048:RtlpResUltimateFallbackInfo Enter
# 184088:svchost.exe
# 184104:\Registry\Machine\Software\Microsoft\SQMClient\Windows\DisabledProcesses\
# 184184:GlobalSession
# 184200:\Registry\Machine\Software\Microsoft\SQMClient\Windows\DisabledSessions\
# 
# 
# Description
# -----------
# This command prints all Unicode strings of length > 2 in the loaded module - ntdll.dll within the memory space of powershell.exe.
#.Link
# My blog: http://www.exploit-monday.com/
##################################################################
    [CmdletBinding()] Param (
        [Parameter(Position = 0, Mandatory = $True)] [System.IntPtr] $Address,
        [Parameter(Position = 1, Mandatory = $True)] [Int] $Offset,
        [Parameter()] [Int] $ProcessId,
        [Parameter()] [String] $Encoding = 'DEFAULT',
        [Parameter()] [Int] $MinimumLength = 3,
        [Parameter()] [Switch] $StringOffset
    )
    
    $BaseAddress = $Address.ToInt64()
        
    for ($PageOffset = 0; $PageOffset -lt $Offset; $PageOffset += 0x1000)
    {
        $PageBaseAddress = [IntPtr]($BaseAddress + $PageOffset)
            
        if ($ProcessId)
        {
            $MemProtect = Check-MemoryProtection $PageBaseAddress $ProcessId
        }
        else
        {
            $MemProtect = Check-MemoryProtection $PageBaseAddress
        }
            
        if ($MemProtect.Protect -eq [Winapi.Kernel32+AllocationProtectEnum]::PAGE_NOACCESS)
        {
            throw "Memory region at base address 0x$($PageBaseAddress.ToString('X16')) is inaccessible!`n `nMemory Protection Information:`n$($MemProtect | Out-String)`n `n"
        }
    }
    
    [Byte[]] $ByteArray = New-Object Byte[]($Offset)
    
    if ($ProcessId)
    {
        $BytesRead = 0
        $ProcHandle = [Winapi.Kernel32]::OpenProcess(([Winapi.Kernel32+ProcessAccessFlags]::PROCESS_VM_READ), 0, $ProcessId)
        [Winapi.Kernel32]::ReadProcessMemory($ProcHandle, $Address, $ByteArray, $Offset, $BytesRead) | Out-Null
        [Winapi.Kernel32]::CloseHandle($ProcHandle) | Out-Null
    }
    else
    {
        [System.Runtime.InteropServices.Marshal]::Copy($Address, $ByteArray, 0, $Offset)
    }
    
    if ($Encoding.ToUpper() -eq 'DEFAULT')
    {   # This hack will get the raw ascii chars. The System.Text.UnicodeEncoding object will replace some unprintable chars with question marks.
        $ArrayPtr = [System.Runtime.InteropServices.Marshal]::UnsafeAddrOfPinnedArrayElement($ByteArray, 0)
        $RawString = [System.Runtime.InteropServices.Marshal]::PtrToStringAnsi($ArrayPtr, $ByteArray.Length)
        $Regex = [regex] "[\x20-\x7E]{$MinimumLength,}"
        $Results = $Regex.Matches($RawString)
        # Unicode Regex
        $Encoder = New-Object System.Text.UnicodeEncoding
        $RawString = $Encoder.GetString($ByteArray,  0, $Offset)
        $Regex = [regex] "[\u0020-\u007E]{$MinimumLength,}"
        $Results += $Regex.Matches($RawString)
    }
    elseif ($Encoding.ToUpper() -eq 'ASCII')
    {   # This hack will get the raw ascii chars. The System.Text.UnicodeEncoding object will replace some unprintable chars with question marks.
        $ArrayPtr = [System.Runtime.InteropServices.Marshal]::UnsafeAddrOfPinnedArrayElement($ByteArray, 0)
        $RawString = [System.Runtime.InteropServices.Marshal]::PtrToStringAnsi($ArrayPtr, $ByteArray.Length)
        $Regex = [regex] "[\x20-\x7E]{$MinimumLength,}"
        $Results = $Regex.Matches($RawString)
    }
    else
    {   # Unicode Regex
        $Encoder = New-Object System.Text.UnicodeEncoding
        $RawString = $Encoder.GetString($ByteArray,  0, $Offset)
        $Regex = [regex] "[\u0020-\u007E]{$MinimumLength,}"
        $Results = $Regex.Matches($RawString)
    }
    
    if ($StringOffset)
    {
        $Results | ForEach-Object { "$($_.Index):$($_.Value)" }
    }
    else
    {
        $Results | ForEach-Object { "$($_.Value)" }
    }
}

