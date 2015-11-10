# Prompt

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on command prompting.

## Usage

```cs
using PromptLibrary;

Prompt.Title("Silly example");

var text = Prompt.Ask("Give me some string");
Prompt.Say("So your string is \"{0}\" eh?", text);

var boolean = Prompt.AskYesOrNo("Are you a Yes or a No person?");
Prompt.Say("So you're a \"{0}\" person eh?", boolean ? "Yes" : "No");

var integer = Prompt.Ask<int>("Give me an integer");
Prompt.Say("So your integer is \"{0}\" eh?", integer);

var uuid = Prompt.Ask<Guid>("Give me a UUID", Guid.NewGuid());
Prompt.Say("So your UUID is \"{0}\" eh?", uuid);

Prompt.Say("Okay, thanks, bye!");
```

![](console.png)

[build]:     https://ci.appveyor.com/project/TallesL/Prompt
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/Prompt
[nuget]:     http://badge.fury.io/nu/Prompt
[nuget-img]: https://badge.fury.io/nu/Prompt.png