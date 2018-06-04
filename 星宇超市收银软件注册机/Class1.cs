using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200008E RID: 142
public class Class1
{
    // Token: 0x06000617 RID: 1559 RVA: 0x0007F854 File Offset: 0x0007DA54
    public static int smethod_0(ref string string_0)
    {
        int result = 0;
        string_0 = Class1.smethod_1();
        if (string_0 != "")
        {
            result = 0;
        }
        if (string_0 == "")
        {
            string_0 = Class1.smethod_8();
            if (string_0 != "" && string_0 != "None")
            {
                result = 2;
            }
        }
        if (string_0 == "")
        {
            string_0 = Class1.smethod_7();
            if (string_0 != "")
            {
                result = 3;
            }
        }
        if (string_0 == "")
        {
            string_0 = Class1.smethod_5();
            if (string_0 != "")
            {
                result = 4;
            }
        }
        if (string_0 == "")
        {
            string_0 = Class1.smethod_4();
            if (string_0 != "")
            {
                result = 5;
            }
        }
        return result;
    }

    // Token: 0x06000618 RID: 1560 RVA: 0x0007F950 File Offset: 0x0007DB50
    public static string smethod_1()
    {
        string result;
        try
        {
            string text = "";
            ManagementClass managementClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection instances = managementClass.GetInstances();
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    PropertyData propertyData = managementObject.Properties["ProcessorId"];
                    if (propertyData.Value != null)
                    {
                        text = propertyData.Value.ToString();
                    }
                }
            }
            result = text.Trim();
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x06000619 RID: 1561 RVA: 0x0007FA00 File Offset: 0x0007DC00
    public static string smethod_2()
    {
        string text = Class1.smethod_3();
        if (!string.IsNullOrEmpty(text))
        {
            text = text.Replace(":", "");
        }
        return text;
    }

    // Token: 0x0600061A RID: 1562 RVA: 0x0007FA30 File Offset: 0x0007DC30
    public static string smethod_3()
    {
        string result;
        try
        {
            string text = "";
            ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection instances = managementClass.GetInstances();
            foreach (ManagementBaseObject managementBaseObject in instances)
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                if ((bool)managementObject["IPEnabled"])
                {
                    text = managementObject["MacAddress"].ToString();
                    break;
                }
            }
            result = text;
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x0600061B RID: 1563 RVA: 0x0007FADC File Offset: 0x0007DCDC
    public static string smethod_4()
    {
        string result;
        try
        {
            string text = "";
            ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection instances = managementClass.GetInstances();
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    PropertyData propertyData = managementObject.Properties["Model"];
                    if (propertyData.Value != null)
                    {
                        text = propertyData.Value.ToString();
                    }
                }
            }
            result = text.Trim();
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x0600061C RID: 1564 RVA: 0x0007FB8C File Offset: 0x0007DD8C
    public static string smethod_5()
    {
        string result;
        try
        {
            ManagementClass managementClass = new ManagementClass("Win32_PhysicalMedia");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = "";
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    PropertyData propertyData = managementObject.Properties["SerialNumber"];
                    if (propertyData.Value != null)
                    {
                        text = propertyData.Value.ToString();
                    }
                }
            }
            result = text.Trim();
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x0600061D RID: 1565 RVA: 0x0007FC38 File Offset: 0x0007DE38


    // Token: 0x0600061E RID: 1566 RVA: 0x0007FC6C File Offset: 0x0007DE6C
    public static string smethod_7()
    {
        string result;
        try
        {
            ManagementClass managementClass = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = "";
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    PropertyData propertyData = managementObject.Properties["SerialNumber"];
                    if (propertyData.Value != null)
                    {
                        text = propertyData.Value.ToString();
                    }
                }
            }
            result = text.Trim();
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x0600061F RID: 1567 RVA: 0x0007FD18 File Offset: 0x0007DF18
    public static string smethod_8()
    {
        string result;
        try
        {
            ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = "";
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    PropertyData propertyData = managementObject.Properties["SerialNumber"];
                    if (propertyData.Value != null)
                    {
                        text = propertyData.Value.ToString();
                    }
                }
            }
            result = text.Trim();
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x06000620 RID: 1568 RVA: 0x000043E7 File Offset: 0x000025E7

    // Token: 0x0200008F RID: 143

}
