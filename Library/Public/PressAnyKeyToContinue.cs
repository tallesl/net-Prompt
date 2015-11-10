namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Says a "press any key to continue" message and waits for a key to proceed execution.
        /// </summary>
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey();
        }
    }
}
