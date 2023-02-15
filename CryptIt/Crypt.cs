using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptIt
{
    class Crypt
    {
        public String encrypt(String text, int salt){
            String newtext = "";

            int newC;
            int oldC;

            for(int i = 0; i < text.Length; i++){
                newC = oldC = (int)text[i];

                if (oldC >= 'a' && oldC <= 'z'){

                    newC = oldC + salt;

                    if (newC > 'z'){
                        newC -= 26;
                    }
                } else if (oldC >= 'A' && oldC <= 'Z'){

                    newC = oldC + salt;

                    if (newC > 'Z'){
                        newC -= 26;
                    }
                }

                newtext += (char) newC;
            }

            return newtext;
        }

        public String decrypt(String text, int salt)
        {
            String newtext = "";

            int newC;
            int oldC;

            for (int i = 0; i < text.Length; i++)
            {
                newC = oldC = (int)text[i];

                if (oldC >= 'a' && oldC <= 'z')
                {
                    newC = oldC - salt;

                    if (newC < 'a')
                    {
                        newC += 26;
                    }
                }
                else if (oldC >= 'A' && oldC <= 'Z')
                {
                    newC = oldC - salt;

                    if (newC < 'A')
                    {
                        newC += 26;
                    }
                }

                newtext += (char)newC;
            }

            return newtext;
        }
    }
}
