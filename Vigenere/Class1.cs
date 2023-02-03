using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereClass
{
    public class Vigenere
    {
        static string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public char[] alph = letter.ToCharArray();
        /// <summary>
        /// Шифровка
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="charword">Символы текста</param>
        /// <returns></returns>
        public char[] Code(char[] key, char[] charword)
        {
            for (int i = 0; i < key.Length; i++)
            {
                string copy = key[i].ToString();
                copy = copy.ToUpper();
                key[i] = Convert.ToChar(copy);
            }
            int count = 0;
            for (int i = 0; i < charword.Length; i++)
            {
                int a = 0;
                string copy = charword[i].ToString();
                copy = copy.ToUpper();
                if (charword[i] != Convert.ToChar(copy))
                {
                    charword[i] = Convert.ToChar(copy);
                    a = 1;
                }
                if (Array.IndexOf(alph, charword[i]) < 0 || Array.IndexOf(alph, charword[i]) > 25 || charword[i] != alph[Array.IndexOf(alph, charword[i])])
                {
                    continue;
                }
                int index = Array.IndexOf(alph, charword[i]) + Array.IndexOf(alph, key[count]);
                if (index > 25)
                {
                    index -= 26;
                }
                charword[i] = alph[index];
                if (a == 1)
                {
                    copy = alph[index].ToString();
                    copy = copy.ToLower();
                    charword[i] = Convert.ToChar(copy);
                }
                count++;

                if (count > key.Length - 1)
                {
                    count = 0;
                }
            }
            return charword;
        }
        /// <summary>
        /// Расшифровка
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="charword">Символы текста</param>
        /// <returns></returns>
        public char[] Decode(char[] key, char[] charword)
        {
            for (int i = 0; i < key.Length; i++)
            {
                string copy = key[i].ToString();
                copy = copy.ToUpper();
                key[i] = Convert.ToChar(copy);
            }
            int count = 0;
            for (int i = 0; i < charword.Length; i++)
            {
                int a = 0;
                string copy = charword[i].ToString();
                copy = copy.ToUpper();
                if (charword[i] != Convert.ToChar(copy))
                {
                    charword[i] = Convert.ToChar(copy);
                    a = 1;
                }
                if (Array.IndexOf(alph, charword[i]) < 0 || Array.IndexOf(alph, charword[i]) > 25 || charword[i] != alph[Array.IndexOf(alph, charword[i])])
                {
                    continue;
                }
                int index = Array.IndexOf(alph, charword[i]) - Array.IndexOf(alph, key[count]);
                if (index < 0)
                {
                    index += 26;
                }
                charword[i] = alph[index];
                if (a == 1)
                {
                    copy = alph[index].ToString();
                    copy = copy.ToLower();
                    charword[i] = Convert.ToChar(copy);
                }
                count++;
                if (count > key.Length - 1)
                {
                    count = 0;
                }
            }
            return charword;
        }
    }
}