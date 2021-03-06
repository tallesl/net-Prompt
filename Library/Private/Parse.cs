﻿namespace PromptLibrary
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public static partial class Prompt
    {
        private static T ReadAndParse<T>(string label, string defaultAnswer)
        {
            for (; ; )
            {
                T parsed;
                var read = Ask(label, defaultAnswer, false);

                if (TryParse<T>(read, out parsed))
                    return parsed;

                if (read.Any())
                    Say("\"{0}\" is invalid!", read);
                else
                    Say("Type something!");

                defaultAnswer = read;
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "That's OK.")]
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
