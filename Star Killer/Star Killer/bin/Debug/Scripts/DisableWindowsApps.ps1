####################################
## Uninistall Windows Apps
# Mspaint, Calculator, Cortana etc.
# Using Yara you can find they have keyloggers 
# and are unsecure according to DOD STIG GUIDE.
# often exploited on to
# Created by Sam Arnold on 6/23/17
#
#####################################

write-host "Uninistall Windows Apps
# Mspaint, Calculator, Cortana etc.
# Using Yara you can find they have keyloggers 
# and are unsecure according to DOD STIG GUIDE." -foregroundcolor red;

write-host "Do you wish to Continue (yes) or (n)"  -foregroundcolor cyan;


$confirmation = Read-Host "Are you Sure You Want To Proceed:"
if (($confirmation -eq 'y') -or($confirmation -eq 'yes') )  {
    Get-AppxPackage | Remove-AppxPackage
	Get-AppxProvisionedPackage -Online | Remove-AppxProvisionedPackage -online
}