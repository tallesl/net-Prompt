# Prompt

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on command prompting.

[build]:     https://ci.appveyor.com/project/TallesL/Prompt
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/Prompt

[nuget]:     http://badge.fury.io/nu/Prompt
[nuget-img]: https://badge.fury.io/nu/Prompt.png

## Usage

```cs
using PromptUtil;

var text = Prompt.Ask("Give me some string");
Prompt.Say("So your string is \"" + text + "\" eh?");

var boolean = Prompt.AskYesOrNo("Are you a Yes or a No person?");
Prompt.Say("So your are a " + (boolean ? "Yes" : "No") + " person eh?");

var integer = Prompt.Ask<int>("Give me an integer");
Prompt.Say("So your integer is " + integer + " eh?");

var uuid = Prompt.Ask<Guid>("Give me a UUID", Guid.NewGuid());
Prompt.Say("So your UUID is " + uuid + " eh?");
```
