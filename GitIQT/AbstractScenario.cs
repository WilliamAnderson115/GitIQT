using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal abstract class AbstractScenario
    {
        protected string Response = string.Empty;

        protected string Answer = string.Empty;

        public abstract void AskPrompt();

        public void GetResponses()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Response = Console.ReadLine()?.Trim() ?? "";

            if (CheckReponse())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                NextPrompt();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That's not correct. Try again.");
                GetResponses();
            }
        }
        public bool CheckReponse()
        {
            return Response == Answer;
        }

        public abstract void NextPrompt();

        protected void PerformGitAction(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(prompt);

            GetResponses();
        }
    }
}
