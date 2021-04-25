using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Vigenere Cipher ===");
            VigenereDecrypt("OZELNVUXTGWHVUBJLVTYDKURVDVFKPNA", "TRYHARD", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.ReadKey();
        }
        static void VigenereEncrypt(string Text, string key, string alphabet)
        {

            char[] s = Text.ToCharArray();
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (alphabet.Contains(s[i]))
                    s[i] = alphabet[(alphabet.IndexOf(s[i]) + alphabet.IndexOf(key[j])) % alphabet.Length];
                j = (j + 1) % key.Length;
            }
            Console.WriteLine("Encrypted Text");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }

        static void VigenereDecrypt(string Text, string key, string alphabet)
        {
            Console.WriteLine("Text to decode: " + Text);
            char[] s = Text.ToCharArray();
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (alphabet.Contains(s[i]))
                {
                    s[i] = alphabet[(alphabet.IndexOf(s[i]) - alphabet.IndexOf(key[j]) + alphabet.Length) % alphabet.Length];
                    j = (j + 1) % key.Length;
                }
            }
            Console.WriteLine("Decrypted Text");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
    }
}
