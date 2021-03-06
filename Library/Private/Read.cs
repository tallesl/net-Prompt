﻿namespace PromptLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public static partial class Prompt
    {
        [SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "That's from the user, you dummy.")]
        private static string Read(string label, string defaultAnswer)
        {
            label += ": ";
            Console.Write(label);
            var initialPosition = Console.CursorLeft - label.Length;

            var read = new Stack<char>(defaultAnswer);
            var notEnter = true;

            Console.Write(defaultAnswer);

            while (notEnter)
            {
                var info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.Backspace:
                        if (read.Any())
                        {
                            read.Pop();
                            Backspace();
                        }
                        break;

                    case ConsoleKey.Enter:
                        Enter();
                        notEnter = false;
                        break;

                    default:
                        read.Push(info.KeyChar);
                        Console.Write(info.KeyChar);
                        break;
                }
            }

            if (_clearBetweenSays)
                Clear();

            return new string(read.Reverse().ToArray()).Trim();
        }

        private static void Backspace()
        {
            Console.CursorLeft -= 1;
            Console.Write(' ');
            Console.CursorLeft -= 1;
        }

        private static void Enter()
        {
            Console.Write(Environment.NewLine);
        }
    }
}
