<!--
author:   3M+L

email:    your@mail.org

version:  0.0.1

language: en

narrator: US English Male


translation: Português  translations/Portuguese.md

translation: Deutsch translations/German.md

import: https://raw.githubusercontent.com/liaTemplates/algebrite/master/README.md

import: https://raw.githubusercontent.com/liaTemplates/rextester/master/README.md
-->

# C# Programs

To GitHub click [here](https://github.com/mmachel/Basics/blob/master/Program.md)

To LiaScript click [here](https://liascript.io/course/?https://raw.githubusercontent.com/mmachel/Basics/master/Program.md#1)

## Hello World

Let us look at the simple HelloWorld program and see how it has been written and compiled and it the libraries.

```csharp   HelloWorld.cs
using System;
namespace Rextester
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hey there, welcome to programming world!");
    }
  }
}

```
@Rextester.eval(@CSharp)
