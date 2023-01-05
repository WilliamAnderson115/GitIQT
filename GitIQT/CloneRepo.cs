using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIQT
{
    internal class CloneRepo : AbstractScenario
    {
        // Ask user to clone a repository
        public override void AskPrompt()
        {
            // Ask user to clone a repository
            // Get the first 5 characters of a GUID
            var repoID = Guid.NewGuid().ToString().Substring(0, 5);

            // Ask user to checkout the dev branch of the repository
            var repoURL = $"https://github.com/552ODST/{repoID}/ProjectBacon.git";
            Answer = $"git clone {repoURL}";

            PerformGitAction($"What git command do you need to type in to clone the repository located at '{repoURL}'? You can copy and paste!");
        }

        public override void NextPrompt()
        {
            Console.WriteLine("That's correct! You've successfully cloned the repository.");
            Console.WriteLine("Next, check what branch you are on.");
            new BranchCheck().AskPrompt();
        }
    }
}
