using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace APSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string version = "Release 1.0 INDEV";
            Console.Title = "APSharp " + version;

            commandChoose();
        }

        static void commandChoose()
        {
            string version = "Release 1.0 INDEV";


            string userCommand;
            Console.Write("");
            Console.Write("Command: ");
            userCommand = Console.ReadLine();

            if (userCommand == "help" || userCommand == "HELP")
            {
                Console.WriteLine("");
                Console.WriteLine("help: Shows all of the commands.");
                Console.WriteLine("hello: About this software.");
                Console.WriteLine("clear: Clears all of the console interface.");
                Console.WriteLine("exit: Exits from software.");
                Console.WriteLine("txtcolor: Changes color.");
                Console.WriteLine("write: Writes anything you want.");
                Console.WriteLine("title: Changes title.");
                Console.WriteLine("run: Starts a program in an external path.");
                Console.WriteLine("localrun: Starts a program in program's sub path.");
                Console.WriteLine("path: Gives you path of the program.");
                Console.WriteLine("today: Gives today's date.");
                Console.WriteLine("yt: Lets search arguments in YouTube.");
                Console.WriteLine("reddit: Lets search arguments in Reddit.");
                Console.WriteLine("");
                Console.WriteLine("You can write all uppercase or lowercase (Like 'HELP' or 'help', 'Help' won't be accepted).");
                Console.WriteLine("");
                commandChoose();
            }
            else if (userCommand == "exit" || userCommand == "EXIT")
            {
                Console.WriteLine("Exiting after 3 seconds...");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(5000);
            }
            else if (userCommand == "clear" || userCommand == "CLEAR")
            {
                Console.Clear();
                commandChoose();
            }
            else if (userCommand == "txtcolor" || userCommand == "TXTCOLOR")
            {

                string colorChoice;
                Console.Write("Choose your text color (red, blue, white, green, yellow): ");
            colorSelect:
                colorChoice = Console.ReadLine();

                if (colorChoice == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    commandChoose();
                }
                else if (colorChoice == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    commandChoose();
                }
                else if (colorChoice == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    commandChoose();
                }
                else if (colorChoice == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    commandChoose();
                }
                else if (colorChoice == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    commandChoose();
                }
                else
                {
                    Console.WriteLine("Please select a vaild color!");
                    goto colorSelect;
                }

            }
            else if (userCommand == "write" || userCommand == "WRITE")
            {
                string writed;
                Console.Write("Write something: ");
                writed = Console.ReadLine();

                Console.WriteLine(writed);
                commandChoose();
            }
            else if (userCommand == "title" || userCommand == "TITLE")
            {
                string newTitle;
                Console.Write("Change title to: ");
                newTitle = Console.ReadLine();
                Console.Title = newTitle;
                commandChoose();
            }
            else if (userCommand == "run" || userCommand == "RUN")
            {
                string dirToRun;
                Console.Write("Run a path: ");
                dirToRun = Console.ReadLine();
                Process.Start(dirToRun);
                commandChoose();
            }
            else if (userCommand == "localrun" || userCommand == "LOCALRUN")
            {
                string originPath = AppDomain.CurrentDomain.BaseDirectory;

                string dirToRun;
                Console.Write("Run: ");
                dirToRun = Console.ReadLine();
                Process.Start(originPath + dirToRun);
                commandChoose();
            }
            else if (userCommand == "path" || userCommand == "PATH")
            {
                string originPath = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(originPath);
                commandChoose();
            }
            else if (userCommand == "today" || userCommand == "TODAY")
            {
                DateTime today = DateTime.Now;
                Console.WriteLine(today);
                commandChoose();
            }
            else if (userCommand == "hello" || userCommand == "HELLO")
            {
                Console.WriteLine(" _______  _______  _______  __   __  _______  ______    _______ ");
                Console.WriteLine("|   _   ||       ||       ||  | |  ||   _   ||    _ |  |       |");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("|  |_|  ||    _  ||  _____||  |_|  ||  |_|  ||   | ||  |    _  |");
                Console.WriteLine("|       ||   |_| || |_____ |       ||       ||   |_||_ |   |_| |");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("|       ||    ___||_____  ||       ||       ||    __  ||    ___|");
                Console.WriteLine("|   _   ||   |     _____| ||   _   ||   _   ||   |  | ||   |    ");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("|__| |__||___|    |_______||__| |__||__| |__||___|  |_||___|    ");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("APSharp " + version);
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Written by Felixonite42");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Original Consept: Evening18");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("");
                commandChoose();
            }
            else if (userCommand == "8ball" || userCommand == "8BALL")
            {
                lol:
                Random rdm = new Random();
                string question;
                int lucky = rdm.Next(0, 10);
                Console.Write("Write a question can replied as yes/no: ");
                question = Console.ReadLine();

                if (question == "")
                {
                    Console.WriteLine("Type something please.");
                    goto lol;
                }
                else
                {

                    System.Threading.Thread.Sleep(1000);

                    if (lucky == 0)
                    {
                        Console.WriteLine("For sure!");
                        commandChoose();
                    }
                    else if (lucky == 1)
                    {
                        Console.WriteLine("Hmm, why not?");
                        commandChoose();
                    }
                    else if (lucky == 2)
                    {
                        Console.WriteLine("Ahah, no.");
                        commandChoose();
                    }
                    else if (lucky == 3)
                    {
                        Console.WriteLine("Yep!");
                        commandChoose();
                    }
                    else if (lucky == 4)
                    {
                        Console.WriteLine("I don't have any idea.");
                        commandChoose();
                    }
                    else if (lucky == 5)
                    {
                        Console.WriteLine("I don't have any idea.");
                        commandChoose();
                    }
                    else if (lucky == 6)
                    {
                        Console.WriteLine("Almost, but no.");
                        commandChoose();
                    }
                    else if (lucky == 7)
                    {
                        Console.WriteLine("No shit sherlock, yes.");
                        commandChoose();
                    }
                    else if (lucky == 8)
                    {
                        Console.WriteLine("AHAHAHAHHAAAAAAH! ROFL XD");
                        commandChoose();
                    }
                    else if (lucky == 9)
                    {
                        Console.WriteLine("Don't ask me questions again.");
                        commandChoose();
                    }
                    else if (lucky == 10)
                    {
                        Console.WriteLine("Hmm, I'll think about that.");
                        commandChoose();
                    }
                }




            }
            else if (userCommand == "yt" || userCommand == "YT")
            {
                string searchTarget;

                Console.WriteLine("Search YouTube: ");
                searchTarget = Console.ReadLine();

                System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + searchTarget);

                commandChoose();
            }
            else if (userCommand == "reddit" || userCommand == "REDDIT")
            {
                string searchTarget;

                Console.WriteLine("Search Reddit: ");
                searchTarget = Console.ReadLine();

                System.Diagnostics.Process.Start("https://www.reddit.com/search/?q=" + searchTarget);

                commandChoose();
                
            }
            else if (userCommand == "tookip" || userCommand == "TOOKIP")
            {
                string host = Dns.GetHostName();
                string ip = Dns.GetHostByName(host).AddressList[0].ToString();
                Console.WriteLine("IP of the " + host + ": " + ip);

                commandChoose();

            }

            else
            {
                Console.WriteLine("Please enter a vaild command.");
                commandChoose();
            }
        }

    }
}

