﻿using System;

namespace Individuellt_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] accounts;
             




            string[,] users = new string[5, 3];
            int index = 0;
           
            
            
            users[0, 0] = "Filip Oldin"; 
            users[0, 1] = "hemlis123"; 
            users[0, 2] = "24";
             

            users[1, 0] = "Anna Holgersson"; 
            users[1, 1] = "hemlis1234";
            users[1, 2] = "54";
            
            users[2, 0] = "Tobbe Rikardsson"; 
            users[2, 1] = "hemlis12345"; 
            users[2, 2] = "43";

            users[3, 0] = "Kent Käll"; 
            users[3, 1] = "hemlis123456";
            users[3, 2] = "32";

            users[4, 0] = "Eva Hobert"; 
            users[4, 1] = "hemlis1234567";
            users[4, 2] = "19";



            Console.WriteLine("Hej och välkommen till AB Banken");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Skriv in ett ditt användarnam");
            string username = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Skriv in ett ditt lösenord");
            string password = Console.ReadLine();

            accounts = getaccount(username);
           
            if (checkLogin(username, password))
            {
                Console.WriteLine("Du är inloggad!");
                Console.WriteLine("Hej och välkommen till din kontomeny");
                
                 
                
            }
            else
            {
                Console.WriteLine("Fel inloggning, försök igen");
                
            }
            accounts = getaccount(username);



            bool since = true;
            while (since)
            {
                 
                int accou;
                Console.WriteLine("");
                Console.WriteLine(" Skriv in en siffra till den del av kontot du vill till ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Se dina konton och saldo ");
                Console.WriteLine("2. Överföring mellan konton ");
                Console.WriteLine("3. Ta ut pengar ");
                Console.WriteLine("4. Logga ut ");
                Console.WriteLine();
                accou = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // int num = int.Parse(Console.ReadLine()); //skriv alternativ
                switch (accou)

                {
                     
                    case 1:

                        Console.WriteLine("Saldo på lönekonto:");
                        Console.WriteLine(accounts[0]);
                        Console.WriteLine("Saldo på sparkonto: ");
                        Console.WriteLine(accounts[1]);
                        Console.WriteLine("Saldo på semesterkonto: ");
                        Console.WriteLine(accounts[2]);
                        Console.WriteLine("");
                        Console.WriteLine(" Tryck på enter för att återgå till huvudmenyn");
                        break;

                    case 2:

                        Console.WriteLine("Överföring mellan konton");                                             
                        Console.WriteLine("Semesterkonto:" + " " + accounts[0]);
                        Console.WriteLine("Sparkonto:" + " " + accounts[1]);
                        Console.WriteLine("");
                        Console.WriteLine(" Tryck på enter för att återgå till huvudmenyn");

                        break;

                    case 3:
                        Console.WriteLine("Ta ut pengar");
                        accounts[0] = accounts[0] - 1-10000;
                        accounts[1] = accounts[1] + 1-10000;
                        accounts[0] = accounts[0] - 1-1000;
                        accounts[1] = accounts[1] + 1000;
                        Console.WriteLine("Skriv hur mycket du skulle vilja ta ut:");
                        string accounts1 = Console.ReadLine();                         
                        Console.WriteLine("");
                        Console.WriteLine(" Tryck på enter för att återgå till huvudmenyn");
                        break;

                    case 4:
                        Console.WriteLine("Logga ut");
                        Environment.Exit(0);
                        break;
                   
                    default:
                        Console.WriteLine("Ogiltig svar, försök igen");
                        since = false;
                        break;

                }
                Console.WriteLine();
                Console.ReadKey();
            }

        }

        static double [] getaccount(string username)
        {
            switch (username)
            {
                case "Filip Oldin":
                    return new double[] { 20000, 45000, 30000 };
                    break;
                case "Anna Holgersson":
                    return new double[] { 100000, 50000, 240000 };
                    break;
                case "Tobbe Rikardsson":
                    return new double[] { 60000, 130000, 300000 };
                    break;
                case "Kent Käll":
                    return new double[] { 33000, 90000, 50000 };
                    break;
                case "Eva Hobert":
                    return new double[] { 10000, 25000, 10000 };
                    break;
                default:
                    return new double[] {};
                    break;
                
            }
        }

        static bool checkLogin(string username, string password)
        {

            if (username == "Filip Oldin" && password == "hemlis123")
            {
                return true;
            }
            else if (username == "Anna Holgersson" && password == "hemlis1234")
            {
                return true;
            }
            else if (username == "Tobbe Rikardsson" && password == "hemlis12345")
            {
                return true;
            }
            else if (username == "Kent Käll" && password == "hemlis123456")
            {
                return true;
            }
            else if (username == "Eva Hobert" && password == "hemlis1234567")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
    
