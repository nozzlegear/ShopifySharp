# ShopifySharp: A .NET library for Shopify.

[![NuGet](https://img.shields.io/nuget/v/ShopifySharp.svg?maxAge=3600)](https://www.nuget.org/packages/ShopifySharp/)
[![Build status](https://github.com/nozzlegear/ShopifySharp/actions/workflows/build-and-test.yml/badge.svg?branch=master)](https://github.com/nozzlegear/ShopifySharp/actions/workflows/build-and-test.yml)
[![license](https://img.shields.io/github/license/nozzlegear/shopifysharp.svg?maxAge=3600)](https://github.com/nozzlegear/shopifysharp/blob/master/LICENSE)

ShopifySharp is a .NET library that enables you to authenticate and make API calls to Shopify. It's great for building custom Shopify Apps using C# and .NET. You can quickly and easily get up and running with Shopify using this library.

# The Shopify Development Handbook

[![Learn how to build rock-solid Shopify apps with C# and ASP.NET](https://i.imgur.com/9GgDjK0.png)](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp)

Building an app or integration for the Shopify store is hard work. There are a ton of things you need to keep in mind when stitching together all of the API calls, redirect URLs and app settings that you'll need to use.

You're going to be asking yourself all of these questions when you try to build an app for the Shopify store:

-   How can I charge my users when they use my app?
-   What in the world is an embedded app?
-   How should I be using Shopify's redirect URLs?
-   When should I be using a proxy page?
-   Am I dealing with webhooks the right way?
-   How can I let my user's actual customers interact with the app?
-   Can I add custom scripts to their website, and what can those scripts even do?
-   How the heck do I go about testing my app?

It's difficult to find blog posts or tutorials about building Shopify apps, and downright impossible if you're trying to build them with C# and ASP.NET. Shopify's own partner blog puts a huge focus on designing themes over building real, functional apps, and their API docs only go so far if you don't know what you're looking for.

[The Shopify Development Handbook](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp) is a premium educational course that distills the experience of building Shopify applications and integrations into one concise and comprehensive course.

[Click here to learn more about The Shopify Development Handbook, **and get a FREE sample chapter** on integrating a merchant's Shopify store with your app.](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp)

# Installation

ShopifySharp is [available on NuGet](https://www.nuget.org/packages/ShopifySharp/). You can install it with the dotnet command line:

| Package                                                                                                                   | Installation                                                     | Documentation                                                                               |
|---------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| [ShopifySharp](https://www.nuget.org/packages/ShopifySharp)                                                               | `dotnet add package shopifysharp`                                | [Click here.](https://github.com/nozzlegear/ShopifySharp/wiki)                              |
| [ShopifySharp.Extensions.DependencyInjection](https://www.nuget.org/packages/ShopifySharp.Extensions.DependencyInjection) | `dotnet add package shopifysharp.extensions.dependencyinjection` | [Click here.](./ShopifySharp.Extensions.DependencyInjection/README.md)                      |

# Shopify API version support

Shopify has begun versioning their API, meaning new features are locked behind newer versions of the API, and older versions of the API lose support and are eventually shut off. Due to the differences in ShopifySharp's SemVer versioning, and Shopify's date-based versioning, the following table should be consulted to determine which version of ShopifySharp supports which version of Shopify's API:

| ShopifySharp version | Shopify API version |
|----------------------|---------------------|
| 4.x and below        | None, unsupported   |
| 5.0.0 - 5.5.0        | 2019-10             |
| 5.6.0 - 5.7.0        | 2020-07             |
| 5.8.0 - 5.10.0       | 2020-10             |
| 5.11.0 - 5.13.1      | 2021-07             |
| 5.14.0 - 5.15.0      | 2021-10             |
| 5.16.0 - 5.18.11     | 2022-04             |
| 5.19.0 - 5.19.1      | 2022-07             |
| 6.0.1 - 6.2.0        | 2023-01             |
| 6.3.0 - 6.12.2       | 2023-07             |
| 6.13.0 - 6.14.1      | 2024-01             |
| 6.15.0 and above.    | 2024-04.            |

**Note:** ShopifySharp dropped support for .NET Framework 4.5 in version 5.14.0. [More details in #438.](https://github.com/nozzlegear/ShopifySharp/issues/438)
The oldest version of .NET Framework we can support is [whichever version is supported by .NET Standard 2.0](https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0#net-standard-versions).


Check the [package's documentation](./ShopifySharp.Extensions.DependencyInjection/README.md) for more information.

# A work-in-progress

I first started working on ShopifySharp because .NET developers need a fully-featured library for interacting with Shopify and building Shopify apps, which didn't exist several years ago. My goal is to eventually reach 100% compatibility with the Shopify REST API, but, with that said, Shopify is constantly adding new APIs and altering old ones. I try my best to keep up with them, but I tend to prioritize the support of new APIs by how much I need them in my own Shopify apps.

# Documentation

Click the link here to be brought to all of the documentation: [ShopifySharp Wiki](https://github.com/nozzlegear/ShopifySharp/wiki)

# Contributing to ShopifySharp

Check out our [contribution guide](https://github.com/nozzlegear/ShopifySharp/blob/master/docs/contribution-guide.md) for guidance on contributing new features, services, classes and bugfixes to ShopifySharp! The guide also contains details on how to set up and run ShopifySharp's test suite.
