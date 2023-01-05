using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class BranchCheck : AbstractScenario
    {
        public override void AskPrompt()
        {
            Answer = $"git branch";

            PerformGitAction($"What git command do you need to type in to check the current branch.");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully checked the current branch.");
            Console.WriteLine("Next, let's swap to the dev branch.");
            new CheckoutDev().AskPrompt();
        }
    }
}
