namespace PromptLibrary
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public static partial class Prompt
    {
        /// <summary>
        /// Says a "press any key to continue" message and waits for a key to proceed execution.
        /// </summary>
        [SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "There's no localization, English only.")]
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey();
        }
    }
}
