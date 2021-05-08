using System;

namespace Tokenizzzer
{
    class Program
    {
        static void tokenizer(string source)
        {
            int index = 0;

            //Console.WriteLine(" inside loop ");

            while (index < source.Length)
            {
                //Console.WriteLine("inside while");
                string concat = "";
                if (source[index] == '#')
                {
                    //Console.WriteLine("found #");
                    int i = 1;
                    int iii = index + 1;
                    
                    while (Char.IsLetter(source[iii]) && iii < source.Length)
                    {
                        Console.WriteLine("inside");
                        if (!Char.IsLetter(source[iii]))
                        {
                            if (i < 7)
                            {
                                int ii = index+1;
                                while (i < 7 && source[ii] < source.Length)
                                {
                                    
                                    concat += "0";
                                    i++;
                                    ii++;
                                }
                            }
                            else if (i < 7)
                        {
                            concat += source[index + 1];
                            i++;
                            index++;
                        }


                    }
                        iii++;
                    
                    }


                }
                index++;
                Console.WriteLine(concat);
            }
        }
        static void Main(string[] args)
        {

            string value = "this color is #F2AYBC #f #12C";
            tokenizer(value);
            Console.WriteLine("Hello World!");
            //tokenizer(value9);
        }
    }
}
