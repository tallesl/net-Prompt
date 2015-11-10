namespace PromptUtil
{
    using System;

    /// <summary>
    /// Little helper on command prompting.
    /// </summary>
    public static partial class Prompt
    {
        /// <summary>
        /// Formats the given string and then outputs it to console.
        /// </summary>
        /// <param name="something">Something to say</param>
        /// <param name="format">Optional formatting passed to string.Format</param>
        public static void Say(string something, params object[] format)
        {
            var formatted = string.Format(something, format);
            Console.WriteLine(formatted);
            Console.WriteLine();

            if (_clearBetweenSays)
            {
                PressAnyKeyToContinue();
                Clear();
            }
        }
    }
}
