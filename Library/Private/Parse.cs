namespace PromptUtil
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public static partial class Prompt
    {
        private static T ReadAndParse<T>(string label, string defaultAnswer)
        {
            for (; ; )
            {
                T parsed;
                var read = Ask(label, defaultAnswer);

                if (TryParse<T>(read, out parsed))
                    return parsed;

                Console.WriteLine((read.Any() ? "\"" + read + "\" is invalid!" : "Type something!"));
                defaultAnswer = read;
            }
        }

        private static bool TryParse<T>(string value, out T parsed)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            try
            {
                parsed = (T)converter.ConvertFromString(value);
                return true;
            }
            catch
            {
                parsed = default(T);
                return false;
            }
        }
    }
}
