using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCode.Array
{
    internal class EncodeDecode
    {
        // Encodes a list of strings to a single string.
        public static string Encode(List<string> strs)
        {
            if(strs==null || strs.Count==0) return string.Empty;
            var encoded = new System.Text.StringBuilder();
            foreach (var str in strs)
            {
                //Replace every occurance of # with 
                encoded.Append(str.Length).Append("##").Append(str);
            }
            return encoded.ToString();
        }

        public static List<String> Decode(String str)
        {
            if (string.IsNullOrEmpty(str)) return new List<string>();
            var decoded = new List<String>();
            int i = 0;
            while(i< str.Length)
            {
                //3##anoj2##fo
                //find the position of delimeter
                int j = str.IndexOf("##", i);
                int length = int.Parse(str.Substring(i,j-i));
                string strNew = str.Substring(j+2, length);
                decoded.Add(strNew);
                i = j+length+2;
            }
            return decoded;
        }
    }

}
