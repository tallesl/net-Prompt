namespace PromptLibrary
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public static partial class Prompt
    {
        /// <summary>
        /// Asks a string.
        /// </summary>
        /// <param name="label">What you are asking</param>
        /// <param name="defaultAnswer">Answer suggestion that comes already typed for the user</param>
        /// <param name="allowEmpty">Allow empty answer</param>
        /// <returns>The answer</returns>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static string Ask(string label, string defaultAnswer = "", bool allowEmpty = false)
        {
            for (; ; )
            {
                var read = Read(label, defaultAnswer);

                if (read.Length > 0 || allowEmpty)
                    return read;

                Say("Type something!");
                defaultAnswer = read;
            }
        }
    }
}
