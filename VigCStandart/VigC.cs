using System;
using System.Diagnostics;

namespace VigCStandart
{
    public class Vigenere
    {
        private string _letter;

        private char[] _alph;

        public Vigenere()
        {
            _letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            _alph = Letter.ToCharArray();
        }

        public string Letter
        {
            get => _letter;
            set => _letter = value;
        }


        /// <summary>
        /// Алфавит
        /// </summary>
        public char[] Alph { get => _alph; set => _alph = value; }

        /// <summary>
        /// Зашифровывает сообщение
        /// </summary>
        /// <param name="key">Ключ к шифру</param>
        /// <param name="charword">Текст</param>
        /// <returns></returns>
        public char[] Code(char[] key, char[] charword)
        {
            for (int j = 0; j < key.Length; j++)
            {
                string copy = key[j].ToString();
                copy = copy.ToUpper();
                key[j] = Convert.ToChar(copy);
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
                Console.WriteLine(Alph[Array.IndexOf(Alph, charword[i])]);
                if (Array.IndexOf(Alph, charword[i]) < 0 || Array.IndexOf(Alph, charword[i]) > 25 || charword[i] != Alph[Array.IndexOf(Alph, charword[i])])
                {
                    continue;
                }
                int index = Array.IndexOf(Alph, charword[i]) + Array.IndexOf(Alph, key[count]);
                if (index > 25)
                {
                    index -= 26;
                }
                charword[i] = Alph[index];
                if (a == 1)
                {
                    copy = Alph[index].ToString();
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
                if (Array.IndexOf(Alph, charword[i]) < 0 || Array.IndexOf(Alph, charword[i]) > 25 || charword[i] != Alph[Array.IndexOf(Alph, charword[i])])
                {
                    continue;
                }
                int index = Array.IndexOf(Alph, charword[i]) - Array.IndexOf(Alph, key[count]);
                if (index < 0)
                {
                    index += 26;
                }
                charword[i] = Alph[index];
                if (a == 1)
                {
                    copy = Alph[index].ToString();
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
