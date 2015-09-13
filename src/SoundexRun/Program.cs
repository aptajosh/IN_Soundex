using SoundexCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoundexRun
{
    class Program
    {
        static void Main(string[] args)
        {

            Soundex snd = new Soundex("Riya");
            Soundex snd1 = new Soundex("Ria");
            Soundex snd2 = new Soundex("Rajeev");
            Soundex snd3 = new Soundex("Rajiv");
            Soundex snd6 = new Soundex("Pascal");
            Soundex snd7 = new Soundex("Pascul");
            Soundex snd8 = new Soundex("Sanket");
            Soundex snd9 = new Soundex("Sunket");
            Soundex snd10 = new Soundex("Sankat");
            

            Console.WriteLine("Soundex For Riya :" + snd.IN_Soundex + " Soundex For Ria :"+snd1.IN_Soundex); //Matches
            Console.WriteLine("Soundex For Rajeev :" + snd2.IN_Soundex + " Soundex For Rajivv :" + snd3.IN_Soundex); //Matches 
            Console.WriteLine("Soundex For Pascal :" + snd6.IN_Soundex + " Soundex For Pascul :" + snd7.IN_Soundex); //Matches
            Console.WriteLine("Soundex For Sanket :" + snd8.IN_Soundex + " Soundex For Sunket :" + snd9.IN_Soundex); //Matches
            Console.WriteLine("Soundex For Sanket :" + snd8.IN_Soundex + " Soundex For Sunkat :" + snd10.IN_Soundex); //Doesn't Match

            Console.WriteLine("");
           
            while (true)
            {

                Console.WriteLine("Insert Name To calulate Soundex: ");
                string name = "";
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name.Trim()) || name.Trim() == "13")
                {
                    Console.WriteLine("Insert Some Text To calulate Soundex: ");
                    name = Console.ReadLine();
                }
                else
                {
                    Soundex result = new Soundex(name);
                    Console.WriteLine("Soundex For The text \" " + name + "  \": " + result.IN_Soundex );
                    string cont = "";
                    Console.WriteLine("Do you want to continue... Press Y/y to countinue: ");

                    cont = Console.ReadLine();
                    if (cont.ToUpper().Trim() != "Y")
                    {
                       break;
                    }
                }
            }
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
    }
}
