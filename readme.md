# ShopifySharp: A .NET library for Shopify.

ShopifySharp is a .NET library that enables you to authenticate and make API calls to Shopify. It's great for building custom Shopify Apps using C# and .NET. You can quickly and easily get up and running with Shopify using this library.

### How to contact me

**If you're looking for a Shopify consultant** to build your next app or integrate your shop with your own custom software, **I'm available for hire**. Send an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com) and we'll discuss your project. If you just want to get in touch with me, the best way to do that is by sending an email to [joshua@nozzlegear.com](mailto:joshua@nozzlegear.com), or by following me on Twitter at [@nozzlegear](https://twitter.com/nozzlegear).

### A work-in-progress

Currently, the only other .NET library for Shopify is [Shopify.net](https://github.com/cmcdonaldca/shopify.net), which hasn't been updated in over 3 years and requires that you know the exact URL paths of the Shopify API, along with creating your own entity classes for each resource. That's why I'm building ShopifySharp — .NET developers need a fully-featured library for interacting with Shopify and building Shopify apps.

With that said, this library is brand new. It currently only supports **OAuth authentication**, the **Customers** resource, the **Orders** resource, the **Webhooks** resource, and the **Shop** resource. More functionality will be added each week until it reachs full parity with Shopify's REST API.

![imgur](http://i.imgur.com/WJKJI9D.png)

# Installation

ShopifySharp is [available on NuGet](https://www.nuget.org/packages/ShopifySharp/). Use the package manager console in Visual Studio to install it:

```
Install-Package ShopifySharp 
```

# Usage

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**. An access token is the token returned after authenticating and authorizing a Shopify app installation with a real Shopify store. 

If you just need an access token for a private Shopify app, or for running the tests in this library, refer to the **Tests** section below.

## Authorization and authentication

### Ensure a given URL is a valid *myshopify.com URL

This is a convenience method that validates whether a given URL is a valid Shopify shop. It's great for ensuring you don't redirect a user to an incorrect URL when you need them to authorize your app installation, and is ideally used in conjuction with `ShopifyAuthorizationService.BuildAuthorizationUrl`.

```
string urlFromUser = "https://example.myshopify.com";
bool isValidUrl = await ShopifyAuthorizationService.IsValidMyShopifyUrl(urlFromUser).
```

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

## Recurring Application Charges (charge shop owners to use your app)

The Shopify billing API lets you create a recurring charge on a shop owner's account, letting them pay you for using your application. There are pros and cons to using the Shopify billing API versus a service like Stripe, BrainTree or PayPal. 

I've put together a small guide called ***Shopify Billing 101: A Developer's Guide To Getting Paid For Your Apps***, and you can get for **free** by joining the mailing list for ***Mastering Shopify Development*** (a training course for building Shopify apps with C# and ASP.NET). 

[Just head over here to get your free guide to the Shopify billing API.](http://eepurl.com/bwiP7T)

### Create a recurring charge

```
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);
var charge = new ShopifyRecurringCharge()
{
    Name = "Lorem Ipsum Plan",
    Price = 12.34,
    Test = true, //Marks this charge as a test, meaning it won't charge the shop owner.
    TrialDays = 21    
}

charge = await service.CreateAsync(charge);
```

### Retrieve a recurring charge

```
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

var charge = await service.GetAsync(chargeId);
```

### Listing recurring charges

```
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

IEnumerable<ShopifyRecurringCharge> charges = await service.ListAsync();
```

### Activating a charge

Creating a charge does not actually charge the shop owner or even start their free trial. You need to send them to the charge's `ConfirmationUrl`, have them accept the charge, then activate it.

```
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

await service.ActivateAsync(chargeId);
```

### Deleting a charge

Charges cannot be deleted unless they've been activated. Shopify automatically deletes pending charges after 48 hours pass without activation.

```
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(chargeId);
```

## Shops

### Retrieving shop information

```
var service = new ShopifyShopService(myShopifyUrl, shopAccessToken);

var shop =  = await service.GetAsync();
```

## Customers

### Creating a customer

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = new ShopifyCustomer()
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
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId);
```

### Retrieving a customer with certain fields

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId, "first_name,last_name,email"); 

//Returns a customer with only FirstName, LastName and Email fields. All other fields are null.
```

### Updating a customer

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId);

customer.Email = "test-update@example.com";
customer = await service.UpdateAsync(customer);
```

### Deleting a customer

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(customerId);
```

### Counting customers

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
int customerCount = await service.CountAsync();
```

### Listing customers
```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.ListAsync();
```

### Searching customers

```
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.SearchAsync("Jane country:United States");

//Searches for a customer from the United States with a name like 'Jane'. 
//There is a noticeable 3-30 second delay between creating a customer and Shopify 
//indexing it for a search.
```

## Orders

### Creating an order

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
var order = new ShopifyOrder()
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
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
var order = await service.GetAsync(orderId);
```

### Updating an order

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
var order = await service.GetAsync(orderId);

order.Notes = "Test notes.";
order = await service.UpdateAsync(order);
```

### Deleting an order

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId);
```

### Counting orders

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
int orderCount = await service.CountAsync();
```

### Listing orders

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListAsync();
```

### List orders for a certain customer

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListForCustomerAsync(customerId);
```

### Close an order

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.CloseAsync(orderId);
```

### Reopen a closed order

```
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.OpenAsync(orderId);
```

## Webhooks

### Creating a webhook

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
ShopifyWebhook hook = new ShopifyWebhook()
{
    Address = "https://my.webhook.url.com/path",
    CreatedAt = DateTime.Now,
    Fields = new List<string>() { "field1", "field2" },
    Format = "json",
    MetafieldNamespaces = new List<string>() { "metafield1", "metafield2" },
    Topic = topic,
};

hook = await service.CreateAsync(hook);
```

### Retrieving a webhook

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.GetAsync(webhookId);
```

### Updating a webhook

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.GetAsync(webhookId);

webhook.Address = "https://my.webhook.url.com/new/path";
webhook = await service.UpdateAsync(webhook);
```

### Deleting a webhook

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(webhookId);
```

### Counting webhooks

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
int webhookCount = await service.CountAsync();
```

### Listing webhooks

```
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyWebhook> webhooks = await service.ListAsync();
```

# Tests

The test suite relies on your own Shopify credentials, including your Shopify API key, a shop's *.myshopify.com URL, and an access token with full permissions for that shop. [This blog post](https://nozzlegear.com/blog/generating-shopify-authorization-credentials) will show you exactly what you need to do to get a shop access token with full permissions.

Once you have those credentials, place them inside of the `AppSettings.example.config` file and **rename that file** to `AppSettings.private.config`. That will ensure your private API key and access token don't accidentally get uploaded to public source control.

---

With all of that said, the `ShopifyRecurringChargeService` tests require a little bit of manual intervention to pass.

First, the service requires a real app, a real shop, and a real access token for that shop, because private apps cannot use the Shopify billing API. 

Second, when testing the `service.ActivateAsync` and `service.DeleteAsync` methods, you'll need to do the following: 

1. Insert a breakpoint after creating a charge.
2. Copy the charge's `ConfirmationUrl` into your browser and navigate to it.
3. Accept the charge.
4. Release the breakpoint and finish the test.