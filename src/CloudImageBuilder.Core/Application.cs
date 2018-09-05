// // Copyright 2018 Change Healthcare. All rights reserved.
// // See LICENSE in the project root for license information.

using System;
using Microsoft.Extensions.CommandLineUtils;

namespace CloudImageBuilder.Core
{
    /// <summary>
    ///     Represents the root application
    /// </summary>
    public class Application : CommandLineApplication
    {
        /// <inheritdoc />
        public Application(bool throwOnUnexpectedArg = true) : base(throwOnUnexpectedArg)
        {
            Description = "CloudImageBuilder deploys unicorns and tops it off with snowflakes.";
            Name = "CloudImageBuilder";
            FullName = "CloudImageBuilder";
            ExtendedHelpText = Environment.NewLine + $"Run '{Name} help [command]' for more information on a command." +
                               Environment.NewLine;

            // Add Commands
            Commands.Add(new HelpCommandLineApplication
            {
                Parent = this
            });
            Commands.Add(new SampleCommandLineApplication
            {
                Parent = this
            });

            CommandOption versionOption = VersionOption("--version", ShortFormVersionGetter);
            OnExecute(() =>
            {
                if (versionOption.HasValue())
                    ShowVersion();
                else
                    ShowHelp();
                return 1;
            });
        }

        private string ShortFormVersionGetter()
        {
            return "1.0.0.0";
        }
    }
}
