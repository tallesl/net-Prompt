namespace PromptUtil
{
    using System;

    public static partial class Prompt
    {
        private static bool _clearBetweenSays;

        /// <summary>
        /// Enables clearing the screen between each say.
        /// </summary>
        public static void ClearBetweenSays()
        {
            _clearBetweenSays = true;
        }
    }
}
