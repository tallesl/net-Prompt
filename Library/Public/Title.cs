namespace PromptLibrary
{
    using System;

    public static partial class Prompt
    {
        /// <summary>
        /// Sets the window title.
        /// </summary>
        /// <param name="text">Text to set on title</param>
        public static void Title(string text)
        {
            Console.Title = text;
        }
    }
}
