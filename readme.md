# ShopifySharp: A .NET library for Shopify.

ShopifySharp is a .NET library that enables you to authenticate and make API calls to Shopify. It's great for building custom Shopify Apps using C# and .NET. You can quickly and easily get up and running with Shopify using this library.

### How to contact me

**If you're looking for a Shopify consultant** to build your next app or integrate your shop with your own custom software, **I'm available for hire**. Send an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com) and we'll discuss your project. If you just want to get in touch with me, the best way to do that is by sending an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com), or by following me on Twitter at [@nozzlegear](https://twitter.com/nozzlegear).

### A work-in-progress

Currently, the only other .NET library for Shopify is [Shopify.net](https://github.com/cmcdonaldca/shopify.net), which hasn't been updated in over 3 years and requires that you know the exact URL paths of the Shopify API, along with creating your own entity classes for each resource. That's why I'm building ShopifySharp — .NET developers need a fully-featured library for interacting with Shopify and building Shopify apps.

With that said, this library is brand new. It currently only supports **OAuth authentication**, the **Customers** resource, the **Orders** resource, and the **Shop** resource. More functionality will be added each week until it reachs full parity with Shopify's REST API.

![imgur](http://i.imgur.com/WJKJI9D.png)

Finally, we'll get a NuGet package set up for this library soon.

# Usage

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**. An access token is the token returned after authenticating and authorizing a Shopify app installation with a real Shopify store. 

If you just need an access token for a private Shopify app, or for running the tests in this library, refer to the **Tests** section below.

## Authorization and authentication

### Build an authorization URL

Redirect your users to this authorization URL, where they'll be prompted to install your app to their Shopify store.

```
//This is the user's store URL.
string usersMyShopifyUrl = "https://example.myshopify.com";

//An optional URL to redirect the user to after they've confirmed app installation.
//If you don't specify a redirect url, Shopify will redirect to your app's default URL.
string redirectUrl = "https://example.com/my/redirect/url";

//An array of the Shopify access scopes your application needs to run.
IEnumerable<ShopifyAuthorizationScope> scopes = new List<ShopifyAuthorizationScope>()
{
    ShopifyAuthorizationScope.ReadCustomers,
    ShopifyAuthorizationScope.WriteCustomers
};

//All ShopifyAuthorizationService methods are static.
string authUrl = ShopifyAuthorizationService.BuildAuthorizationUrl(scopes, usersMyShopifyUrl, shopifyApiKey);
```

### Authorize an installation and generate an access token

Once you've sent a user to the authorization URL and they've confirmed your app installation, they'll be redirected back to your application at either the default app URL, or the redirect URL you passed in when building the authorization URL.

The access token you receive after authorizing should be stored in your database. You'll need it to access the shop's resources (e.g. orders, customers, fulfillments, etc.)

```
//The querystring will have several parameters you need for authorization.
string code = Request.QueryString["code"];
string myShopifyUrl = Request.QueryString["shop"];

string accessToken = await ShopifyAuthorizationService.Authorize(code, myShopifyUrl, shopifyApiKey, shopifySecretKey);
```

### Determine if a request is authentic

Any (non-webhook) request coming from Shopify will have a querystring paramater called 'signature' that you can use to verify that the request is authentic. This signature is a hash of all querystring parameters and your app's secret key. 

Pass the entire querystring to `ShopifyAuthorizationService` to verify the request.

```
NameValueCollection queryString = Request.QueryString;

if(ShopifyAuthorizationService.IsAuthenticRequest(queryString, shopifySecretKey))
{
    //Request is authentic.
}
else
{
    //Request is not authentic and should not be acted on.
}
```

### Determine if a webhook request is authentic

Any webhook request coming from Shopify will have a header called 'X-Shopify-Hmac-SHA256' that you can use to verify that the webhook is authentic. The header is a hash of the entire request body and your app's secret key.

Pass the entire header collection and the request's input stream to `ShopifyAuthorizationService` to verify the request.

```
NameValueCollection requestHeaders = Request.Headers;
Stream inputStream = Request.InputStream;

if(ShopifyAuthorizationService.IsAuthenticWebhook(requestHeaders, inputStream, shopifySecretKey))
{
    //Webhook is authentic.
}
else
{
    //Webhook is not authentic and should not be acted on.
}
```

You can also pass in the request body as a string, rather than using the input stream. However, the request body string needs to be identical to the way it was sent from Shopify. If it has been modified, the verification will fail.

```
NameValueCollection requestHeaders = Request.Headers;
string requestBody = null;

//Reset the input stream. MVC controllers often read the stream to determine which parameters to pass to an action.
Request.InputStream.Position = 0;

//Read the stream into a string
using(StreamReader reader = new StreamReader(Request.InputStream))
{
    requestBody = await reader.ReadToEndAsync();
}

if(ShopifyAuthorizationService.IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey))
{
    //Webhook is authentic.
}
else
{
    //Webhook is not authentic and should not be acted on.
}

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

## Orders

### Creating an order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
ShopifyOrder order = new ShopifyOrder()
{
    CreatedAt = DateTime.UtcNow,
    BillingAddress = new ShopifyAddress()
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
    },
    LineItems = new List<ShopifyLineItem>()
    {
        new ShopifyLineItem()
        {
            Name = "Test Line Item",
            Title = "Test Line Item Title"
        }
    },
    FinancialStatus = Enums.ShopifyOrderFinancialStatus.Paid,
    TotalPrice = 5.00,
    Email = Guid.NewGuid().ToString() + "@example.com",
    Note = "Test note about the customer.",
};

order = await service.CreateAsync(order);
```

### Retrieving an order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
ShopifyOrder order = await service.GetAsync(orderId);
```

### Updating an order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
ShopifyOrder order = await service.GetAsync(orderId);

order.Notes = "Test notes.";
order = await service.UpdateAsync(order);
```

### Deleting an order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId);
```

### Counting orders

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
int orderCount = await service.CountAsync();
```

### Listing orders

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListAsync();
```

### List orders for a certain customer

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListForCustomerAsync(customerId);
```

### Close an order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.CloseAsync(orderId);
```

### Reopen a closed order

```
ShopifyOrderService service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.OpenAsync(orderId);
```

# Tests

The test suite relies on your own Shopify credentials, including your Shopify API key, a shop's *.myshopify.com URL, and an access token with full permissions for that shop. [This blog post](https://nozzlegear.com/blog/generating-shopify-authorization-credentials) will show you exactly what you need to do to get a shop access token with full permissions.

Once you have those credentials, place them inside of the `AppSettings.example.config` file and **rename that file** to `AppSettings.private.config`. That will ensure your private API key and access token don't accidentally get uploaded to public source control.
