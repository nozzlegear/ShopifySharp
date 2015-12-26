# ShopifySharp: A .NET library for Shopify.

ShopifySharp is a .NET library that enables you to authenticate and make API calls to Shopify. It's great for 
building custom Shopify Apps using C# and .NET. You can quickly and easily get up and running with Shopify 
using this library.

# The Shopify Development Handbook

[![Learn how to build rock-solid Shopify apps with C# and ASP.NET](https://i.imgur.com/9GgDjK0.png)](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp)

Building an app or integration for the Shopify store is hard work. There are a ton of things you need to keep in mind when stitching together all of the API calls, redirect URLs and app settings that you'll need to use.

You're going to be asking yourself all of these questions when you try to build an app for the Shopify store:

- How can I charge my users when they use my app?
- What in the world is an embedded app?
- How should I be using Shopify's redirect URLs?
- When should I be using a proxy page?
- Am I dealing with webhooks the right way?
- How can I let my user's actual customers interact with the app?
- Can I add custom scripts to their website, and what can those scripts even do?
- How the heck do I go about testing my app?

It's difficult to find blog posts or tutorials about building Shopify apps, and downright impossible if you're trying to build them with C# and ASP.NET. Shopify's own partner blog puts a huge focus on designing themes over building real, functional apps, and their API docs only go so far if you don't know what you're looking for.

[The Shopify Development Handbook](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp) is a premium educational course that distills the experience of building Shopify applications and integrations into one concise and comprehensive course.

[Click here to learn more about The Shopify Development Handbook, **and get a FREE sample chapter** on integrating a merchant's Shopify store with your app.](https://nozzlegear.com/shopify-development-handbook?ref=ShopifySharp)

# Installation

ShopifySharp is [available on NuGet](https://www.nuget.org/packages/ShopifySharp/). Use the package manager 
console in Visual Studio to install it:

```
Install-Package ShopifySharp 
```

### A work-in-progress

Currently, the only other .NET library for Shopify is [Shopify.net](https://github.com/cmcdonaldca/shopify.net), which 
hasn't been updated in over 3 years and requires that you know the exact URL paths of the Shopify API, along with 
creating your own entity classes for each resource. That's why I'm building ShopifySharp — .NET developers need a 
fully-featured library for interacting with Shopify and building Shopify apps.

With that said, this library is still pretty new. It currently suppports the following Shopify APIs:

- [OAuth authentication](#authorization-and-authentication).
- [Application charges (in-app purchases)](#one-time-application-charges)
- [Recurring application charges (subscriptions)](#recurring-application-charges-charge-shop-owners-to-use-your-app)
- [Shops](#shops)
- [Customers](#customers)
- [Orders](#orders)
- [Products](#products)
- [Webhooks](#webhooks)
- [Script Tags](#script-tags)
- [Assets](#assets)
- [Themes](#themes)
- [Redirects](#redirects)
- [Collects](#collects)
- [Fulfillments](#fulfillments)
- [Transactions](#transactions)

More functionality will be added each week until it reachs full parity with Shopify's REST API.

# Usage

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**. 
An access token is the token returned after authenticating and authorizing a Shopify app installation with a 
real Shopify store. 

If you just need an access token for a private Shopify app, or for running the tests in this library, refer 
to the **Tests** section below.

## Authorization and authentication

### Ensure a given URL is a valid *myshopify.com URL

This is a convenience method that validates whether a given URL is a valid Shopify shop. It's great for ensuring 
you don't redirect a user to an incorrect URL when you need them to authorize your app installation, and is 
ideally used in conjuction with `ShopifyAuthorizationService.BuildAuthorizationUrl`.

```c#
string urlFromUser = "https://example.myshopify.com";
bool isValidUrl = await ShopifyAuthorizationService.IsValidMyShopifyUrl(urlFromUser).
```

### Build an authorization URL

Redirect your users to this authorization URL, where they'll be prompted to install your app to their Shopify store.

```c#
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

Once you've sent a user to the authorization URL and they've confirmed your app installation, they'll be redirected 
back to your application at either the default app URL, or the redirect URL you passed in when building the 
authorization URL.

The access token you receive after authorizing should be stored in your database. You'll need it to access the 
shop's resources (e.g. orders, customers, fulfillments, etc.)

```c#
//The querystring will have several parameters you need for authorization.
string code = Request.QueryString["code"];
string myShopifyUrl = Request.QueryString["shop"];

string accessToken = await ShopifyAuthorizationService.Authorize(code, myShopifyUrl, shopifyApiKey, shopifySecretKey);
```

### Determine if a request is authentic

Any (non-webhook, non-proxy-page) request coming from Shopify will have a querystring paramater called 'signature' that you can use 
to verify that the request is authentic. This signature is a hash of all querystring parameters and your app's 
secret key. 

Pass the entire querystring to `ShopifyAuthorizationService` to verify the request.

```c#
var qs = Request.QueryString;

if(ShopifyAuthorizationService.IsAuthenticRequest(qs, shopifySecretKey))
{
    //Request is authentic.
}
else
{
    //Request is not authentic and should not be acted on.
}
```

### Determine if a proxy page request is authentic

Nearly identical to authenticating normal requests, a proxy page request only differs in that the algorithm uses HMACSHA256 rather than MD5. All proxy page requests coming from Shopify will have a querystring parameter named `signature` that you can use to verify the request. This signature is a hash of all querystring parameters and your app's secret key.

```cs
var qs = Request.QueryString;

if(ShopifyAuthorizationService.IsAuthenticProxyRequest(qs, shopifySecretKey))
{
    //Request is authentic.
}
else
{
    //Request is not authentic and should not be acted on.
}
```

### Determine if a webhook request is authentic

Any webhook request coming from Shopify will have a header called 'X-Shopify-Hmac-SHA256' that you can use 
to verify that the webhook is authentic. The header is a hash of the entire request body and your app's 
secret key.

Pass the entire header collection and the request's input stream to `ShopifyAuthorizationService` to verify 
the request.

```c#
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

You can also pass in the request body as a string, rather than using the input stream. However, the request 
body string needs to be identical to the way it was sent from Shopify. If it has been modified, the 
verification will fail.

```c#
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

The Shopify billing API lets you create a recurring charge on a shop owner's account, letting them pay you 
for using your application. There are pros and cons to using the Shopify billing API versus a service like 
Stripe, BrainTree or PayPal. 

I've put together a small guide called ***Shopify Billing 101: A Developer's Guide To Getting Paid For Your Apps***, 
and you can get for **free** by joining the mailing list for ***Mastering Shopify Development*** (a training course 
for building Shopify apps with C# and ASP.NET). 

[Just head over here to get your free guide to the Shopify billing API.](https://nozzlegear.com/landing/shopify-billing-101?ref=ShopifySharp)

### Create a recurring charge

```c#
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

```c#
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

var charge = await service.GetAsync(chargeId);
```

### Listing recurring charges

```c#
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

IEnumerable<ShopifyRecurringCharge> charges = await service.ListAsync();
```

### Activating a charge

Creating a charge does not actually charge the shop owner or even start their free trial. You need to 
send them to the charge's `ConfirmationUrl`, have them accept the charge, then activate it.

```c#
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

await service.ActivateAsync(chargeId);
```

### Deleting a charge

Charges cannot be deleted unless they've been activated. Shopify automatically deletes pending charges 
after 48 hours pass without activation. 

```c#
var service = new ShopifyRecurringChargeService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(chargeId);
```

## One-time application charges

Just like with the above recurring charges, the Shopify billing API lets you create a one-time application 
charge on the shop owner's account. One-time charges cannot be deleted.

### Create a one-time charge

```c#
var service = new ShopifyChargeService(myShopifyUrl, shopAccessToken);
var charge = new ShopifyCharge()
{
    Name = "Lorem Ipsum Charge",
    Price = 12.34,
    Test = true, //Marks this charge as a test, meaning it won't charge the shop owner.
}

charge = await service.CreateAsync(charge);
```

### Retrieve a one-time charge

```c#
var service = new ShopifyChargeService(myShopifyUrl, shopAccessToken);

var charge = await service.GetAsync(chargeId);
```

### Listing one-time charges

```c#
var service = new ShopifyChargeService(myShopifyUrl, shopAccessToken);

IEnumerable<ShopifyCharge> charges = await service.ListAsync();
```

### Activating a charge

Just like recurring charges, creating a one-time charge does not actually charge the shop owner. You need to 
send them to the charge's `ConfirmationUrl`, have them accept the charge, then activate it.

```c#
var service = new ShopifyChargeService(myShopifyUrl, shopAccessToken);

await service.ActivateAsync(chargeId);
```

## Shops

### Retrieving shop information

```c#
var service = new ShopifyShopService(myShopifyUrl, shopAccessToken);

var shop =  = await service.GetAsync();
```

## Customers

### Creating a customer

```c#
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

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId);
```

### Retrieving a customer with certain fields

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId, "first_name,last_name,email"); 

//Returns a customer with only FirstName, LastName and Email fields. All other fields are null.
```

### Updating a customer

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId);

customer.Email = "test-update@example.com";
customer = await service.UpdateAsync(customer);
```

### Deleting a customer

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(customerId);
```

### Counting customers

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
int customerCount = await service.CountAsync();
```

### Listing customers

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.ListAsync();
```

### Searching customers

```c#
var service =  new ShopifyCustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyCustomer> customers = await Service.SearchAsync("Jane country:United States");

//Searches for a customer from the United States with a name like 'Jane'. 
//There is a noticeable 3-30 second delay between creating a customer and Shopify 
//indexing it for a search.
```

## Orders

### Creating an order

```c#
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

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
var order = await service.GetAsync(orderId);
```

### Updating an order

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
var order = await service.GetAsync(orderId);

order.Notes = "Test notes.";
order = await service.UpdateAsync(order);
```

### Deleting an order

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId);
```

### Counting orders

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
int orderCount = await service.CountAsync();
```

### Listing orders

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListAsync();
```

### List orders for a certain customer

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> orders = await service.ListForCustomerAsync(customerId);
```

### Close an order

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.CloseAsync(orderId);
```

### Reopen a closed order

```c#
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.OpenAsync(orderId);
```

## Products

The `ShopifyProductService`, tests and all related models were built by [Yitzchok](https://github.com/yitzchok). Thank you for contributing!

### Creating a product

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
var product = new ShopifyProduct()
{
    Title = "Burton Custom Freestlye 151",
    Vendor = "Burton",
    BodyHtml = "<strong>Good snowboard!</strong>",
    ProductType = "Snowboard",
    Images = new List<ShopifyProductImage> 
    { 
        new ShopifyProductImage 
        { 
            Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" 
        }
    },
};

product = await service.CreateAsync(product);
```

### Retrieving a product

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
var product = await service.GetAsync(productId);
```

### Updating a product

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
var product = await service.GetAsync(productId);

product.Title = "New product title";
product = await service.UpdateAsync(product);
```

### Deleting a product

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId);
```

### Counting products

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
int productCount = await service.CountAsync();
```

### Listing products

```c#
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyOrder> products = await service.ListAsync();

//Optionally filter the results
var filter = new ShopifyProductFilterOptions() 
{ 
    Ids = new[] 
    { 
        productId1,
        productId2,
        productId3
    } 
};
products = await service.ListAsync(filter);
```

## Webhooks

### Creating a webhook

```c#
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

```c#
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.GetAsync(webhookId);
```

### Updating a webhook

```c#
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.GetAsync(webhookId);

webhook.Address = "https://my.webhook.url.com/new/path";
webhook = await service.UpdateAsync(webhook);
```

### Deleting a webhook

```c#
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(webhookId);
```

### Counting webhooks

```c#
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
int webhookCount = await service.CountAsync();
```

### Listing webhooks

```c#
var service = new ShopifyWebhookService(myShopifyUrl, shopAccessToken);
IEnumerable<ShopifyWebhook> webhooks = await service.ListAsync();
```

## Script Tags

Script tags let you add remote javascript tags that are loaded into the pages of a shop's storefront, letting you 
dynamically change the functionality of their shop without manually editing their store's template.

### Creating a script tag

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);
var tag = new ShopifyScriptTag()
{
    Event = ShopifyScriptTagEvent.Onload,
    Src  = "https://example.com/my-javascript-file.js"
}

tag = await service.CreateAsync(tag);
```

### Retrieving a script tag

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);
var tag = await service.GetAsync(tagId);
```

### Updating a script tag

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);
var tag = await service.GetAsync(tagId);

tag.Src = "https://example.com/my-new-javascript-file.js";
tag = await service.UpdateAsync(tag);
```

### Deleting a script tag

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(tagId);
```

### Counting script tags

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);
int tagCount = await service.CountAsync();

//Optionally filter the count to only those tags with a specific Src
int filteredTagCount = await service.CountAsync("https://example.com/my-filtered-url.js");
```

### Listing script tags

```c#
var service = new ShopifyScriptTagService(myShopifyUrl, shopAccessToken);
var tags = await service.ListAsync();

//Optionally filter the list to only those tags with a specific Src
var filteredTags = await service.ListAsync(new ShopifyScriptTagListOptions() {
    Src = FilteredSrc
});
```

## Assets

The `ShopifyAssetService` lets you create, update and delete a store theme's asset files. Unlike other API services in ShopifySharp, the `ShopifyAssetService` has a single `.CreateOrUpdateAsync` method due to the way Shopify's API handles assets. If an asset has a unique `Key` value, it will be created. If not, it will be updated. You can copy an asset by setting the new asset's `SourceKey` to the target's `Key` value.

Shopify asset's do not have an id, but rather a key string; they're also organized into type 'buckets'. For a liquid template, it's full key would be `templates/liquid.index`; for an image, its key would be `assets/my-image.png`.

Finally, all assets are tied to a specific theme, and you need that theme's id to interact with assets. You can use the [`ShopifyThemeService`](#themes) to get a list of the shop's themes, or the `ShopifyShopService` to get the currently active theme's id.

### Creating an asset

```cs
var service = new ShopifyAssetService(myShopifyUrl, shopAccessToken);
var asset = new ShopifyAsset()
{
    ContentType = "text/x-liquid",
    Key = "templates/test.liquid",
    Value  = "<h1>Hello, world!</h1>"
}

//Note: Creating an asset does not return it's 'Value' property. 
//You must specifically refresh it with service.GetAsync
asset = await service.CreateAsync(themeId, asset);
```

### Retrieving an asset

```cs
var service = new ShopifyAssetService(myShopifyUrl, shopAccessToken);
var key = "templates/index.liquid";

var asset = await service.GetAsync(themeId, key);
```

### Listing assets

```cs
var service = new ShopifyAssetService(myShopifyUrl, shopAccessToken);

var assets = await service.ListAsync(themeId);
```

### Updating assets

```cs
var service = new ShopifyAssetService(myShopifyUrl, shopAccessToken);
var key = "templates/test.liquid";
var asset = await service.GetAsync(themeId, key);

asset.Value = "<h1>Hello, world! I've been updated.</h1>";

//Note: Updating an asset does not return it's 'Value' property. 
//You must specifically refresh it with service.GetAsync
asset = await service.UpdateAsync(themeId, asset);
```

### Copying an asset

You can create a new asset by copying an already existing one. Just set the new asset's `SourceKey` property to 
match the target's `Key` property.

```cs
var service = new ShopifyAssetService(myShopifyUrl, shopAccessToken);
var originalAsset = await service.GetAsync(themeId, "templates/index.liquid");
var asset = new ShopifyAsset()
{
    Key = "templates/test.liquid",
    SourceKey = originalAsset.Key
};

//Note: Creating an asset does not return it's 'Value' property. 
//You must specifically refresh it with service.GetAsync
asset = await service.UpdateAsync(themeId, asset);
```

## Themes

The `ShopifyThemeService` lets you create, update, list, get and delete a store's themes.

### Creating a theme

When you create a theme, you can optionally pass in a URL that points to a .zip file containing all of the new theme's files. Shopify will then copy those files into the theme. Be aware that copying files is not instant, and the theme's `Processing` flag will be set to `true` until it's done. 

You cannot update or delete a theme that is still processing.

```c#
var service = new ShopifyThemeService(myShopifyUrl, shopAccessToken);
var theme = new ShopifyTheme()
{
    Name = "My new theme.",
    Role = ShopifyThemeRole.Unpublished
}

theme = await service.CreateAsync(theme);

//Or, create a theme and copy its files from a .zip file URL
theme = await service.CreateAsync(theme, 'https://my-domain.com/my-theme-files.zip');
```

### Retrieving a theme

```c#
var service = new ShopifyThemeService(myShopifyUrl, shopAccessToken);
var theme = await service.GetAsync(themeId);
```

### Updating a theme

Remember, you can't update a theme if its `Processing` flag is set to `true`. Shopify will automatically set it to `false` once it's done processing. Additionally, you cannot set a theme's role from `ShopifyThemeRole.Main` to `ShopifyThemeRole.Unpublished`. Instead, you need to set a different theme's role to `ShopifyThemeRole.Main`.

```c#
var service = new ShopifyThemeService(myShopifyUrl, shopAccessToken);
var theme = await service.GetAsync(themeId);

theme.Name = "My updated theme.";
theme.Role = ShopifyThemeRole.Main;

theme = await service.UpdateAsync(theme);
```

### Deleting a theme

```c#
var service = new ShopifyThemeService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(themeId);
```

### Listing themes

```c#
var service = new ShopifyThemeService(myShopifyUrl, shopAccessToken);
var themes = await service.ListAsync();
```

## Redirects

A `ShopifyRedirect` lets you create URL redirects on a Shopify store. When a store visitor navigates to a redirect's `Path`, they'll be redirected to the redirect's `Target`.

### Creating a redirect

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);
var redirect = new ShopifyRedirect()
{
    Path = "/ipod",
    Target  = "https://apple.com/ipod"
}

redirect = await service.CreateAsync(redirect);
```

### Retrieving a redirect

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);
var redirect = await service.GetAsync(redirectId);
```

### Updating a redirect

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);
var redirect = await service.GetAsync(redirectId);

redirect.Path = "/ipad";
redirect.Target = "https://apple.com/ipad";

redirect = await service.UpdateAsync(redirect);
```

### Deleting a redirect

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(redirectId);
```

### Counting redirects

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);
int redirectCount = await service.CountAsync();

//Optionally filter the count to only those redirects with a specific path or target
int filteredRedirectCount = await service.CountAsync(path: "/ipod", target: "https://apple.com/ipod/");
```

### Listing redirects

```c#
var service = new ShopifyRedirectService(myShopifyUrl, shopAccessToken);
var redirects = await service.ListAsync();

//Optionally filter the list to only those redirects with a specific path or target
var filteredRedirects = await service.ListAsync(new ShopifyRedirectListOptions() {
    Path = "/ipod",
    Target = "https://apple.com/ipod"
});
```

## Collects

A `ShopifyCollect` is an object that connects a product to a custom collection.

The `ShopifyCollectService` and models were built by [stepankobzey](https://github.com/stepankobzey). Thank you for contributing!

### Creating a collect

```c#
var service = new ShopifyCollectService(myShopifyUrl, shopAccessToken);
var collect = new ShopifyCollect()
{
    CollectionId = collectionId,
    ProductId = productId
}

collect = await service.CreateAsync(collect);
```

### Retrieving a collect

```c#
var service = new ShopifyCollectService(myShopifyUrl, shopAccessToken);
var collect = await service.GetAsync(collectId);
```

### Deleting a collect

```c#
var service = new ShopifyCollectService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(collectId);
```

### Counting collects

```c#
var service = new ShopifyCollectService(myShopifyUrl, shopAccessToken);
int collectCount = await service.CountAsync();

//Optionally filter the count to only those collects for a certain product or collection
int filteredCollectCount = await service.CountAsync(new ShopifyCollectFilterOptions()
{
    ProductId = productId,
    CollectionId = collectionId
});
```

### Listing collects

```c#
var service = new ShopifyCollectService(myShopifyUrl, shopAccessToken);
var collects = await service.ListAsync();

//Optionally filter the list to only those collects for a certain product or collection
var filteredCollects = await service.CountAsync(new ShopifyCollectFilterOptions()
{
    ProductId = productId,
    CollectionId = collectionId
});
```

## Fulfillments

A fulfillment represents a shipment of one or more items in an order. All fulfillments are tied to a single order.

### Creating a fulfillment

This will completely fulfill all of the line items in the order.

```c#
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new ShopifyFulfillment()
{
    TrackingCompany = "Jack Black's Pack, Stack and Track",
    TrackingUrl = "https://example.com/123456789",
    TrackingNumber = "123456789",
}

fulfillment = await service.CreateAsync(orderId, fulfillment);
```

### Creating a partial fulfillment

This will partially fulfill the given line items, dependent on the line item's quantity. 

```cs
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new ShopifyFulfillment()
{
    TrackingCompany = "Jack Black's Pack, Stack and Track",
    TrackingUrl = "https://example.com/123456789",
    TrackingNumber = "123456789",
    LineItems = new List<ShopifyLineItem>()
    {
        new ShopifyLineItem()
        {
            Id = lineItemId,
            Quantity = 1 //Fulfills 1 qty of this line item.
        }
    }
}

fulfillment = await service.CreateAsync(orderId, fulfillment);
```

### Creating a single fulfillment

This will completely fulfill the given line items.

```cs
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new ShopifyFulfillment()
{
    TrackingCompany = "Jack Black's Pack, Stack and Track",
    TrackingUrl = "https://example.com/123456789",
    TrackingNumber = "123456789",
    LineItems = new List<ShopifyLineItem>()
    {
        new ShopifyLineItem()
        {
            Id = lineItemId
        }
    }
}

fulfillment = await service.CreateAsync(orderId, fulfillment);
```

### Retrieving a fulfillment

```c#
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = await service.GetAsync(orderId, fulfillmentId);
```

### Updating a fulfillment

```cs
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = await service.GetAsync(orderId, fulfillmentId);

fulfillment.TrackingCompany = "John Doe's Tracking Company";

await service.UpdateAsync(orderId, fulfillment);
```

### Counting fulfillments

```c#
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
int fulfillmentCount = await service.CountAsync(orderId);
```

### Listing fulfillments

```c#
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillments = await service.ListAsync(orderId);
```

### Completing a fulfillment

Fulfillments can only be completed if their `Status` is `pending`.

```cs
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
await service.CompleteAsync(orderId, fulfillmentId)
```

### Cancelling a fulfillment

Fulfillments can only be cancelled if their `Status` is `pending`.

```cs
var service = new ShopifyFulfillmentService(myShopifyUrl, shopAccessToken);
await service.CancelAsync(orderId, fulfillmentId)
```

## Transactions

Transactions are created for every order that results in an exchange of money. All transactions are tied to a single order.

### Creating a full capture transaction

By omitting an `Amount` value, this transaction will capture the full amount. 

**Note**: to create a `Capture` transaction, the order must have an `Authorization` transaction on it. However, an `Authorization` transaction can only be created at the time the order was created. 

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transaction = new ShopifyTransaction()
{
    Kind = ShopifyTransactionKind.Capture
};

await service.CreateAsync(orderId, transaction);
```

### Creating a partial capture transaction

This method will capture a specified amount on a previously authorized order. 

**Note**: to create a `Capture` transaction, the order must have an `Authorization` transaction on it. However, an `Authorization` transaction can only be created at the time the order was created. 

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transaction = new ShopifyTransaction()
{
    Kind = ShopifyTransactionKind.Capture,
    Amount = 5.00
};

await service.CreateAsync(orderId, transaction);
```

### Creating a refund transaction

This method will create a refund on a previously authorized order. Like the last two examples, you can either refund a partial amount by setting the `Amount` value, or refund the full amount by omitting that value.

**Note**: to create a `Refund` transaction, the order must have an `Authorization` transaction on it. However, an `Authorization` transaction can only be created at the time the order was created. 

**Additionally**, it seems you can't create a `Refund` transaction for any order that was created via the API. (I can't find any documentation about this behavior. Let me know if this is wrong.)

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transaction = new ShopifyTransaction()
{
    Kind = ShopifyTransactionKind.Refund,
    Amount = 5.00
};

await service.CreateAsync(orderId, transaction);
```

### Creating a cancel transaction

This method is supposed to cancel a previously authorized order's payment. **However**, the Shopify API will throw an error whenever you try to do this. It may be that, like the refund transaction, you can't cancel an order that was created via the API. Again, there's no documentation for this behavior, let me know if you have any information.

That in mind, I'm including this example for posterity.

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transaction = new ShopifyTransaction()
{
    Kind = ShopifyTransactionKind.Void
};

//Throws an error.
await service.CreateAsync(orderId, transaction);
```

### Getting a transaction

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transaction = await service.GetAsync(orderId, transactionId);
```

### Counting transactions

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(orderId);
```

### Listing transactions

```cs
var service = new ShopifyTransactionService(myShopifyUrl, shopAccessToken);
var transactions = await service.ListAsync(orderId);

//Optionally filter the list to those after the given id
var transactions = await service.ListAsync(orderId, sinceId);
```

# A note on enums

When I first started building ShopifySharp, I didn't realize how much of a mess Shopify's enum documentation really is. That's partially my fault, because Shopify sends their enum values as strings and I wanted to make life easier by converting those strings to real C# enums.

The problem is that Shopify rarely documents all of their enum values, and sometimes they send null values too. That's fine for them in dynamic ruby-land, but it breaks things when you're using a strongly-typed language like C#. 

Trying to deserialize an unknown or null enum value, of course, throws an exception. At first I tried to get around that by creating a new enum deserializer that would try to convert unknown or null values to a `MyEnumName.Unknown`. While that worked, it was more work than I would prefer to set up each enum with a `.Unknown` value and make sure it serializes and deserializes properly.

[From this point on, all new enums will be nullable](https://github.com/nozzlegear/ShopifySharp/issues/10). It takes the same amount of effort to check if an enum is null as it does to check if it's `Unknown`. However, nullable enums have the added benefit of not requiring their own special `.Unknown` member and dedicated serializer. If the value doesn't exist, or if it's null, the enum field will just be null. No exceptions will be thrown, nobody's app will break.

Unfortunately, it won't be possible to convert previous enums to nullable without breaking builds. Instead, they'll be converted to nullables in the next major release: version 2.0.0. 

# Tests

The test suite relies on your own Shopify credentials, including your Shopify API key, a shop's *.myshopify.com URL, and an access 
token with full permissions for that shop. [This blog post](https://nozzlegear.com/blog/generating-shopify-authorization-credentials) 
will show you exactly what you need to do to get a shop access token with full permissions.

Once you have those credentials, place them inside of the `AppSettings.example.config` file and **rename that file** 
to `AppSettings.private.config`. That will ensure your private API key and access token don't accidentally get uploaded 
to public source control.

---

With all of that said, the `ShopifyRecurringChargeService` tests require a little bit of manual intervention to pass.

First, the service requires a real app, a real shop, and a real access token for that shop, because private apps cannot 
use the Shopify billing API. 

Second, when testing the `service.ActivateAsync` and `service.DeleteAsync` methods, you'll need to do the following: 

1. Insert a breakpoint after creating a charge.
2. Copy the charge's `ConfirmationUrl` into your browser and navigate to it.
3. Accept the charge.
4. Release the breakpoint and finish the test.
