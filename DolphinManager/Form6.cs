using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;



namespace DolphinManager
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_processor");
            ManagementObjectCollection queryCollection1 = query.Get();

            ManagementObjectSearcher queryHardDist = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection queryCollection2 = queryHardDist.Get();

            ManagementObjectSearcher queryMemory = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectCollection queryCollection3 = queryMemory.Get();

            ManagementObjectSearcher queryNetwork = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectCollection queryCollection4 = queryNetwork.Get();

            ManagementObjectSearcher queryTemperature = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection queryCollection5 = queryTemperature.Get();

            ManagementObjectSearcher queryBUS = new ManagementObjectSearcher("SELECT * FROM Win32_Bus");
            ManagementObjectCollection queryCollection6 = queryBUS.Get();




            foreach (ManagementObject mo in queryCollection1)
            { 
                //lstCPU.Items.Add("Name");
                //lstCPU.Items[0].SubItems.Add(Convert.ToString(mo[""]));
                //lstCPU.Items.Add("AddressWidth");
                //lstCPU.Items[1].SubItems.Add(Convert.ToString(mo["AddressWidth"]));
                //lstCPU.Items.Add("Architecture");
                //lstCPU.Items[2].SubItems.Add(Convert.ToString(mo["Architecture"]));
                //lstCPU.Items.Add("Availability");
                //lstCPU.Items[3].SubItems.Add(Convert.ToString(mo["Availability"]));
                //lstCPU.Items.Add("Caption");
                //lstCPU.Items[4].SubItems.Add(Convert.ToString(mo["Caption"]));
                //lstCPU.Items.Add("CpuStatus");
                //lstCPU.Items[5].SubItems.Add(Convert.ToString(mo["CpuStatus"]));
                //lstCPU.Items.Add("CurrentClockSpeed");
                //lstCPU.Items[6].SubItems.Add(Convert.ToString(mo["CurrentClockSpeed"]));
                //lstCPU.Items.Add("L2CacheSize");
                //lstCPU.Items[7].SubItems.Add(Convert.ToString(mo["L2CacheSize"]));
                //lstCPU.Items.Add("MaxClockSpeed");
                //lstCPU.Items[8].SubItems.Add(Convert.ToString(mo["MaxClockSpeed"]));
                lstCPU.Items.Add("Name");//Name
                lstCPU.Items[0].SubItems.Add(Convert.ToString(mo["Name"]));
                lstCPU.Items.Add("Architecture");
                lstCPU.Items[1].SubItems.Add(Convert.ToString(mo["Architecture"]));
                lstCPU.Items.Add("Availability");
                lstCPU.Items[2].SubItems.Add(Convert.ToString(mo["Caption"]));
                lstCPU.Items.Add("CpuStatus");
                lstCPU.Items[3].SubItems.Add(Convert.ToString(mo["CpuStatus"]));
                lstCPU.Items.Add("CreationClassName");
                lstCPU.Items[4].SubItems.Add(Convert.ToString(mo["CreationClassName"]));
                lstCPU.Items.Add("CurrentClockSpeed");
                lstCPU.Items[5].SubItems.Add(Convert.ToString(mo["CurrentClockSpeed"]));
                lstCPU.Items.Add("DataWidth");
                lstCPU.Items[6].SubItems.Add(Convert.ToString(mo["DataWidth"]));
                lstCPU.Items.Add("Description");
                lstCPU.Items[7].SubItems.Add(Convert.ToString(mo["Description"]));
                lstCPU.Items.Add("DeviceID");
                lstCPU.Items[8].SubItems.Add(Convert.ToString(mo["DeviceID"]));
                lstCPU.Items.Add("ExtClock");
                lstCPU.Items[9].SubItems.Add(Convert.ToString(mo["ExtClock"]));
                lstCPU.Items.Add("Family");
                lstCPU.Items[10].SubItems.Add(Convert.ToString(mo["Family"]));
                lstCPU.Items.Add("Level");
                lstCPU.Items[11].SubItems.Add(Convert.ToString(mo["Level"]));
                lstCPU.Items.Add("LoadPercentage");
                lstCPU.Items[12].SubItems.Add(Convert.ToString(mo["LoadPercentage"]));
                lstCPU.Items.Add("Manufacturer");
                lstCPU.Items[13].SubItems.Add(Convert.ToString(mo["Manufacturer"]));
                lstCPU.Items.Add("MaxClockSpeed");
                lstCPU.Items[14].SubItems.Add(Convert.ToString(mo["MaxClockSpeed"]));
                lstCPU.Items.Add("AddressWidth");//AddressWidth
                lstCPU.Items[15].SubItems.Add(Convert.ToString(mo["AddressWidth"]));
                lstCPU.Items.Add("ProcessorId");
                lstCPU.Items[16].SubItems.Add(Convert.ToString(mo["ProcessorId"]));
                lstCPU.Items.Add("ProcessorType");
                lstCPU.Items[17].SubItems.Add(Convert.ToString(mo["ProcessorType"]));
                lstCPU.Items.Add("Revision");
                lstCPU.Items[18].SubItems.Add(Convert.ToString(mo["Revision"]));
                lstCPU.Items.Add("SocketDesignation");
                lstCPU.Items[19].SubItems.Add(Convert.ToString(mo["SocketDesignation"]));
                lstCPU.Items.Add("Status");
                lstCPU.Items[20].SubItems.Add(Convert.ToString(mo["Status"]));
                lstCPU.Items.Add("SystemName");
                lstCPU.Items[21].SubItems.Add(Convert.ToString(mo["SystemName"]));
                lstCPU.Items.Add("UpgradeMethod");
                lstCPU.Items[22].SubItems.Add(Convert.ToString(mo["UpgradeMethod"]));

                //listBox1.Items.Add("AddressWidth:" + Convert.ToString(mo["AddressWidth"]));
                //listBox1.Items.Add("Architecture:" + Convert.ToString(mo["Architecture"]));
                //listBox1.Items.Add("Availability:" + Convert.ToString(mo["Availability"]));
                //listBox1.Items.Add("Caption:" + Convert.ToString(mo["Caption"]));
                //listBox1.Items.Add("ConfigManagerErrorCode:" + Convert.ToString(mo["ConfigManagerErrorCode"]));
                //listBox1.Items.Add("ConfigManagerUserConfig:" + Convert.ToString(mo["ConfigManagerUserConfig"]));
                //listBox1.Items.Add("CpuStatus:" + Convert.ToString(mo["CpuStatus"]));
                //listBox1.Items.Add("CreationClassName:" + Convert.ToString(mo["CreationClassName"]));
                //listBox1.Items.Add("CurrentClockSpeed:" + Convert.ToString(mo["CurrentClockSpeed"]));
                //listBox1.Items.Add("CurrentVoltage:" + Convert.ToString(mo["CurrentVoltage"]));
                //listBox1.Items.Add("DataWidth:" + Convert.ToString(mo["DataWidth"]));
                //listBox1.Items.Add("Description:" + Convert.ToString(mo["Description"]));
                //listBox1.Items.Add("DeviceID:" + Convert.ToString(mo["DeviceID"]));
                //listBox1.Items.Add("ErrorCleared:" + Convert.ToString(mo["ErrorCleared"]));
                //listBox1.Items.Add("ErrorDescription:" + Convert.ToString(mo["ErrorDescription"]));
                //listBox1.Items.Add("ExtClock:" + Convert.ToString(mo["ExtClock"]));
                //listBox1.Items.Add("Family:" + Convert.ToString(mo["Family"]));
                //listBox1.Items.Add("InstallDate:" + Convert.ToString(mo["InstallDate"]));
                //listBox1.Items.Add(c + Convert.ToString(mo["L2CacheSize"]));
                //listBox1.Items.Add("L2CacheSpeed:" + Convert.ToString(mo["L2CacheSpeed"]));
                //listBox1.Items.Add("L2CacheSpeed:" + Convert.ToString(mo["L2CacheSpeed"]));
                //listBox1.Items.Add("LastErrorCode:" + Convert.ToString(mo["LastErrorCode"]));
                //listBox1.Items.Add("Level:" + Convert.ToString(mo["Level"]));
                //listBox1.Items.Add("LoadPercentage:" + Convert.ToString(mo["LoadPercentage"]));
                //listBox1.Items.Add("Manufacturer:" + Convert.ToString(mo["Manufacturer"]));
                //listBox1.Items.Add("MaxClockSpeed:" + Convert.ToString(mo["MaxClockSpeed"]));
                //listBox1.Items.Add("Name:" + Convert.ToString(mo["Name"]));
                //listBox1.Items.Add("OtherFamilyDescription:" + Convert.ToString(mo["OtherFamilyDescription"]));
                //listBox1.Items.Add("PNPDeviceID:" + Convert.ToString(mo["PNPDeviceID"]));
                //listBox1.Items.Add("PowerManagementCapabilities:" + Convert.ToString(mo["PowerManagementCapabilities"]));
                //listBox1.Items.Add("PowerManagementSupported:" + Convert.ToString(mo["PowerManagementSupported"]));
                //listBox1.Items.Add("ProcessorId:" + Convert.ToString(mo["ProcessorId"]));
                //listBox1.Items.Add("ProcessorType:" + Convert.ToString(mo["ProcessorType"]));
                //listBox1.Items.Add("Revision:" + Convert.ToString(mo["Revision"]));
                //listBox1.Items.Add("SocketDesignation:" + Convert.ToString(mo["SocketDesignation"]));
                //listBox1.Items.Add("Status:" + Convert.ToString(mo["Status"]));
                //listBox1.Items.Add("StatusInfo:" + Convert.ToString(mo["StatusInfo"]));
                //listBox1.Items.Add("Stepping:" + Convert.ToString(mo["Stepping"]));
                //listBox1.Items.Add("SystemCreationClassName:" + Convert.ToString(mo["SystemCreationClassName"]));
                //listBox1.Items.Add("SystemName:" + Convert.ToString(mo["SystemName"]));
                //listBox1.Items.Add("UniqueId:" + Convert.ToString(mo["UniqueId"]));
                //listBox1.Items.Add("UpgradeMethod:" + Convert.ToString(mo["UpgradeMethod"]));
                //listBox1.Items.Add("Version:" + Convert.ToString(mo["Version"]));
                //listBox1.Items.Add("VoltageCaps:" + Convert.ToString(mo["VoltageCaps"]));
            }

            foreach (ManagementObject mo2 in queryCollection2)
            {


                lstStorage.Items.Add("Model");
                lstStorage.Items[0].SubItems.Add(Convert.ToString(mo2["Model"]));
                lstStorage.Items.Add("Partitions");
                lstStorage.Items[1].SubItems.Add(Convert.ToString(mo2["Partitions"]));
                lstStorage.Items.Add("SerialNumber");
                lstStorage.Items[2].SubItems.Add(Convert.ToString(mo2["SerialNumber"]));
                lstStorage.Items.Add("Size");
                lstStorage.Items[3].SubItems.Add(Convert.ToString(mo2["Size"]));
                lstStorage.Items.Add("Status");
                lstStorage.Items[4].SubItems.Add(Convert.ToString(mo2["Status"]));
                lstStorage.Items.Add("TotalCylinders");
                lstStorage.Items[5].SubItems.Add(Convert.ToString(mo2["TotalCylinders"]));
                lstStorage.Items.Add("TotalHeads");
                lstStorage.Items[6].SubItems.Add(Convert.ToString(mo2["TotalHeads"]));
                lstStorage.Items.Add("TotalSectors");
                lstStorage.Items[7].SubItems.Add(Convert.ToString(mo2["TotalSectors"]));
                lstStorage.Items.Add("TotalTracks");
                lstStorage.Items[8].SubItems.Add(Convert.ToString(mo2["TotalTracks"]));
                lstStorage.Items.Add("TracksPerCylinder");
                lstStorage.Items[9].SubItems.Add(Convert.ToString(mo2["TracksPerCylinder"]));
                lstStorage.Items.Add("InterfaceType");
                lstStorage.Items[10].SubItems.Add(Convert.ToString(mo2["InterfaceType"]));




                
                  //uint16   Availability;
                  //uint32   BytesPerSector;
                  //uint16   Capabilities[];
                  //string   CapabilityDescriptions[];
                  //string   Caption;
                  //string   CompressionMethod;
                  //uint32   ConfigManagerErrorCode;
                  //boolean  ConfigManagerUserConfig;
                  //string   CreationClassName;
                  //uint64   DefaultBlockSize;
                  //string   Description;
                  //string   DeviceID;
                  //boolean  ErrorCleared;
                  //string   ErrorDescription;
                  //string   ErrorMethodology;
                  //string   FirmwareRevision;
                  //uint32   Index;
                  //datetime InstallDate;
                  //string   InterfaceType;
                  //uint32   LastErrorCode;
                  //string   Manufacturer;
                  //uint64   MaxBlockSize;
                  //uint64   MaxMediaSize;
                  //boolean  MediaLoaded;
                  //string   MediaType;
                  //uint64   MinBlockSize;
                  //string   Model;
                  //string   Name;
                  //boolean  NeedsCleaning;
                  //uint32   NumberOfMediaSupported;
                  //uint32   Partitions;
                  //string   PNPDeviceID;
                  //uint16   PowerManagementCapabilities[];
                  //boolean  PowerManagementSupported;
                  //uint32   SCSIBus;
                  //uint16   SCSILogicalUnit;
                  //uint16   SCSIPort;
                  //uint16   SCSITargetId;
                  //uint32   SectorsPerTrack;
                  //string   SerialNumber;
                  //uint32   Signature;
                  //uint64   Size;
                  //string   Status;
                  //uint16   StatusInfo;
                  //string   SystemCreationClassName;
                  //string   SystemName;
                  //uint64   TotalCylinders;
                  //uint32   TotalHeads;
                  //uint64   TotalSectors;
                  //uint64   TotalTracks;
                  //uint32   TracksPerCylinder;

            }

            foreach (ManagementObject mo3 in queryCollection3)
            {

                lstMemory.Items.Add("Manufacturer");
                lstMemory.Items[0].SubItems.Add(Convert.ToString(mo3["Manufacturer"]));
                lstMemory.Items.Add("Speed");
                lstMemory.Items[1].SubItems.Add(Convert.ToString(mo3["Speed"]));
                lstMemory.Items.Add("PositionInRow");
                lstMemory.Items[2].SubItems.Add(Convert.ToString(mo3["PositionInRow"]));
                lstMemory.Items.Add("SerialNumber");
                lstMemory.Items[3].SubItems.Add(Convert.ToString(mo3["SerialNumber"]));
                lstMemory.Items.Add("Tag");
                lstMemory.Items[4].SubItems.Add(Convert.ToString(mo3["Tag"]));
                lstMemory.Items.Add("DeviceLocator");
                lstMemory.Items[5].SubItems.Add(Convert.ToString(mo3["DeviceLocator"]));
                lstMemory.Items.Add("Description");
                lstMemory.Items[6].SubItems.Add(Convert.ToString(mo3["Description"]));
                lstMemory.Items.Add("Capacity");
                lstMemory.Items[7].SubItems.Add(Convert.ToString(mo3["Capacity"]));
                lstMemory.Items.Add("Caption");
                lstMemory.Items[8].SubItems.Add(Convert.ToString(mo3["Caption"]));
                lstMemory.Items.Add("TypeDetail");
                lstMemory.Items[9].SubItems.Add(Convert.ToString(mo3["TypeDetail"]));

         
         


                //string BankLabel;
                //uint64 Capacity;
                //string Caption;
                //string CreationClassName;
                //uint16 DataWidth;
                //string Description;
                //string DeviceLocator;
                //uint16 FormFactor;
                //boolean HotSwappable;
                //datetime InstallDate;
                //uint16 InterleaveDataDepth;
                //uint32 InterleavePosition;
                //string Manufacturer;
                //uint16 MemoryType;
                //string Model;
                //string Name;
                //string OtherIdentifyingInfo;
                //string PartNumber;
                //uint32 PositionInRow;
                //boolean PoweredOn;
                //boolean Removable;
                //boolean Replaceable;
                //string SerialNumber;
                //string SKU;
                //uint32 Speed;
                //string Status;
                //string Tag;
                //uint16 TotalWidth;
                //uint16 TypeDetail;
                //string Version;
            }

            
        }
    }
}
