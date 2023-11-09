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
            apData data = new apData();
            Console.Title = "APSharp " + data.version;
            commandChoose();
        }

        static void commandChoose()
        {
            apData data = new apData();
            string userCommand;
            Console.Write("");
            Console.Write("Command: ");
            userCommand = Console.ReadLine();

            if (userCommand == "help" || userCommand == "HELP")
            {
                Console.WriteLine("");
                Console.WriteLine("help: Shows all of the commands.");
                Console.WriteLine("about: About this software.");
                Console.WriteLine("clear: Clears all of the console interface.");
                Console.WriteLine("exit: Exits from software.");
                Console.WriteLine("color: Changes color.");
                Console.WriteLine("write: Writes anything you want.");
                Console.WriteLine("title: Changes title.");
                Console.WriteLine("run: Starts a program.");
                Console.WriteLine("html: Lets you download a website as an HTML file.");
                Console.WriteLine("path: Gives you path of the program.");
                Console.WriteLine("");
                Console.WriteLine("You can write all uppercase or lowercase (Like HELP or help).");
                Console.WriteLine("");
                commandChoose();
            }
            else if (userCommand == "about" || userCommand == "ABOUT")
            {
                Console.WriteLine("APSharp - " + data.version);
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
                Console.Write("Run: ");
                dirToRun = Console.ReadLine();
                Process.Start(dirToRun);
                commandChoose();
            }
            else if (userCommand == "localrun" || userCommand == "LOCALRUN")
            {
                string dirToRun;
                Console.Write("Run: ");
                dirToRun = Console.ReadLine();
                Process.Start(data.originPath + dirToRun);
                commandChoose();
            }
            else if (userCommand == "html" || userCommand == "HTML")
            {
                downloadingSys dsys = new downloadingSys();
                dsys.downloadHtml();
                commandChoose();
            }
            else if (userCommand == "path" || userCommand == "PATH")
            {
                Console.WriteLine(data.originPath);
                commandChoose();
            }
            else if (userCommand == "today" || userCommand == "TODAY")
            {
                Console.WriteLine(data.today);
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
                Console.WriteLine("APSharp " + data.version);
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Written by Felixonite42");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Original Consept: WindowsUniverse");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("");
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