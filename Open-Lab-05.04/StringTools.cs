using System;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            string ret = "";
            string[] specialChar = {"!", "@", "#", "$", "%", "%", "^", "&", "*", "(", ")", "=", "+", "[", "{", "]", "}", ";", "\"", "'", "|", "\\", ",", "<", ">", ".", "/", "?", "~", "`", ":" };
            bool canWrite = true;

            for (int i = 0; i < original.Length; i++)
            {
                canWrite = true;
                for( int y = 0; y < specialChar.Length; y++)
                {
                    if( specialChar[y] == original.ToCharArray()[i].ToString())
                    {
                        canWrite = false;
                        break;
                    }
                }
                if(canWrite) ret += original.ToCharArray()[i].ToString();
            }
            return ret;
        }
    }
}
