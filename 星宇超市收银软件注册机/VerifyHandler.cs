using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 星宇超市收银软件注册机
{
    class VerifyHandler
    {
        public static string m_strHardID { get; private set; }

        public static string GetHardID()
        {
            string text = "";
            int num = Class1.smethod_0(ref text);
            VerifyHandler.m_strHardID = text;
            text += Const.HardIDAddition;
            Class5 @class = new Class5();
            text = @class.method_3(text, Const.AlgorithmGeieralKey_HardID);
            if (text.Length > 32)
            {
                char[] array = text.ToCharArray(0, 32);
                for (int i = 0; i < 32; i++)
                {
                    if (i % 2 == 0)
                    {
                        array[i] = text[text.Length - 1 - i];
                    }
                }
                text = new string(array);
            }
            if (num > 0)
            {
                text = text + "TP" + num.ToString();
            }
            return text;
        }

        public static string GetSNByHardID(string string_1, string strName)
        {
            string text = string_1 + strName;
            Class5 @class = new Class5();
            text = @class.method_3(text, Const.AlgorithmGeieralKey_HardID);
            return @class.method_3(text, Const.AlgorithmGeieralKey_HardID);
        }
    }
}
