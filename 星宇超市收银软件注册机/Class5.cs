using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000E6 RID: 230
public class Class5
{
    // Token: 0x06000A70 RID: 2672
    [DllImport("kernel32.dll")]
    public static extern int lstrlenA(string string_0);

    // Token: 0x06000A71 RID: 2673
    [DllImport("kernel32.dll")]
    public static extern void RtlMoveMemory(byte[] byte_0, string string_0, int int_0);


    // Token: 0x06000A73 RID: 2675 RVA: 0x000C75A8 File Offset: 0x000C57A8
    public uint method_0(string string_0)
    {
        string[] array = new string[]
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"
        };
        string_0 = string_0.ToUpper();
        int num = 1;
        int num2 = 0;
        for (int i = string_0.Length; i > 0; i--)
        {
            string a = string_0.Substring(i - 1, 1);
            int num3 = 0;
            for (int j = 0; j < 16; j++)
            {
                if (a == array[j])
                {
                    num3 = j;
                }
            }
            num2 += num3 * num;
            num *= 16;
        }
        return (uint)num2;
    }

    // Token: 0x06000A74 RID: 2676 RVA: 0x000C76A8 File Offset: 0x000C58A8
    public void method_1(byte[] byte_0, byte[] byte_1, string string_0)
    {
        uint[] array = new uint[16];
        uint num = 2654435769u;
        uint num2 = 0u;
        int length = string_0.Length;
        int num3 = 0;
        for (int i = 1; i <= length; i += 2)
        {
            string string_ = string_0.Substring(i - 1, 2);
            array[num3] = this.method_0(string_);
            num3++;
        }
        uint num4 = 0u;
        uint num5 = 0u;
        uint num6 = 0u;
        uint num7 = 0u;
        for (int i = 0; i <= 3; i++)
        {
            num4 = (array[i] << i * 8 | num4);
            num5 = (array[i + 4] << i * 8 | num5);
            num6 = (array[i + 4 + 4] << i * 8 | num6);
            num7 = (array[i + 4 + 4 + 4] << i * 8 | num7);
        }
        uint num8 = 0u;
        uint num9 = 0u;
        for (int i = 0; i <= 3; i++)
        {
            uint num10 = (uint)byte_0[i];
            num8 = (num10 << i * 8 | num8);
            num10 = (uint)byte_0[i + 4];
            num9 = (num10 << i * 8 | num9);
        }
        for (int i = 32; i > 0; i--)
        {
            num2 = num + num2;
            num8 += ((num9 << 4) + num4 ^ num9 + num2 ^ (num9 >> 5) + num5);
            num9 += ((num8 << 4) + num6 ^ num8 + num2 ^ (num8 >> 5) + num7);
        }
        for (int i = 0; i <= 3; i++)
        {
            byte_1[i] = Convert.ToByte(num8 >> i * 8 & 255u);
            byte_1[i + 4] = Convert.ToByte(num9 >> i * 8 & 255u);
        }
    }


    // Token: 0x06000A76 RID: 2678 RVA: 0x000C79CC File Offset: 0x000C5BCC
    public string method_3(string string_0, string string_1)
    {
        byte[] array = new byte[8];
        byte[] array2 = new byte[8];
        int num = Class5.lstrlenA(string_0) + 1;
        int num2;
        if (num < 8)
        {
            num2 = 8;
        }
        else
        {
            num2 = num;
        }
        byte[] array3 = new byte[num2];
        byte[] array4 = new byte[num2];
        Class5.RtlMoveMemory(array3, string_0, num);
        array3.CopyTo(array4, 0);
        for (int i = 0; i <= num2 - 8; i += 8)
        {
            for (int j = 0; j < 8; j++)
            {
                array[j] = array3[j + i];
            }
            this.method_1(array, array2, string_1);
            for (int j = 0; j < 8; j++)
            {
                array4[j + i] = array2[j];
            }
        }
        string text = "";
        for (int i = 0; i <= num2 - 1; i++)
        {
            text += array4[i].ToString("X2");
        }
        return text;
    }

    // Token: 0x06000A77 RID: 2679 RVA: 0x000C7AA8 File Offset: 0x000C5CA8

    // Token: 0x06000A78 RID: 2680 RVA: 0x000043E7 File Offset: 0x000025E7

}
