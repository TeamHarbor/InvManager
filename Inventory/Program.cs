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

        static void Main(string[] args)
        {
            Program p = new Program();
            string command;
            string reply;

            //get player name
            p.Action("setname");

            while (!quit)
            {
                Console.WriteLine();
                Console.Write(PlayerName + "//>");
                command = Console.ReadLine();
                reply = p.Action(command);
                Console.WriteLine(reply);

                System.Threading.Thread.Sleep(1);
            }
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
                        error = "ERROR: Player name could not be set.";
                    break;
                case ("get"):
                    if (Get(input))
                        error = "Item given to player";
                    else
                        error = "ERROR: Command could not be completed, check syntax.";
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
        /// Sets the current name of the player./test
        /// </summary>
        bool SetName(params string[] input)
        {
            string prompt = "";
            bool result = false;

            if (input.Length > 1)
            {
                PlayerName = input[1];
                result = true;
            }
            else
            {
                Console.WriteLine("Please enter your name or type 'list' to see a list of names in use.");
                Console.Write("Name:");
                prompt = Console.ReadLine();
                if (prompt == "list")
                {
                    //TODO: print list of names
                    Action("setname");
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
