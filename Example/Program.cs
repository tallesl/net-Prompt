namespace PromptUtil.Example
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var text = Prompt.Ask("Give me some string");
            Prompt.Say("So your string is \"" + text + "\" eh?");

            var boolean = Prompt.AskYesOrNo("Are you a Yes or a No person?");
            Prompt.Say("So you're a " + (boolean ? "Yes" : "No") + " person eh?");

            var integer = Prompt.Ask<int>("Give me an integer");
            Prompt.Say("So your integer is " + integer + " eh?");

            var uuid = Prompt.Ask<Guid>("Give me a UUID", Guid.NewGuid());
            Prompt.Say("So your UUID is " + uuid + " eh?");
        }
    }
}
