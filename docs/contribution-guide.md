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

Shopify often introduces new endpoints, so we often accept pull requests with new services for these endpoints! In general, if you're creating a new service, please try to implement all of the endpoints for the service as described in Shopify's docs. Take a look at the other service classes to get an idea for how they should be implemented.

- Always implement two list filters when the endpoint supports paginated listing: the generic filter, and the dedicated entity filter.

Make sure you follow the sections below pertaining to adding new model classes and testing your changes!

## New models or new properties

- Due to legacy implementation details, we require that all properties on a model be nullable where possible. This is to prevent issues where e.g. failure to set a boolean value on a class instance will default its value to false and can potentially unpublish or disable the entity on Shopify.

## Bug fixes

- Please make sure you explain the bug! Don't just submit a pull request and expect us to figure out what you're trying to fix. In addition, make sure your bug fix doesn't break any related tests (see the section below on testing your changes).

## New features or big changes to shared classes

- Before you contribute a new feature or make big changes to shared classes, please first create a feature request issue so we can discuss the merits and possible drawbacks. We won't reject these outright, but anything that breaks builds and would cause a lot of refactoring for developers will need approval.

## Testing your changes

- If you want to test your changes, you'll need a Shopify access token with permissions granted for the relevant endpoints/resources. 
- If you want to test _everything_ in the package (this shouldn't be necessary unless you're making changes to shared classes like the base `ShopifyService`), you'll need an access token with all permissions possible.
- Remember that these tests will make changes to the store! Do not use an access token from a production or client store. You should only use tokens from development stores where e.g. creating/updating/deleting/enabling/disabling things like products or orders won't hurt anybody's financial income. 
