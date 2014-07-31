using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static Boolean quit = false;
        static string PlayerName = "Player";
        static bool msgFlag = true;
        static string consoleMsg = "Welcome! System is ready for user input.";

        static void Main(string[] args)
        {
            Program p = new Program();
            string[] CommandDictionary = new[] {"test", "get", "give", "setname", "quit"};
            string command;
            string reply;

            //get player name
            p.Action("setname");

            Console.Clear();

            while (!quit)
            {
                //Print Console Message if any
                if (msgFlag)
                {
                    Console.Write(consoleMsg);
                    consoleMsg = "";
                    msgFlag = false;
                }

                //Idle; Prompt for next input
                Console.WriteLine();
                Console.Write(PlayerName + "//>");
                command = Console.ReadLine();
                reply = p.Action(command);
                Console.WriteLine();
                Console.WriteLine(reply);

                System.Threading.Thread.Sleep(1);
            }
        }

        void GlobalMessage(string msg)
        {
            consoleMsg += System.Environment.NewLine + msg;
            msgFlag = true;
        }

        string Action(string command)
        {
            string[] input = command.Split(Convert.ToChar(" "));
            command = input[0];
            string error = "";

            //Console.WriteLine("Command Length = " + parts.Length);

            switch(command)
            {
                case("test"):
                    error = "stop it.";
                    break;
                case("setname"):
                    if (SetName(input))
                        error = "Player name successfully set!";
                    else
                        error = "ERROR: Player name could not be set, please check syntax.";
                    break;
                case ("get"):
                    if (Get(input))
                        error = "Item given to player";
                    else
                        error = "ERROR: Command could not be completed, please check syntax.";
                    break;
                case(""):
                    break;
                case("quit"):
                    quit = true;
                    break;
                default:
                    error = "Invalid Command";
                    break;
            }

            return error;
        }

        /// <summary> 
        /// Sets the current name of the player.
        /// </summary>
        bool SetName(params string[] input)
        {
            //Beginning of method labeled so it may be looped.
            Start:

            string prompt = "";
            bool result = false;

            if (input.Length > 1)
            {
                PlayerName = input[1];
                result = true;
            }
            else
            {
                Console.Write(System.Environment.NewLine);
                Console.WriteLine("Please enter your name or type 'list' to see a list of names in use.");
                Console.Write("Name:");
                prompt = Console.ReadLine();
                if (prompt == "list")
                {
                    //TODO: print list of names in use

                    //Go back to the beginning of the method.
                    goto Start;
                }
                else
                {
                    PlayerName = prompt;
                }
                result = true;
            }
            return result;
        }

        /// <summary> 
        /// Adds Item(s) to inventory of current player
        /// </summary>
        bool Get(params string[] input)
        {
            bool result = false;

            //TODO: Add ITEM (in QUANTITY) to OWNER in data file (at LOCATION)

            return result;
        }

    }
}
