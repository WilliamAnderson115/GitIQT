using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class CreateBranch : AbstractScenario
    {
        public override void AskPrompt()
        {
            Answer = $"git branch feature/feature-name";

            PerformGitAction($"What git command do you need to type in to create a new branch named feature/feature-name.");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully created a new branch.");
            Console.WriteLine("Next, let's view the changes made to the code");
            new ViewChanges().AskPrompt();
        }
    }
}
