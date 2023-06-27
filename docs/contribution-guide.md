# Contribution guide

If you're interested in contributing bug fixes, new services or new features to ShopifySharp, please follow this guide when you contribute a pull request. 

## Backwards compatibility with major versions

The ShopifySharp package is relatively stable, so I prefer not to introduce breaking changes without a very good reason. Developers get upset when their builds suddenly break after updating packages. For this reason, anything that causes a breaking change will only be merged if truly necessary.

In general, we're wary of making changes that do one of these things:

1. Removing properties from objects. If you want to remove a property, we recommend adding an `[Obsolete]` attribute first explaining why it will be removed. After a sufficient amount of time (e.g. between two Shopify API versions) the property will then be removed. 
2. Changing the parameters of methods by adding or removing parameters. We recommend marking a method as `[Obsolete]` first and then introducing an overload for the method with the desired parameters. 
3. Changing the return type of methods. Again we recommend marking the method as `[Obsolete]` to be removed in a future release, and then introducing an overload for the method. 
4. Removing services or models. We only want to remove services or models if their endpoints are no longer supported by Shopify itself. In such cases, there should be plenty of warning ahead of time so that we can add an `[Obsolete]` attribute to the class to be removed in a future release.

That said, if you feel the change should be made anyway, please open an issue so we can discuss it! Sometimes changes must be made, e.g. when Shopify has changed their API or the type of a property is wrong and causing issues.

## New services

"Services" in ShopifySharp are classes that contain methods for interacting with a single Shopify API endpoint or object type. For example, the `CustomerService` contains all of the methods for creating, updating, listing and deleting customers with the Shopify API. 

Shopify introduces new endpoints often, so we often accept pull requests with new services for these endpoints! In general, if you're creating a new service, please try to implement all of the endpoints for the service as described in Shopify's docs. Take a look at the other service classes to get an idea for how they should be implemented.

Every service in ShopifySharp should have an accompanying interface that describes all of the public methods for the interface. The interface should be placed in a separate file alongside your service file, and the documentation for each method should be added to the interface method – not the class. See the [CustomerService.cs](https://github.com/nozzlegear/ShopifySharp/blob/5750feb4116c6047d28720f9ef8c650b30e6a534/ShopifySharp/Services/Customer/CustomerService.cs) and [ICustomerService.cs](https://github.com/nozzlegear/ShopifySharp/blob/5750feb4116c6047d28720f9ef8c650b30e6a534/ShopifySharp/Services/Customer/ICustomerService.cs) files for an example.

> Note that new services must have tests! Even if they're unable to run due to permission issues or requiring a Shopify Plus account, we'd still like the tests to be implemented to confirm that everything works and builds as expected. See the section below on writing tests.

**If your new service uses Shopify's paginated list endpoint, always implement two methods for listing:** the first method should use the generic `ListFilter<EntityType>`, and the second method should use a more dedicated `EntityTypeListFilter`. 

[Again, the CustomerService.cs file has a good example of this pattern:](https://github.com/nozzlegear/ShopifySharp/blob/5750feb4116c6047d28720f9ef8c650b30e6a534/ShopifySharp/Services/Customer/CustomerService.cs#L29)

```cs
using ShopifySharp.Filters;

public class CustomerService : ShopifyService, ICustomerService
{
    // ...

    public virtual async Task<ListResult<Customer>> ListAsync(ListFilter<Customer> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("customers.json", "customers", filter, cancellationToken);

    public virtual async Task<ListResult<Customer>> ListAsync(CustomerListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);
}
```

Make sure you follow the sections below pertaining to adding new model classes and testing your changes!

## New models or new properties

Due to legacy implementation details, we require that all properties on a model be nullable wherever possible. Doing this will prevent unintended serializiation of default values in C#. 

This is most often a problem when attempting to update an object. For example, any non-nullable bool value will default to false when serialized to JSON. If that non-nullable bool was a property named `Published` for instance, you'd accidentally unpublish the object if you forgot to manually set the bool value.

## Bug fixes

If you've run into a bug and want to fix it, please make sure you explain the bug in your pull request! In addition, make sure your bug fix doesn't break any related tests. If you can add your own tests that show the bug is fixed, that'd be even better (but not required or even possible in some cases).

## New features or big changes to shared classes

Before you contribute a big new feature or make huge changes to classes that are shared across many services/entities, please first create a feature request issue so we can discuss the merits and drawbacks. 

We don't reject these outright -- improvements are always welcome -- but anything that breaks builds and would cause a lot of refactoring for developers will need approval before merging.

## Writing tests

ShopifySharp is uses [xUnit](https://xunit.github.io/) for tests. New tests should all follow the format of other, existing tests. You can use the [Article](https://github.com/nozzlegear/ShopifySharp/blob/master/ShopifySharp.Tests/Article_Tests.cs) test as an example. 

If you're using VS Code, I would highly recommend that you [use the provided ShopifySharp Test snippet in the VSCode folder](https://github.com/nozzlegear/ShopifySharp/blob/master/.vscode/snippets.csharp.json). This snippet will set up a new test file for you when you type `test-shopifysharp`:

![shopifysharp-test](https://cloud.githubusercontent.com/assets/2417276/25457929/94bc71dc-2a9d-11e7-80ac-72352715504e.gif)

## Testing your changes

If you want to test your changes, you'll need to get a Shopify access token with permissions granted for all the relevant endpoints/resources. You can do that by either creating a public Shopify app and grabbing the token from the oauth process, or by [creating a custom app](https://help.shopify.com/en/manual/apps/custom-apps) on a dev store.

If you're creating a custom app, use the custom app's "password" wherever ShopifySharp asks for an access token. These are functionally identical. 

Before you can run the test suite, you'll need to set up the following environment variables by creating a file named _env.yml_ in the _ShopifySharp.Tests_ project folder. Add the following values to the env file:

```env
SHOPIFYSHARP_MY_SHOPIFY_URL = example.myshopify.com

SHOPIFYSHARP_API_KEY = value

SHOPIFYSHARP_SECRET_KEY = value

# If using a custom app, the custom app's "password" goes here
SHOPIFYSHARP_ACCESS_TOKEN = value

# Optional, only necessary if you're testing the multipass service
SHOPIFYSHARP_MULTIPASS_SECRET = value
```

> Remember that these tests will make changes to the store! **Do not use an access token from a production or client store**. You should only use tokens from development stores where e.g. creating/updating/deleting/enabling/disabling things like products or orders won't hurt anybody's financial income. 

Once you've got the env file configured, you'll be ready to run the tests. Most IDEs have their own dedicated test running interface that I won't explain here, so instead the following examples will all use the dotnet CLI. 

### Running all tests

If you've got a ton of time on your hands, you could run all tests at once with the following command:

```sh
dotnet test --framework net6.0 ShopifySharp.Tests
```

That command will run all of the tests in the solution using the `net6.0` (.NET 6) framework. It can take upwards of 15 minutes to run the entire suite, and it's likely that things will break due to rate limits. ShopifySharp's automated tests actually run each test category one at a time, rather than the entire suite all at once. 

### Running tests for specific categories/services

Every test file in the _ShopifySharp.Tests_ folder has its own category. For example, tests for the order service use the `Order` category. We use xUnit as our test runner, which means you can run all the tests in just one category using this command:

```sh
dotnet test --framework net6.0 --filter "Category=Order"
```

It's generally recommended that you run one single test category for whatever you're testing, rather than running the entire ShopifySharp suite of tests all at once.

### Tests that randomly break and fix themselves

Note that some ShopifySharp tests are *extremely fickle* and may break on one run but pass on another. This is simply the nature of running integration tests against a real live API.

The tests most susceptible to randomly breaking are the customer, fulfillment and order tests. If a test fails multiple times in a row, that's a sign that the test itself may be broken rather than an issue with the store or API.
