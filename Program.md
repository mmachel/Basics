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

## C# Quiz quetions

**1. Das .NET Framework besteht aus Common Language Runtime (CLR), Klassenbibliotekt und Kompiler.**
[[falsch|(richtig)]]

**2. Welche der folgenden Elemente der Paradigmen wird nicht von C# unterstützt?**

[( )] procedural
[( )]objektorientiert
[(X)] logisch
[( )] funktional

**3. Wie unterscheidet sich C# gegenüber anderen Programmiersprachen? Richtige Antworte ankreuzen.**

[[X]] Viele Sprachen auf einer Plattform (VB, C++,...)
[[ ]] Eine Sprache auf vielen Plattformen
[[X]] Die Anwendungen werden auf .NET Framework ausgeführt.
[[ ]] Wird durch gcc auf Kommandozeilen kommpiliert.
[[?]] Welche Konzepte werden von C# aufgegrifen?

**4. Die Ausgabe wird in C# ausgeführt durch...**

[( )] System.out.print();
[( )] print();
[(X)] System.Console.WriteLine();
[( )] printf();

**5. Bei Console.WriteLine() sind Console und WriteLine ...**

[( )] Namespace und Member
[(X)] Klasse und Methode
[( )] Assembly und Klasse

**6. Wärend der Kompilierung werden C# Programme physisch verpackt in...**

[( )] Namespace
[(X)] Assemblies
[( )] Methode
[( )] Klasse

7. Die alternative für .NET Framework

[[X]] Mono
[[X]] DotGNU
[[X]]Portable.NET
[[ ]] Java
