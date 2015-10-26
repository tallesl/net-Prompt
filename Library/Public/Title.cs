namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Sets the console title.
        /// </summary>
        /// <param name="title">Title to set</param>
        public static void Title(string title)
        {
            Console.Title = title;
        }
    }
}
