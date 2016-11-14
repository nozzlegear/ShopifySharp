# ShopifySharp: A .NET library for Shopify.

[![NuGet](https://img.shields.io/nuget/v/ShopifySharp.svg?maxAge=3600)](https://www.nuget.org/packages/ShopifySharp/)
[![license](https://img.shields.io/github/license/nozzlegear/shopifysharp.svg?maxAge=3600)](https://github.com/nozzlegear/shopifysharp/blob/master/LICENSE)

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

# Version 3.0.0

Version 3.0.0 is a major update to ShopifySharp, it contains breaking changes by [removing almost all enums](#why-dont-you-use-enums) from the library. We recommend updating to 3.0.0+ if you're using any of the enums from 2.x in production. These enums are brittle, and [Shopify can change them without warning, thereby breaking your app](https://github.com/nozzlegear/ShopifySharp/issues/64).

### A work-in-progress

Currently, the only other .NET library for Shopify is [Shopify.net](https://github.com/cmcdonaldca/shopify.net), which
hasn't been updated in over 3 years and requires that you know the exact URL paths of the Shopify API, along with
creating your own entity classes for each resource. That's why I'm building ShopifySharp — .NET developers need a
fully-featured library for interacting with Shopify and building Shopify apps.

With that said, this library is still pretty new. It currently suppports the following Shopify APIs:

- [OAuth authentication](#authorization-and-authentication).
- [Application charges (in-app purchases)](#one-time-application-charges)
- [Recurring application charges (subscriptions)](#recurring-application-charges-charge-shop-owners-to-use-your-app)
- [Usage charges](#usage-charges)
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
- [Pages](#pages)
- [Metafields](#metafields)
- [Custom Collections](#custom-collections)
- [Product Images](#product-images)
- [Locations](#locations)
- [Events](#events)
- [Order Risks](#order-risks)
- [Smart Collections](#smart-collections)
- [Product Variants](#product-variants)
- [Blogs](#blogs)
- [Application Credits](#application-credits)

More functionality will be added each week until it reachs full parity with Shopify's REST API.

### Unimplemented APIs

The following APIs are not yet implemented by ShopifySharp, but I'm slowly working through the list to reach 100% API parity. APIs are implemented in random order (mostly based on how much I need them in a personal project). **Need one of these APIs right now?** Please open an issue or make a pull request! I'm happy to offer guidance or help with writing tests.

| API | Notes |
|-----|-------|
| [AbandonedCheckouts](https://help.shopify.com/api/reference/abandoned_checkouts) | |
| [Articles](https://help.shopify.com/api/reference/article) | |
| [CarrierService](https://help.shopify.com/api/reference/carrierservice) | |
| [Comments](https://help.shopify.com/api/reference/comment) | |
| [Country](https://help.shopify.com/api/reference/country) | |
| [CustomerAddress](https://help.shopify.com/api/reference/customeraddress) | Object is implemented. |
| [CustomerSavedSearch](https://help.shopify.com/api/reference/customersavedsearch) | |
| [Discount](https://help.shopify.com/api/reference/discount) | Requires Shopify Plus. |
| [FulfillmentEvent](https://help.shopify.com/api/reference/fulfillmentevent) | Object is implemented. |
| [FulfillmentService](https://help.shopify.com/api/reference/fulfillmentservice) | Not [ShopifyFulfillmentService](https://github.com/nozzlegear/ShopifySharp/blob/master/ShopifySharp/Services/Fulfillment/ShopifyFulfillmentService.cs). |
| [GiftCard](https://help.shopify.com/api/reference/gift_card) | Requires Shopify Plus. |
| [Multipass](https://help.shopify.com/api/reference/multipass) | Requires Shopify Plus. |
| [Policy](https://help.shopify.com/api/reference/policy) | |
| [Province](https://help.shopify.com/api/reference/province) | |
| [Refund](https://help.shopify.com/api/reference/refund) | |
| [ShippingZone](https://help.shopify.com/api/reference/shipping_zone) | |
| [Transaction](https://help.shopify.com/api/reference/transaction) | Object is implemented. |
| [User](https://help.shopify.com/api/reference/user) | Requires Shopify Plus. |

### Contributors

These generous people have contributed their own hard work and time to improving ShopifySharp:

- [Yitzchok](https://github.com/yitzchok)
- [Shannan Finley](https://github.com/squallop)
- [stepankobzey](https://github.com/stepankobzey)
- [Cathy Pank](https://github.com/Panksy)
- [mooglegiant](https://github.com/mooglegiant)
- [ishahrier](https://github.com/ishahrier)
- [darkstar74](https://github.com/darkstar74)
- [Angel Arriaga](https://github.com/damazoarriaga)
- [Shaju Mohammed](https://github.com/shajumohamed)
- [Jono](https://github.com/mrjono1)
- [Tommy Holm Jakobsen](https://github.com/thj-dk)

Thank you!

# Using ShopifySharp with a public Shopify app

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**.
An access token is the token returned after authenticating and authorizing a Shopify app installation with a
real Shopify store.

All instances of `myShopifyUrl` refer to your users' `*.myshopify.com` URL (although their custom domain should work too).

```cs
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
```

# Using ShopifySharp with a private Shopify app

ShopifySharp should work out of the box with your private Shopify application, all you need to do is replace the `shopAccessToken` with your private app's password when initializing a ShopifyService:

```cs
var service = new ShopifyProductService(myShopifyUrl, privateAppPassword)
```

If you just need an access token for a private Shopify app, or for running the tests in this library, refer
to the **Tests** section below.

## Authorization and authentication

### Ensure a given URL is a valid *myshopify.com URL

This is a convenience method that validates whether a given URL is a valid Shopify shop. It's great for ensuring
you don't redirect a user to an incorrect URL when you need them to authorize your app installation, and is
ideally used in conjuction with `ShopifyAuthorizationService.BuildAuthorizationUrl`.

ShopifySharp will call the given URL and check for an `X-ShopId` header in the response. That header is present on all Shopify shops and its existence signals that the URL is indeed a Shopify URL.

**Note**, however, that this feature is undocumented by Shopify and may break at any time. Use at your own discretion.

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
var scopes = new List<ShopifyAuthorizationScope>()
{
    ShopifyAuthorizationScope.ReadCustomers,
    ShopifyAuthorizationScope.WriteCustomers
};

//Or, use an array of string permissions
var scopes = new List<string>()
{
    "read_customers",
    "write_customers"
}

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

Any (non-webhook, non-proxy-page) request coming from Shopify will have a querystring paramater called 'hmac' that you can use
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

Nearly identical to authenticating normal requests, a proxy page request only differs in the way the HMAC is generated. All proxy page requests coming from Shopify will have a querystring parameter named `hmac` that you can use to verify the request. This signature is a hash of all querystring parameters and your app's secret key.

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

## Usage charges

Shopify's Usage Charges let you set a capped amount on a recurring application charge, and only charge for usage. For example, you can create a charge that's capped at $100.00 per month, and then charge e.g. $1.00 for every 1000 emails your user sends using your app.

To create a ShopifyUsageCharge, you first need to create a ShopifyRecurringCharge with a `CappedAmount` value and a `Terms` string. Your customers will see the terms when activating the recurring charge, so set it to something they can read like "$1.00 per 1000 emails".

### Create a usage charge

```cs
var service = new ShopifyUsageChargeService(myShopifyUrl, shopAccessToken);

string description = "Used 1000 emails";
double price = 1.00;

var usageCharge = await service.CreateAsync(recurringChargeId, description, price);
```

### Get a usage charge

```cs
var service = new ShopifyUsageChargeService(myShopifyUrl, shopAccessToken);

var usageCharge = await service.GetAsync(recurringChargeId, usageChargeId);
```

### List usage charges

```cs
var service = new ShopifyUsageChargeService(myShopifyUrl, shopAccessToken);

var usageCharges = await service.ListAsync(recurringChargeId);
```

## Shops

### Retrieving shop information

```c#
var service = new ShopifyShopService(myShopifyUrl, shopAccessToken);

var shop = await service.GetAsync();
```

### Uninstalling your app

In cases where user intervention is not required, you can send a request to a Shopify shop to force it to uninstall your application. After sending this request, your shop access token will be immediately revoked and invalidated.

Uninstalling an application is an irreversible operation. Be entirely sure that you no longer need to make API calls for the shop in which the application has been installed.

Uninstalling an application also performs various cleanup tasks within Shopify. Registered Webhooks, ScriptTags and App Links will be destroyed as part of this operation. Also if an application is uninstalled during key rotation, both the old and new Access Tokens will be rendered useless.

```cs
var service = new ShopifyShopService(myShopifyUrl, shopAccessToken);

var shop = await service.UninstallAppAsync()
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
    FinancialStatus = "paid",
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

### Cancel an order

```cs
var service = new ShopifyOrderService(myShopifyUrl, shopAccessToken);

await service.CancelAsync(orderId);
```

## Products

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

//By default, creating a product will publish it. To create an unpublished product:+1:
product = await service.CreateAsync(product, new ShopifyProductCreateOptions() { Published = false });

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
IEnumerable<ShopifyProduct> products = await service.ListAsync();

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

### Publishing a product

```cs
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
var product = await service.PublishAsync(productId);
```

### Unpublishing a product

```cs
var service = new ShopifyProductService(myShopifyUrl, shopAccessToken);
var product = await service.UnpublishAsync(productId);
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
    Topic = "app/uninstalled",
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
    Event = "onload",
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
    Role = "unpublished"
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

Remember, you can't update a theme if its `Processing` flag is set to `true`. Shopify will automatically set it to `false` once it's done processing. Additionally, you cannot set a theme's role from `"main"` to `"unpublished"`. Instead, you need to set a different theme's role to `"main"`.

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
    Kind = "capture"
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
    Kind = "capture",
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
    Kind = "refund",
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
    Kind = "void"
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

## Pages

A `ShopifyPage` represents a web page on the merchant's Shopify storefront.

### Creating a page

```cs
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);
var page = new ShopifyPage()
{
    CreatedAt = DateTime.UtcNow,
    Title = "Burton Custom Freestlye 151",
    BodyHtml = "<strong>Good snowboard!</strong>",
};

page = await service.CreateAsync(page);
```

### Counting a page

```cs
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing pages

```cs
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);
var pages = await service.ListAsync();
```

### Retrieving a page

```cs
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);
var page = await service.GetAsync(pageId);
```

### Updating a page

```cs
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);
var page = await service.GetAsync(pageId);

page.Title = "My New Page Title",

page = await service.UpdateAsync(page);
```

### Deleting a page

```c#
var service = new ShopifyPageService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(pageId);
```

## Metafields

### Creating a metafield

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = new ShopifyMetaField()
{
    Namespace = "myNamespace",
    Key = "myKey",
    Value = "5",
    ValueType = "integer",
    Description = "This is a test meta field. It is an integer value."
};

//Create a new metafield on a product
metafield = await service.CreateAsync(metafield, productId, "products");
```

### Counting metafields

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId, "products");
```

### Listing metafields

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
var metafields = await service.ListAsync(productId, "products");
```

### Getting a metafield

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = await service.GetAsync(metafieldId);
```

### Updating a metafield

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = await service.GetAsync(metafieldId);

metafield.Value = "45";

metafield = await service.UpdateAsync(metafield);
```

### Deleting a metafield

```cs
var service = new ShopifyMetaFieldService(myShopifyUrl, shopAccessToken);
await service.DeleteAsync(metafieldId);
```

## Custom Collections

A custom collection is a grouping of products that a shop owner can create to make their shops easier to browse. A shop owner creates a custom collection and then selects the products that will go into it.

### Creating a custom collection

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.CreateAsync(new ShopifyCustomCollection()
{
    Title = "My Custom Collection",
    Published = true,
    PublishedAt = DateTime.UtcNow,
    Image = new ShopifyCustomCollectionImage()
    {
        Src = "http://placehold.it/250x250"
    }
});
```

### Getting a custom collection

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.GetAsync(collectionId);
```

### Counting custom collections

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing custom collections

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);
var collections = await service.ListAsync();
```

### Updating a custom collection

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.GetAsync(collectionId);

collection.Title = "My new collection title";

collection = await service.UpdateAsync(collection);
```

### Deleting a custom collection

```cs
var service = new ShopifyCustomCollectionService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(collectionId);
```

## Product Images

Product Images represent the various different images for a product. All product images are tied to an owner product, and therefore you'll need to pass that product's id to each product image method.

### Creating a product image

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.CreateAsync(productId, new ShopifyProductImage()
{
    Metafields = new List<ShopifyMetaField>()
    {
        new ShopifyMetaField()
        {
            Key = "alt",
            Value = "new alt tag content",
            ValueType = "string",
            Namespace = "tags"
        }
    },
    Src = "http://placehold.it/200/300"
});
```

### Getting a product image

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.GetAsync(productId, imageId);
```

### Counting product images

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId);
```

### Listing product images

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);
var images = await service.ListAsync(productId);
```

### Updating a product image

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.GetAsync(productId);

image.Position = 2;

image = await service.UpdateAsync(productId, image);
```

### Deleting a product image

```cs
var service = new ShopifyProductImageService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId, imageId);
```

## Locations

A Location represents a geographical location where your stores, headquarters, and/or pop-up shops exist. These locations can be used to track sales and to help Shopify configure the tax rates to charge when selling products.

### Listing locations

```cs
var service = new ShopifyLocationService(myShopifyUrl, shopAccessToken);
var locations = await service.ListAsync();
```

### Getting a location

```cs
var service = new ShopifyLocationService(myShopifyUrl, shopAccessToken);
var location = await service.GetAsync(locationId);
```

## Events

Events are generated by specific Shopify resources when specific things happen, such as the creation of an article, the placement or fulfillment of an order, the addition or deletion of a product, and so on. By requesting events, your app can get a "log" of important occurrences in the operation of a shop.

**Caution:** the events returned by the Events API should not be considered to be realtime. Events might not appear in the list returned by the API until a few seconds after they've occurred. In rare cases (<1% of the time) it can take up to a few minutes for some events to appear.

### Counting events

```cs
var service = new ShopifyEventService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Getting an event

```cs
var service = new ShopifyEventService(myShopifyUrl, shopAccessToken);
var event = await service.GetAsync(eventId);
```

### Listing events

```cs
var service = new ShopifyEventService(myShopifyUrl, shopAccessToken);
var events = await service.ListAsync();
```

### Listing events for a specific subject (e.g. Order or Product)

You can filter your event list result to only the events created by a specific "subject"; i.e. you can list all events for one specific Order, Product, Article, etc. When filtering events in this way, you must supply both the "subject" type *and* its id.

Known subject types are 'Articles', 'Blogs', 'Custom_Collections', 'Comments', 'Orders', 'Pages', 'Products' and 'Smart_Collections'. A current list of subject types can be found at [https://help.shopify.com/api/reference/event](https://help.shopify.com/api/reference/event).

```cs
var service = new ShopifyEventService(myShopifyUrl, shopAccessToken);
var subjectType = "Order";
var orderEvents = await service.ListAsync(orderId, subjectType);
```

## Order Risks

The Order risk assessment is used to indicate to a merchant the fraud checks that have been done on an order. 

### Create an Order Risk

```cs
var service = new ShopifyOrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.CreateAsync(orderId, new ShopifyOrderRisk()
{
    Message = "This looks risk!",
    Score = (decimal)0.85,
    Recommendation = "cancel",
    Source = "External",
    CauseCancel = false,
    Display = true,
});
```

### Get an Order Risk

```cs
var service = new ShopifyOrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.GetAsync(orderId, riskId);
```

### Update an Order Risk

```cs
var service = new ShopifyOrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.GetAsync(orderId, riskId);

risk.Message = "An updated risk message";

risk = await service.UpdateAsync(orderId, risk);
```

### List Order Risks

```cs
var service = new ShopifyOrderRiskService(myShopifyUrl, shopAccessToken);
var risks = await service.ListAsync(orderId);
```

### Delete an Order Risk

```cs
var service = new ShopifyOrderRiskService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId, riskId);
```

## Smart Collections

A smart collection is a grouping of products defined by simple rules set by shop owners. A shop owner creates a smart collection and then sets the rules that determine which products go in them. Shopify automatically changes the contents of smart collections based on their rules.

### Creating a Smart Collection

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.CreateAsync(new ShopifySmartCollection()
{
   Title = "My Smart Collection",
   Handle = "my-url-slug",
   BodyHtml = "\<h1\>Hello world!\</h1\>",
   Image = new ShopifySmartCollectionImage()
   {
       // Base-64 image attachment
       Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
   } 
});
```

### Updating a Smart Collection

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.GetAsync(smartCollectionId);

smartCollection.Title = "My Updated Title";

smartCollection = await service.UpdateAsync(smartCollection);
```

### Getting a Smart Collection

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.GetAsync(smartCollectionId);
```

### Counting Smart Collections

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing Smart Collections

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollections = await service.ListAsync();
```

### Deleting a Smart Collection

```cs
var service = new ShopifySmartCollectionService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(smartCollectionId);
```

## Product Variants

A product variant is a different version of a product, such as differing sizes or differing colors. Without product variants, you would have to treat the small, medium and large versions of a t-shirt as three separate products; product variants let you treat the small, medium and large versions of a t-shirt as variations of the same product.

### Creating a Product Variant

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.CreateAsync(productId, new ShopifyProductVariant()
{
    Option1 = "blue",
    Price = 123.45,
});
```

### Getting a Product Variant

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.GetAsync(variantId);
```

### Updating a Product Variant

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.GetAsync(variantId);

variant.Price = 543.21;

variant = await service.UpdateAsync(variant);
```

### Listing Product Variants

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);
var variants = await service.ListAsync(productId);
```

### Counting Product Variants

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId);
```

### Deleting a Product Variant

```cs
var service = new ShopifyProductVariantService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId, variantId);
```

## Blogs

In addition to an online storefront, Shopify shops come with a built-in blogging engine, allowing a shop to have one or more blogs. **This service is for interacting with blogs themselves, not blog posts**.

### Creating a Blogs

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);
var blog = await service.CreateAsync(new ShopifyBlog()
{
    Title = "My new blog"
});
```

### Getting a Blogs

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);
var blog = await service.GetAsync(blogId);
```

### Updating a Blogs

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);
var blog = await service.GetAsync(blogId);

blog.Comments = "moderate";
blog = await service.UpdateAsync(blog);
```

### Listing Blogs

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);
var blogs = await service.ListAsync();
```

### Counting Blogs

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Deleting a Blog

```cs
var service = new ShopifyBlogService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(blogId);
```

## Application Credits

Shopify's Application Credit API lets you offer credits for payments your app customers have made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.

The total amount of all Application Credits created by an application must not exceed:

1. Total amount paid to the application by the shop owner in the last 30 days.
2. Total amount of pending receivables in the partner account associated with the application.

Additionally, Application Credits cannot be used by private applications.

### Creating an Application Credit

```cs
var service = new ShopifyApplicationCreditService(myShopifyUrl, shopAccessToken);
var credit = await service.CreateAsync(new ShopifyApplicationCredit() 
{
    Description = "Refund for Foo",
    Amount = 10.00m
});
```

### Getting an Application Credit

```cs
var service = new ShopifyApplicationCreditService(myShopifyUrl, shopAccessToken);
var charge = await service.GetAsync(creditId);
```

### Listing Application Credits

```cs
var service = new ShopifyApplicationCreditService(myShopifyUrl, shopAccessToken);
var charges = await service.ListAsync();
```

# "Why don't you use enums?"

I'm a big fan of using enums to make things easier for C# devs, because it removes a lot of the headache that comes with trying to remember all the valid string options for certain properties. With enums, we get those options hardcoded by default. We can easily scroll up and down the list of known values and select the one we need, without having to worry about typos.

Many Shopify objects have string properties that only accept a predetermined list of values, and these properties are perfect for matching to C# enums. Unfortunately, Shopify has a habit of only documenting the most used values and leaving the developer to guess the rest. On top of that, they sometimes change those enums completely, [such as this case where they changed the enums used for filtering orders without announcing it](https://github.com/nozzlegear/ShopifySharp/issues/64).

That's a problem when it comes to strongly-typed languages like C#. If you receive an enum property that doesn't have a value matching the enum, you're going to get a big fat exception thrown in your face. This is especially problematic when these undocumented enum values are sent to you automatically in webhooks. 

On top of that, if there's an enum value that you need to send but isn't in ShopifySharp, you'll need to wait until a new version of the lib is released before you can use it. 

Enums would be much better suited to ShopifySharp if Shopify themselves used API versioning, but sadly that isn't the case. After struggling with undocumented values and unannounced changes that break apps through two major releases of ShopifySharp, I've made the decision to pull the plug on almost all enums in the lib.

What were previously enums in ShopifySharp 1.x and 2.x are now string properties. This change will prevent breaking your app when an enum value changes, and will allow you to quickly update your app when a new enum value is released without waiting on an update to ShopifySharp first.

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
