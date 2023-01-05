using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class PushBranch : AbstractScenario
    {
        public override void AskPrompt()
        {
            Answer = $"git push";

            PerformGitAction($"What git command do you need to type in to push this branch to the remote repository");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully pushed the changes to the remote repository.");
            Console.WriteLine("Congratulations you finished!");
        }
    }
}
