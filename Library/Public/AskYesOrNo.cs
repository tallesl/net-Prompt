namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Asks an y/n question.
        /// </summary>
        /// <param name="label">What you are asking</param>
        /// <returns>The answer</returns>
        public static bool AskYesOrNo(string label)
        {
            var read = Ask(label + " (y/n)").Trim().ToLower();
            return read == "y" || read == "yes";
        }
    }
}
