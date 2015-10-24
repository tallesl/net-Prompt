namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Asks the given type.
        /// </summary>
        /// <typeparam name="T">Type to parse</typeparam>
        /// <param name="label">What you are asking</param>
        /// <returns>The answer</returns>
        public static T Ask<T>(string label)
        {
            return ReadAndParse<T>(label, "");
        }

        /// <summary>
        /// Asks the given type.
        /// </summary>
        /// <typeparam name="T">Type to parse</typeparam>
        /// <param name="label">What you are asking</param>
        /// <param name="defaultAnswer">Answer suggestion that comes already typed for the user</param>
        /// <returns>The answer</returns>
        public static T Ask<T>(string label, T defaultAnswer)
        {
            return ReadAndParse<T>(label, defaultAnswer.ToString());
        }
    }
}
