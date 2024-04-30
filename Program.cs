using System;
using System.Diagnostics;
using System.Net;
using Figgle;

namespace APSHelper
{
    class Program
    {

        static void Main(string[] args)
        {
            string version = "1.0 ForkedBuild";
            Console.Title = "APS-Helper " + version;

            commandChoose();
        }

        static void commandChoose()
        {
            string version = "Release 1.0 ForkedBuild";

            string userCommand;
            Console.Write("");
            Console.Write("Command: ");
            userCommand = Console.ReadLine();

            switch (userCommand.ToLower())
            {
                case "help":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(FiggleFonts.Larry3d.Render("Help"));
                    Console.WriteLine("");
                    Console.WriteLine("* = Case Sensitive");
                    Console.WriteLine("");
                    Console.WriteLine("help: Shows this menu.");
                    Console.WriteLine("about: About this software.");
                    Console.WriteLine("clear: Clears all of the console interface.");
                    Console.WriteLine("color [insert color]: Changes the color of the text. *");
                    Console.WriteLine("title: Changes command prompt title. *");
                    Console.WriteLine("today: Prints out the current date.");
                    Console.WriteLine("8ball: Ask 8Ball.");
                    Console.WriteLine("yt [insert search query]: Searches the query on YouTube. *");
                    Console.WriteLine("reddit [insert search query]: Searches the query on Reddit. *");
                    Console.WriteLine("exit: Closes the command prompt.");
                    Console.WriteLine("");
                    commandChoose();
                    break;

                case "about":
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Larry3d.Render("APS-Helper"));
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("APS-Helper " + version);
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Fork written by Pwerrr");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("APSharp by Felixonite42");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Original AP-DOS by Nevideat");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("");
                    commandChoose();
                    break;

                case "clear":
                    Console.Clear();
                    commandChoose();
                    break;

                case "time":
                    Console.Clear();
                    DateTime today = DateTime.Now;
                    Console.WriteLine(today);
                    commandChoose();
                    break;

                case "8ball":
                    Chosen8BallResponse();
                    break;

                case "exit":
                    Environment.Exit(5000);
                    break;

            }

            #region If commands
            if (userCommand.Contains("color"))
            {
                Console.Clear();
                string chosenColor = "";
                chosenColor = userCommand.Replace("color", "");
                ConsoleColor consoleColor = ConsoleColor.White;
                try
                {
                    consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), chosenColor, true);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose a valid color.");
                }
                Console.ForegroundColor = consoleColor;
                commandChoose();
            }
            else if(userCommand.Contains("title"))
            {
                Console.Clear();
                string writtenTitle = "";
                writtenTitle = userCommand.Replace("title", "");
                Console.Title = writtenTitle;
                commandChoose();
            }
            else if (userCommand.Contains("yt"))
            {
                Console.Clear();
                string query = "";
                query = userCommand.Replace("yt", "");
                System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + query);
                commandChoose();
            }
            else if (userCommand.Contains("reddit"))
            {
                Console.Clear();
                string query = "";
                query = userCommand.Replace("reddit", "");
                System.Diagnostics.Process.Start("https://www.reddit.com/search/?q=" + query);
                commandChoose();
            }
            else
            {
                Console.WriteLine("Please enter a vaild command.");
                commandChoose();
            }
            #endregion
        }


        static void Chosen8BallResponse()
        {
            lol:
            Random rdm = new Random();
            string question;
            int lucky = rdm.Next(0, 10);
            Console.Write("Please write down a yes/no question: ");
            question = Console.ReadLine();

            if (question == "")
            {
                Console.WriteLine("Type something please.");
                goto lol;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);

                switch (lucky)
                {
                    case 0:
                        Console.WriteLine("For sure!");
                        commandChoose();
                        break;

                    case 1:
                        Console.WriteLine("Hmm, why not?");
                        commandChoose();
                        break;

                    case 2:
                        Console.WriteLine("Ahah, no.");
                        commandChoose();
                        break;

                    case 3:
                        Console.WriteLine("Yep!");
                        commandChoose();
                        break;

                    case 4:
                        Console.WriteLine("I don't have any idea.");
                        commandChoose();
                        break;

                    case 5:
                        Console.WriteLine("nah man fuck off");
                        commandChoose();
                        break;

                    case 6:
                        Console.WriteLine("Almost, but no.");
                        commandChoose();
                        break;

                    case 7:
                        Console.WriteLine("No shit sherlock, yes.");
                        commandChoose();
                        break;

                    case 8:
                        Console.WriteLine("AHAHAHAHHAAAAAAH! ROFL XD");
                        commandChoose();
                        break;

                    case 9:
                        Console.WriteLine("Don't ask me questions again.");
                        commandChoose();
                        break;

                    case 10:
                        Console.WriteLine("Hmm, I'll think about that.");
                        commandChoose();
                        break;
                }
            }
        }
    }
}

