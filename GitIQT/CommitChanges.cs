using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class CommitChanges : AbstractScenario
    {
        public override void AskPrompt()
        {
            Answer = $"git commit -a";

            PerformGitAction($"What git command do you need to type in to commit changes to feature/feature-name.");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully commit changes to your branch.");
            Console.WriteLine("Next, let's push the branch to the remote repository");
            new PushBranch().AskPrompt();
        }
    }
}
