# ShopifySharp: A .NET library for Shopify.

ShopifySharp is a .NET library that enables you to authenticate and make API calls to Shopify. It's great for building custom Shopify Apps using C# and .NET. You can quickly and easily get up and running with Shopify using this library.

### How to contact me

**If you're looking for a Shopify consultant** to build your next app or integrate your shop with your own custom software, **I'm available for hire**. Send an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com) and we'll discuss your project. If you just want to get in touch with me, the best way to do that is by sending an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com), or by following me on Twitter at [@nozzlegear](https://twitter.com/nozzlegear).

### A work-in-progress

Currently, the only other .NET library for Shopify is [Shopify.net](https://github.com/cmcdonaldca/shopify.net), which hasn't been updated in over 3 years and requires that you know the exact URL paths of the Shopify API, along with creating your own entity classes for each resource. That's why I'm building ShopifySharp — .NET developers need a fully-featured library for interacting with Shopify and building Shopify apps.

With that said, this library is brand new. It currently only supports **OAuth authentication**, the **Customers** resource and the **Shop** resource. More functionality will be added each week until it reachs full parity with Shopify's REST API.

![imgur](http://i.imgur.com/WJKJI9D.png)

Finally, we'll get a NuGet package set up for this library soon.

# Usage

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**. An access token is the token returned after authenticating and authorizing a Shopify app installation with a real Shopify store. 

If you just need an access token for a private Shopify app, or for running the tests in this library, refer to the **Tests** section below.

## Authentication

### Build an authorization URL

Redirect your users to this authorization URL, where they'll be prompted to install your app to their Shopify store.

```
//This is the user's store URL.
string usersMyShopifyUrl = "https://example.myshopify.com";

//An array of the Shopify access scopes your application needs to run.
IEnumerable<ShopifyAuthorizationScope> scopes = new List<ShopifyAuthorizationScope>()
{
    ShopifyAuthorizationScope.ReadCustomers,
    ShopifyAuthorizationScope.WriteCustomers
};

//All ShopifyAuthorizationService methods are static.
string authUrl = ShopifyAuthorizationService.BuildAuthorizationUrl(scopes, usersMyShopifyUrl, shopifyApiKey);
```

## Shops

### Retrieving shop information

```
ShopifyShopService service = new ShopifyShopService(myShopifyUrl, shopAccessToken);

ShopifyShop shop = await service.GetAsync();
```

## Customers

### Creating a customer

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
ShopifyCustomer customer = new ShopifyCustomer()
{
    FirstName = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    Addresses = new List<ShopifyAddress>()
    {
        new ShopifyAddress()
        {
            Address1 = "123 4th Street",
            City = "Minneapolis",
            Province = "Minnesota",
            ProvinceCode = "MN",
            Zip = "55401",
            Phone = "555-555-5555",
            FirstName = "John",
            LastName = "Doe",
            Company = "Tomorrow Corporation",
            Country = "United States",
            CountryCode = "US",
            Default = true,
        }
    },
    VerifiedEmail = true,
    Note = "Test note about the customer.",
    State = "enabled"
}

customer = await service.CreateAsync(customer);
```

### Retrieving a customer

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
ShopifyCustomer customer = await service.GetAsync(customerId);
```

### Retrieving a customer with certain fields

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
ShopifyCustomer customer = await service.GetAsync(customerId, "first_name,last_name,email"); 

//Returns a customer with only FirstName, LastName and Email fields. All other fields are null.
```

### Updating a customer

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
ShopifyCustomer customer = await service.GetAsync(customerId);

customer.Email = "test-update@example.com";
customer = await service.UpdateAsync(customer);
```

### Deleting a customer

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(customerId);
```

### Counting customers

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
int customerCount = await service.CountAsync();
```

### Listing customers
```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.ListAsync();
```

### Searching customers

```
ShopifyCustomerService service = new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.SearchAsync("Jane country:United States");

//Searches for a customer from the United States with a name like 'Jane'. 
//There is a noticeable 3-30 second delay between creating a customer and Shopify 
//indexing it for a search.
```

# Tests

The test suite relies on your own Shopify credentials, including your Shopify API key, a shop's *.myshopify.com URL, and an access token with full permissions for that shop. [This blog post](https://nozzlegear.com/blog/generating-shopify-authorization-credentials) will show you exactly what you need to do to get a shop access token with full permissions.

Once you have those credentials, place them inside of the `AppSettings.example.config` file and **rename that file** to `AppSettings.private.config`. That will ensure your private API key and access token don't accidentally get uploaded to public source control.
