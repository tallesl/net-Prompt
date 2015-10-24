namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Asks a string.
        /// </summary>
        /// <param name="label">What you are asking</param>
        /// <returns>The answer</returns>
        public static string Ask(string label)
        {
            return Read(label, "");
        }

        /// <summary>
        /// Asks a string.
        /// </summary>
        /// <param name="label">What you are asking</param>
        /// <param name="defaultAnswer">Answer suggestion that comes already typed for the user</param>
        /// <returns>The answer</returns>
        public static string Ask(string label, string defaultAnswer)
        {
            return Read(label, defaultAnswer);
        }
    }
}
