﻿# C# Crash Course

This crash course provides a concise introduction to the most important aspects of the beautiful C# language for beginners. In this course, you will implement a small prototypical __banking application__ that allows a user to perform typical tasks like viewing their account balance. The course is divided into several milestones with different objectives, some more software engineering and information systems oriented and some, of course, C# programming oriented.

⚠ __Attention__ ⚠: This course might not be suited for beginners in programming without an instructor! Note that many parts of this course only show significantly simplified versions of software engineering activities!

![User Needs](./pictures/neural_networks_baby.webp)

Learning a new programming language is hard and things like this (s. [xkcd 1513](https://xkcd.com/1513/)) might happen if a pro looks at your first code:

![xkcd 1513](https://imgs.xkcd.com/comics/code_quality.png)

But keep in mind: Even a small step is a step forwards. Hence, have fun experimenting and trying out things even if they fail. 😎

Note that this is a __crash course__ 🚀:

- There is a steep learning curve.
- Only the essentials of C# programming are covered.
- You are expected to conduct your own research to solve problems as they arise.
- You are expected to conduct your own research to learn more details about the covered topics if necessary.

For researching and solving problems, [Stack Overflow](https://stackoverflow.com/), [Microsoft's C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/), and the surprisingly good [Wikipedia C# pages](https://en.wikipedia.org/wiki/C_Sharp_syntax), are recommended. You can of course ask [ChatGPT](https://chat.openai.com/), too. 😉 For quick reference in the programming parts, we advise you to keep a [C# cheat sheet](https://download.microsoft.com/download/4/6/9/469501F4-5F6B-4E51-897C-9A216CFB30A3/SwiftCSharpPoster.pdf) of your choice at hand.

## Setup

To tackle this crash course, you have to be able to write and run C# on your machine. For beginners, we recommend installing and using the [Visual Studio](https://visualstudio.microsoft.com/de/) IDE (select the .NET desktop application option in the installer).

Another option would be to leverage online code editors that feature a C# runtime like [replit](https://replit.com/). However, they tend to be rather slow.

More advanced users, can also use the [Visual Studio Code editor](https://visualstudio.microsoft.com/de/) and [Docker](https://www.docker.com/) for running the C# code in a container, for example. This way, no other binaries have to be installed. To start the container, simply run ``docker compose run csharp`` in the terminal of VSCode.

Regardless of the option you chose, your setup works if you are able execute the provided __Hello World__ program. To do this, open the [c-sharp-course folder](./) in the IDE/editor of your choice, then open the [Program.cs file](./HelloWorld/Program.cs) within the [HelloWorld folder](./HelloWorld) and run it. You should see an output like:

```
Welcome to the C# crash course! 🚀
```

## Milestones

For each milestone, possible solutions is provided. Depending on the scope of the application (that you set yourself) the provided solution and your solution might differ. Without an instructor, we strongly recommend to use the provided solutions of each milestone as the starting point for the next one because the instructions in the latter ones assume the previous solutions as starting points. The instructions, solutions and other material for each milestone are available in the individual milestone folders.

You are now ready to start the crash course! 🥳 Open the [c-sharp-course](./) folder in the IDE/editor of your choice, read the [instructions.md file](./Milestone01/instructions.md) within the [Milestone01 folder](./Milestone01).

## Technical Details

This course was conceptualized and implemented using C# 11. Therefore, your solutions may differ depending on the version used.

## License

See [LICENSE](./LICENSE).


