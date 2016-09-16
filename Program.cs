using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "some line with text";
            int sentLeng = sentence.Length;
            string[] sent = sentence.Split(' '); //add words into an array
            string longword = "";

            foreach (string word in sent)
            {
                int wordLength = word.Length;
                int longWordLength = longword.Length;
                if (wordLength > longWordLength)
                {
                    longWordLength = wordLength;
                    longword = word;
                } 

            }
            Console.WriteLine(longword);



        }

       
    }

}


