using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class ViewChanges : AbstractScenario
    {
        public override void AskPrompt()
        {
            Answer = $"git status";

            PerformGitAction($"What git command do you need to type in to view changes made to the code.");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully viewed the changes in your branch.");
            Console.WriteLine("Next, let's commit those changes to the feature branch");
            new CommitChanges().AskPrompt();
        }
    }
}
