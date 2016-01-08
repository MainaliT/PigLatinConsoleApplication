using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {

        static void Main(string[] args)
        {
            string input;
          
            char[] totalLetters;
            int[] numCount;
            int ifNumbers;
            string pigLatin = "";
           
            Console.WriteLine("Please enter the word");
            input = Console.ReadLine();

            totalLetters = input.ToArray();
            //endWordLetter = new char[totalLetters.Length];

            numCount = new int[totalLetters.Length];
            ifNumbers = 0;

            for (int i = 0; i < totalLetters.Length; i++) {
                numCount[i] = (int)totalLetters[i];
                if(numCount[i] >= 48 && numCount[i] <= 57){
                    ++ifNumbers;
            }
            }


            if (ifNumbers == totalLetters.Length)
            {
                pigLatin = input + "-way";
            }
            else
            {
                if (totalLetters[0] == 'a' || totalLetters[0] == 'A' || totalLetters[0] == 'e' || totalLetters[0] == 'E' || totalLetters[0] == 'i' || totalLetters[0] == 'I' || totalLetters[0] == 'o' || totalLetters[0] == 'O' || totalLetters[0] == 'u' || totalLetters[0] == 'U')
                {
                    for (int i = 0; i < totalLetters.Length; i++)
                    {
                        pigLatin += totalLetters[i];
                    }
                    pigLatin += "-way";
                }
                else
                {
                    String temporary = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' || input[i] == 'u' || input[i] == 'U')
                        {
                            pigLatin += input.Substring(i, input.Length - i);
                            break;
                        }
                        else
                            temporary += input[i];
                    }

                   
                    pigLatin += "-";

                    pigLatin += temporary;
                    pigLatin += "ay";
                }
            }

            Console.WriteLine(pigLatin);
            Console.ReadLine();
        }

    }
}
