using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int metod1 = Index_of("emil hacizade", 'e' );
            Console.WriteLine(metod1);

            int metod2 = Index_of("emil hacizade", 'e', 2);
            Console.WriteLine(metod2);

            int metod3 = Index_of("emil hacizade", 'e' ,3,8);
            Console.WriteLine(metod3);

            string reversed = Reverse("ibrahim yaxsi oglandi");
            Console.WriteLine(reversed);

            string ac = "emlemil asddad qarqamel sdasa ";
            Console.WriteLine(Index_of(ac, "qarqamel"));
            Console.WriteLine(Index_of(ac, "qarqamel", 13));
            Console.WriteLine(Index_of(ac, "qarqamel", 13, ac.Length - 1));
        }


        static int Index_of(string word, char searched)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==searched)
                {
                    return i;
                    
                }
            }
            return -1;
        }

        static int Index_of(string word, char searched, int start)
        {
            for (int i = start; i < word.Length; i++)
            {
                if (word[i] == searched)
                {
                    return i;

                }
            }
            return -1;
        }

        static int Index_of(string word, char searched, int start,int stop)
        {
            for (int i = start; i < stop; i++)
            {
                if (word[i] == searched)
                {
                    return i;

                }
            }
            return -1;
        }

        static int Index_of(string word, string searched)
        {


            int count = 0;

            for (int i = 0; i < word.Length-searched.Length; i++)
            {
                for (int j = 0; j < searched.Length; j++)
                {
                    if (word[i+j] == searched[j])
                    {
                        count++;

                        if (count==searched.Length )
                        {
                            return i;
                        }
                      
                    }
                }

                count = 0;
            }
            return -1;
        }

        static int Index_of(string word, string searched ,int start)
        {

            int count = 0;

            for (int i = start; i < word.Length - searched.Length; i++)
            {
                for (int j = 0; j < searched.Length; j++)
                {
                    if (word[i + j] == searched[j])
                    {
                        count++;

                        if (count == searched.Length)
                        {
                            return i;
                        }

                    }
                }

                count = 0;
            }
            return -1;
        }

        static int Index_of(string word, string searched, int start , int stop)
        {

            int count = 0;

            for (int i = start; i < stop; i++)
            {
                for (int j = 0; j < searched.Length; j++)
                {
                    if (word[i + j] == searched[j])
                    {
                        count++;

                        if (count == searched.Length)
                        {
                            return i;
                        }

                    }
                }

                count = 0;
            }
            return -1;
        }

        static string Reverse(string word)
        {
            string reversed = "";
            string[] wordArr = word.Split(' ');
            for (int i = 0; i < wordArr.Length;i++)
            {
                for (int j = wordArr[i].Length - 1; j > -1; j--)
                {

                    reversed += wordArr[i][j];
                }
                reversed += " ";
            }
          
            return reversed;
        }

    }
}
