﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Star_Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           // this.TopMost = true;
            WindowState = FormWindowState.Maximized;

        }


     

        [DllImport("user32.dll")]
         static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        //private extern static bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        private void button1_Click(object sender, EventArgs e)
        {
            //antiPwny
         
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys";
            P1.FileName = @"AntiPwny.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
           // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.panel1.AutoScroll = false;
            this.panel1.HorizontalScroll.Enabled = false;
            this.panel1.HorizontalScroll.Visible = false;
            this.panel1.HorizontalScroll.Maximum = 0;
            this.panel1.VerticalScroll.Enabled = true;
            this.panel1.VerticalScroll.Visible = true;
            this.panel1.VerticalScroll.Maximum = 0;
            base.VerticalScroll.Visible = true;

            base.HorizontalScroll.Visible = true;


            this.panel1.AutoScroll = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys";
            P1.FileName = @"procexp.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // User Access
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\AntiMeter";
            _processStartInfo.FileName = @"antimeter.exe";
           _processStartInfo.Arguments = " $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
           // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cryptobutton
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys";
            P1.FileName = @"CryptoPreventSetupV8.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // D7
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\d7";
            P1.FileName = @"d7.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            //SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //AntiMeter
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\AntiMeter";
            P1.FileName = @"AntiMeter.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
             _processStartInfo.Arguments = " netstat -a -b  -n -o 25; $host.enternestedprompt()";
             //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //TCP
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SysInternals";
            P1.FileName = @"TCPView.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
          //  
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Ram Map
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SysInternals";
            P1.FileName = @"RAMMap.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Shadow Files
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys";
            P1.FileName = @"ShadowExplorerPortable.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = " net use; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = " net view; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = " net start; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          //  panel1.VerticalScroll.Value = bar.Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = " net session; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // NBT Stat? Doesnt work???
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "nbtstat -s 15; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(100);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = " net user; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "net localgroup administrators; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            //Ram Map
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\OSfuscate";
            P1.FileName = @"OSfuscate.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //BaseLine Analyzer
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://www.microsoft.com/en-us/download/details.aspx?id=7558";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            // KIll CMD
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "taskkill /F /IM cmd.exe /T; $host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // KIll powershell
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "taskkill /F /IM powershell.exe /T";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button35_Click(object sender, EventArgs e)
        {
            // Open DNS
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"%HOMEDRIVE%%HOMEPATH%";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "netsh interface show interface; netsh dnsclient add dnsserver 'Local Area Connection' 208.67.222.222 1; netsh dnsclient add dnsserver 'Local Area Connection' 208.67.220.220 2; $host.enternestedprompt();$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //photo Analyzer
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://29a.ch/photo-forensics/#forensic-magnifier";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //Quip QUuip
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "http://quipqiup.com";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //RumKIn
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "http://rumkin.com/tools/cipher/";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //DCODE
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "http://www.dcode.fr/tools-list";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //Setup py
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./Get_Setup_evolve.bat;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            // Rubber Glue
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Pluggys/RubberGlue";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "echo 'Running Rubber Glue on port 2222';python rubberglue.py 2222;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            // test cat
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day1-PowerShell";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Control_GUI_App.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            // Block Cortana
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day1-PowerShell";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Block-Cortana.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            // Check Services
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening/Services";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Get-ServiceIdentity.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            // reset Pass
     
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File easypassword2.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "netplwiz;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //Vahalla Files
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys";
            P1.FileName = @"honeypot.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //RumKIn
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://ninite.com";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //ADS Detetor
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\ADSMangager";
            P1.FileName = @"ADSManager.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //System Explorer
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SystemExplorer";
            P1.FileName = @"SystemExplorerSetup.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "ping 8.8.8.8;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File yara.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }


        private void button51_Click(object sender, EventArgs e)
        {
            // YARA 
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara\YaraGui";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./yaragui.exe; ii ./../Rules;";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow =false;
     
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(500);
            this.AllowDrop = true;
            panel1.AllowDrop = true;
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            // this.DragEnter += Form1_DragEnter;
            //this.DragDrop += Form1_DragDrop;
        




        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "C:/Windows/System32/UserAccountControlSettings.exe";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //Naleware bytes download
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://www.malwarebytes.com/premium/";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
            
        }

        private void button54_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "driverquery;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            // User Settings Windows
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"C:/Windows/System32";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "bcdedit /set nx AlwaysOn;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {
            // yara scan all processes
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Yara3.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            // yResouce monitor
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "resmon";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            // yara 2 scan all processes exploiits
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Yara2.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            // yara 2 scan all processes exploiits
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Yara1.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            // Set DOD Basele Secure Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening/Secure-Host-Baseline";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File Invoke-SHB.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            // Set DOD Basele Secure Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Pluggys/Injection Monitor";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File ProInj.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            // Set DOD Basele Secure Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day6-Servers/IPv6";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./Disable_IPv6_KB929852.reg";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            // Set IE private mode Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./IE-Private-Mode-Default.reg";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            // Get Insecure Service
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening/Services";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File ./Get-InsecureServiceBinaryPath.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            // Get Service privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening/Services";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File ./Get-ServicePrivileges.ps1;$host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            // Get Service privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/SANS-SEC505-master/scripts/Day2-Hardening/Services";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File ./Audit-Service-Creation.ps1;$host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // set CMD / Powershell Privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Pluggys/CHML";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./SoftwarePolicy210Setup.exe; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            // set CMD / Powershell Privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Pluggys/CHML";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./softwarepolicy.ini; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            // Get Service privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./Set_Up_Banner.ps1;$host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            // Set IE private mode Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts/";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "./Window_8_Stig.reg";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            // Event veiwer
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @".\Pluggys\Yara";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "eventvwr";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button71_Click(object sender, EventArgs e)
        {

            //EMET download
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://www.microsoft.com/en-us/download/details.aspx?id=54264";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);

        }

        private void button72_Click(object sender, EventArgs e)
        {
            //VaraCrypt
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\VaraCrypt";
            P1.FileName = @"VeraCryptSetup1.21.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(1000);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            //Secure Desktop
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"SecureDesktop-GUI.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button73_Click_1(object sender, EventArgs e)
        {
            //Secure Desktop
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"SecureDesktop-GUI.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
           // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            //Secure Desktop
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"mmc.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            //Secure Desktop
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"Regedit.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            //lusrmgr.msc
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"lusrmgr.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            // shared folders
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"fsmgmt.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            // services
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"services.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            //certmgr.msc
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"certmgr.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            //computer management
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"compmgmt.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            //Direct X Diagnostic
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"dxdiag.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            // File / Driver verifier sigverif
            //Direct X Diagnostic
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"sigverif.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            // Group Policy Edit.
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"gpedit.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            // Local Security
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"gpedit.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            //Advanced WIndows firewall
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"wf.msc";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            //Windows Maleware Remover
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"mrt.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            //Windows Maleware Remover
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"syskey.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            //Data Exctuon Prevetion
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"SystemPropertiesDataExecutionPrevention";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            //SystemPropertiesProtection
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\SecureDesktop";
            P1.FileName = @"SystemPropertiesProtection";
            P1.FileName = @"SystemPropertiesProtection";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            // Set DOD Basele Secure Group Policy
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File EnableGodmode.ps1;$host.enternestedprompt()";
            //_processStartInfo.Arguments = "-noexit; cd ./Pluggys ; $host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button91_Click(object sender, EventArgs e)
        {

            //ARP Defender
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "http://binaryplant.com";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            //SYS INTERNALS
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://docs.microsoft.com/en-us/sysinternals/downloads/sysinternals-suite";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            //RW EVERYTHING
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://rweverything.com/download/";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            // Get Service privalages
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = @"./Scripts";
            _processStartInfo.FileName = @"powershell.exe";
            _processStartInfo.Arguments = "powershell -noexit -executionpolicy bypass -File ./DisableWindowsApps.ps1;$host.enternestedprompt()";
            _processStartInfo.CreateNoWindow = true;
            Process myProcess = Process.Start(_processStartInfo);
            Thread.Sleep(1500);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            // File / Driver verifier sigverif
            //Direct X Diagnostic
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\hijackthis";
            P1.FileName = @"HijackThis.exe";
            //P4.Arguments = "";
            //P1.CreateNoWindow = true;
            P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(500);
            // SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            //OS Forensics
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://www.osforensics.com/index.html";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            //Voltality Workbench
            ProcessStartInfo P1 = new ProcessStartInfo();
            P1.WorkingDirectory = @".\Pluggys\";
            P1.FileName = @"iexplore.exe";
            P1.Arguments = "https://www.osforensics.com/tools/";
            //P1.CreateNoWindow = true;
            // P1.WindowStyle = ProcessWindowStyle.Normal;
            Process myProcess = Process.Start(P1);
            Thread.Sleep(10);
            SetParent(myProcess.MainWindowHandle, panel1.Handle);
        }
    }
}
