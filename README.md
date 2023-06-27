# C# Bootstrap (base / project skeleton)

[![CodelyTV](https://img.shields.io/badge/codely-tv-green.svg?style=flat-square)](https://codely.tv)
[![Workflow Status](https://github.com/CodelyTV/csharp-basic-skeleton/workflows/Main%20Workflow/badge.svg)](https://github.com/CodelyTV/csharp-basic-skeleton/actions)

- [C# Bootstrap (base / project skeleton)](#c-bootstrap-base--project-skeleton)
	- [Introduction](#introduction)
	- [Prerequisite](#prerequisite)
	- [How To Start](#how-to-start)
		- [Use the Template](#use-the-template)
		- [Working with the workspace](#working-with-the-workspace)
	- [About](#about)
	- [💡 Related repositories](#-related-repositories)
	- [License](#license)


## Introduction

This is a repository intended to help you create all the boilerplate to just have a test and library projects in [C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/). It could be useful if you want to start from scratch a kata or a little exercise or project.

This template will create:
- A `*/Tests` [NUnit](https://nunit.org/) test project using [FluentAssertions](https://fluentassertions.com/), [NSubstitute](https://nsubstitute.github.io/), and [Faker.NET](https://github.com/Kuree/Faker.Net).
- A `*/Domain` project to write your "productive" code.
- A working test using a reference to `*/Domain` project.
- A `.gitignore` file to just include relevant files in your repository.

## Prerequisite
- [.NET7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).

## How To Start

### Use the Template
You have two main ways of starting a project from this template:
- `Use this template` button from Github interface.
- Using [dotnet tamplate](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates): `dotnet new codely-basic --name <YourProjectName>`. First, you need to install the template by:
	1. Clone the repository
	2. Run: `dotnet new install ./`

> While first is easier from GitHub interface, second one allow you to have a local way of creating as many projects you want with this structure just by installing the template the first time.

### Working with the workspace 
 
1. Build the project: `dotnet build`
2. Run tests: `dotnet test`. 
3. Start coding!

## About

This hopefully helpful utility has been developed by [CodelyTV][link-author] and [contributors][link-contributors].

We'll try to maintain this project as simple as possible, but Pull Requests are welcomed!

## 💡 Related repositories

* [TypeScript Basic Skeleton](https://github.com/CodelyTV/typescript-basic-skeleton)
* [Java Basic Skeleton](https://github.com/CodelyTV/java-basic-skeleton)
* [PHP Basic Skeleton](https://github.com/CodelyTV/php-basic-skeleton)
* [Scala Basic Skeleton](https://github.com/CodelyTV/scala-basic-skeleton)

## License

The MIT License (MIT). Please see [License File][link-license] for more information.

[link-license]: LICENSE
[link-readme]: README.md
[link-author]: https://github.com/CodelyTV
[link-contributors]: ../../contributors

