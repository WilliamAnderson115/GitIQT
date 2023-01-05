using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class CheckoutDev : AbstractScenario
    {
        
        public override void AskPrompt()
        {
            Answer = $"git checkout dev";

            PerformGitAction($"What git command do you need to type in to checkout the dev branch.");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully checked out the dev branch.");
            Console.WriteLine("Next, let's create a new branch.");
            new CreateBranch().AskPrompt();
        }
    }
}