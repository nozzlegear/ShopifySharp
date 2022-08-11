# Contribution guide

If you're interested in contributing bug fixes, new services or new features to ShopifySharp, please follow this guide when you contribute a pull request. 

## Backwards compatibility with major versions

- Do not introduce breaking changes without a very good reason! Developers get upset when their builds suddenly break after updating packages. For this reason, we prefer to only merge in breaking changes if truly necessary. This means we're very wary changes along the following lines:

1. Removing properties from objects. If you want to remove a property, we recommend adding an `[Obsolete]` attribute first explaining why it will be removed. After a sufficient amount of time (e.g. between two Shopify API versions) the property will then be removed. 
2. Changing the parameters of methods by adding or removing parameters. We recommend marking a method as `[Obsolete]` first and then introducing an overload for the method with the desired parameters. 
3. Changing the return type of methods. Again we recommend marking the method as `[Obsolete]` to be removed in a future release, and then introducing an overload for the method. 
4. Removing services or models. We only want to remove services or models if their endpoints are no longer supported by Shopify itself. In such cases, there should be plenty of warning ahead of time so that we can add an `[Obsolete]` attribute to the class to be removed in a future release.

## New services

- If you're creating a new service, please try to implement all of the endpoints for the service as described in Shopify's docs. 
- Make sure you follow the sections below pertaining to adding new model classes and testing your changes!

## New models or new properties

- Due to legacy implementation details, we require that all properties on a model be nullable where possible. This is to prevent issues where e.g. failure to set a boolean value on a class instance will default its value to false and can potentially unpublish or disable the entity on Shopify.

## Bug fixes

- Please make sure you explain the bug! Don't just submit a pull request and expect us to figure out what you're trying to fix. In addition, make sure your bug fix doesn't break any related tests (see the section below on testing your changes).

## New features

- Before you contribute a new feature, please first create a feature request issue so we can discuss the merits and possible drawbacks

## Testing your changes

- If you want to test your changes, you'll need a Shopify access token with permissions granted for the relevant endpoints/resources. 
- Remember that these tests will make changes to the store! Do not use an access token from a production or client store. You should only use tokens from development stores where e.g. creating/updating/deleting/enabling/disabling things like products or orders won't hurt anybody's financial income. 