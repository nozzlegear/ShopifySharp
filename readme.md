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

ShopifySharp is [available on NuGet](https://www.nuget.org/packages/ShopifySharp/). Use the package manager
console in Visual Studio to install it:

```pwsh
Install-Package ShopifySharp
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```sh
dotnet add package shopifysharp
```

If you're using Paket with an F# project, use this command:

```sh
paket add shopifysharp --project /path/to/project.fsproj
```

# API support

Shopify has begun versioning their API, meaning new features are locked behind newer versions of the API, and older versions of the API lose support and are eventually shut off. Due to the differences in ShopifySharp's SemVer versioning, and Shopify's date-based versioning, the following table should be consulted to determine which version of ShopifySharp supports which version of Shopify's API:

| ShopifySharp version | Shopify API version |
| -------------------- | ------------------- |
| 4.x and below        | None, unsupported   |
| 5.0.0 - 5.5.0        | 2019-10             |
| 5.6.0 - 5.7.0        | 2020-07             |
| 5.8.0 - 5.10.0       | 2020-10             |
| 5.11.0 - 5.13.1      | 2021-07             |
| 5.14.0 - 5.15.0      | 2021-10             |
| 5.16.0 and above     | 2022-04             |

**Note:** ShopifySharp dropped support for .NET Framework 4.5 in version 5.14.0. [More details in #438.](https://github.com/nozzlegear/ShopifySharp/issues/438)

# Migrating from version 4.x to version 5.0.0

**A complete migration guide for going from v4.x to v5.x is located here:** [https://nozzlegear.com/shopify/shopifysharp-version-5-migration-guide](https://nozzlegear.com/shopify/shopifysharp-version-5-migration-guide). The biggest change by far is the way you'll list objects in v5. Shopify has implemented a sort of "linked list" pagination, which means you _cannot_ request arbitrary pages any longer (e.g. "give me page 5 of orders").

Instead, you now have to walk through each page, following the link from one page to the next, to get where you need to go. As long as Shopify is caching the results, this should improve the speed with which your application can list large swathes of objects at once (e.g. when importing all of a user's orders into your application). However, this makes things like letting your users navigate to an arbitrary page of orders in your app impossible. At best, you'll only be able to show links to the next page or previous page.

An example for listing all orders on a Shopify shop:

```cs
var allOrders = new List<Order>();
var service = new OrderService(domain, accessToken);
var page = await service.ListAsync(new OrderListFilter
{
    Limit = 250,
});

while (true)
{
    allOrders.AddRange(page.Items);

    if (!page.HasNextPage)
    {
        break;
    }

    page = await service.ListAsync(page.GetNextPageFilter());
}
```

You can also [check this issue for commonly asked questions about v5.0](https://github.com/nozzlegear/ShopifySharp/issues/462).

# Frequently Asked Questions

- **Question**: How do I look up a Shopify order by its name?
    - **Answer**: [See this article to learn how to look up a Shopify order by its name property.](https://nozzlegear.com/shopify/looking-up-a-shopify-order-by-its-name)
- **Question**: How do I use ShopifySharp with a private app?
    - **Answer**: ShopifySharp works with any private Shopify app, no extra configuration needed. All you need to do is pass in your private app's password wherever ShopifySharp asks for an access token. For example: `var service = new ShopifySharp.OrderService("mydomain.myshopify.com", "PRIVATE APP PASSWORD HERE")`. This package's test suite uses a private app for testing API calls, so this method is confirmed working.

# A work-in-progress

I first started working on ShopifySharp because .NET developers need a fully-featured library for interacting with Shopify and building Shopify apps, which didn't exist several years ago. My goal is to eventually reach 100% compatibility with the Shopify REST API, but, with that said, Shopify is constantly adding new APIs and altering old ones. I try my best to keep up with them, but I tend to prioritize the support of new APIs by how much I need them in my own Shopify apps.

ShopifySharp currently supports the following Shopify APIs:

-   Access
    -   [OAuth authentication](#authorization-and-authentication).
    -   [Access Scopes](#access-scopes)
    -   [StorefrontAccessTokens](#storefrontaccesstokens)
-   Analytics
    -   Report (not implimented yet)
-   Billing
    -   [Application charges (in-app purchases)](#one-time-application-charges)
    -   [Application Credits](#application-credits)
    -   [Recurring application charges (subscriptions)](#recurring-application-charges-charge-shop-owners-to-use-your-app)
    -   [Usage charges](#usage-charges)
-   Customers
    -   [Customers](#customers)
    -   Customer Address (docs not yet written)
    -   Customer Saved Search (docs not yet written)
-   Discounts
    -   [Discounts](#discounts)
    -   [Price Rules](#price-rules)
-   Events
    -   [Events](#events)
    -   [Webhooks](#webhooks)
-   Inventory  
    -   Inventory Item (docs not yet written)
    -   Inventory Level (docs not yet written)
    -   [Locations](#locations)
-   Marketing Event (not implimented yet)
-   [Metafields](#metafields)
-   Online Store
    -   [Articles](#articles)
    -   [Assets](#assets)
    -   [Blogs](#blogs)
    -   Comment (not implimented yet)
    -   [Pages](#pages)
    -   [Redirects](#redirects)
    -   [Script Tags](#script-tags)
    -   [Themes](#themes)
-   Orders
    -   [Abandoned Checkouts](#abandoned-checkouts)
    -   [Draft Orders](#draft-orders)
    -   [Orders](#orders)
    -   [Order Risks](#order-risks)
    -   Refund (docs not yet written)
    -   [Transactions](#transactions)
-   Plus
    -   [GiftCards](#gift-cards)
    -   [User](#users)
-   Products
    -   [Collects](#collects)
    -   [Collections](#collections)
    -   [Custom Collections](#custom-collections)
    -   [Products](#products)
    -   [Product Images](#product-images)
    -   [Product Variants](#product-variants)
    -   [Smart Collections](#smart-collections)
-   Sales Channels
    -   [Checkouts](#checkouts)
    -   Collection Listing (not implimented yet)
    -   Mobile Platform Application (not implimented yet)
    -   Payment (not implimented yet)
    -   Product Resource Feedback (not implimented yet)
    -   Product Listing (not implimented yet)
    -   Resource Feedback (not implimented yet)
-   Shipping and Fulfillment
    -   [Assigned Fulfillment Orders](#assigned-fulfillment-orders)
    -   Cancellation Request (not implimented yet)
    -   Carrier Service (docs not yet written)
    -   [Fulfillments](#fulfillments)
    -   [Fulfillment Events](#fulfillment-events)
    -   [Fulfillment Orders](#fulfillment-orders) (List/Get only. Create/Delete not implemented yet)
    -   [Fulfillment Requests](#fulfillment-requests)
    -   [Fulfillment Services](#fulfillment-services)
    -   Locations For Move (not implimented yet)
-   Shopify Payments
    -   Balance (docs not yet written)
    -   Dispute (docs not yet written)
    -   Payouts (docs not yet written)
    -   Transactions (docs not yet written)
-   Store Properties
    -   Country (docs not yet written)
    -   Currency (not implimented yet)
    -   [Policies](#policies)
    -   Province (not implimented yet)
    -   [Shipping Zones](#shipping-zones)
    -   [Shops](#shops)
-   Tender Transaction (not implimented yet)
-   [Multipass (Shopify Plus)](#multipass)

More functionality will be added each week until it reaches full parity with Shopify's REST API.

### Contributors

These generous people have contributed their own hard work and time to improving ShopifySharp:

-   [Yitzchok](https://github.com/yitzchok)
-   [Shannan Finley](https://github.com/squallop)
-   [stepankobzey](https://github.com/stepankobzey)
-   [Cathy Pank](https://github.com/Panksy)
-   [mooglegiant](https://github.com/mooglegiant)
-   [ishahrier](https://github.com/ishahrier)
-   [darkstar74](https://github.com/darkstar74)
-   [Angel Arriaga](https://github.com/damazoarriaga)
-   [Shaju Mohammed](https://github.com/shajumohamed)
-   [Jono](https://github.com/mrjono1)
-   [Tommy Holm Jakobsen](https://github.com/thj-dk)
-   [Ernesto Gutiérrez](https://github.com/ernestogutierrez)
-   [clement911](https://github.com/clement911)
-   [mchandschuh](https://github.com/mchandschuh)
-   [Andrew Mobbs](https://github.com/mobbsie)
-   [Martin Zezulka](https://github.com/martinzezulkacz)
-   [Bart Coppens](https://github.com/bartcoppens)
-   [Tommy Holm Jakobsen](https://github.com/thj-dk)
-   [Andrew Fox](https://github.com/foxandrewj)
-   [Victor](https://github.com/vleontyev)
-   [lasamuadib](https://github.com/lasamuadib)
-   [Jeremy Simmons](https://github.com/jsimmonsdavidccook)
-   [BrianBarnard](https://github.com/BrianBarnard)
-   [Luke Vo](https://github.com/datvm)
-   [Josh](https://github.com/pianomanjh)
-   [yuvalsade](https://github.com/yuvalsade)

Thank you!

(If I missed you, just shoot me an email at joshua@nozzlegear.com)

# Using ShopifySharp with a public Shopify app

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Shopify API key**.
An access token is the token returned after authenticating and authorizing a Shopify app installation with a
real Shopify store.

All instances of `myShopifyUrl` refer to your users' `*.myshopify.com` URL (although their custom domain should work too).

```cs
var service = new ProductService(myShopifyUrl, shopAccessToken);
```

# Using ShopifySharp with a private Shopify app

ShopifySharp should work out of the box with your private Shopify application, all you need to do is replace the `shopAccessToken` with your private app's password when initializing a ShopifyService:

```cs
var service = new ProductService(myShopifyUrl, privateAppPassword)
```

If you just need an access token for a private Shopify app, or for running the tests in this library, refer
to the **Tests** section below.

## Authorization and authentication

**NOTICE**: If you're using ASP.NET MVC5 (or any version that isn't AspNet Core) you'll have compilation errors when trying to pass `Request.QueryString` or `Request.Headers` to the authorization methods described below. [See this issue for a workaround](https://github.com/nozzlegear/ShopifySharp/issues/164).

### Ensure a given URL is a valid \*myshopify.com URL

This is a convenience method that validates whether a given URL is a valid Shopify API domain (the Shopify API is hosted on each individual shop rather than at once central URL). It's great for ensuring
you don't redirect a user to an incorrect URL when you need them to authorize your app installation, and is
ideally used in conjunction with `AuthorizationService.BuildAuthorizationUrl`.

ShopifySharp will call the given URL and check for an `X-ShopId` header in the response. That header is present on all Shopify shops and it's existence signals that the URL is indeed a Shopify URL.

**Note**, however, that this feature is undocumented by Shopify and may break at any time. Use at your own discretion. In addition, it's possible for a malicious site to fake the `X-ShopId` header which would make this method return `true`.

```c#
string urlFromUser = "https://example.myshopify.com";
bool isValidDomain = await AuthorizationService.IsValidShopDomainAsync(urlFromUser).
```

### Build an authorization URL

Redirect your users to this authorization URL, where they'll be prompted to install your app to their Shopify store.

```c#
//This is the user's store URL.
string usersMyShopifyUrl = "https://example.myshopify.com";

// A URL to redirect the user to after they've confirmed app installation.
// This URL is required, and must be listed in your app's settings in your Shopify app dashboard.
// It's case-sensitive too!
string redirectUrl = "https://example.com/my/redirect/url";

//An array of the Shopify access scopes your application needs to run.
var scopes = new List<AuthorizationScope>()
{
    AuthorizationScope.ReadCustomers,
    AuthorizationScope.WriteCustomers
};

//Or, use an array of string permissions
var scopes = new List<string>()
{
    "read_customers",
    "write_customers"
}

//You can find your API key over at https://shopify.dev/tutorials/authenticate-a-private-app-with-shopify-admin
string shopifyApiKey = "";

//All AuthorizationService methods are static.
Uri authUrl = AuthorizationService.BuildAuthorizationUrl(scopes, usersMyShopifyUrl, shopifyApiKey, redirectUrl);
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

string accessToken = await AuthorizationService.Authorize(code, myShopifyUrl, shopifyApiKey, shopifySecretKey);
```

### Determine if a request is authentic

Any (non-webhook, non-proxy-page) request coming from Shopify will have a querystring parameter called 'hmac' that you can use
to verify that the request is authentic. This signature is a hash of all querystring parameters and your app's
secret key.

Pass the entire querystring to `AuthorizationService` to verify the request.

```c#
var qs = Request.QueryString;

if(AuthorizationService.IsAuthenticRequest(qs, shopifySecretKey))
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

if(AuthorizationService.IsAuthenticProxyRequest(qs, shopifySecretKey))
{
    //Request is authentic.
}
else
{
    //Request is not authentic and should not be acted on.
}
```

### Determine if a webhook request is authentic

Any webhook request coming from Shopify will have a header called `X-Shopify-Hmac-SHA256` that you can use
to verify that the webhook is authentic. The header is a hash of the entire request body and your app's
secret key.

Pass the entire header collection and the request's input stream to `AuthorizationService` to verify
the request.

```c#
NameValueCollection requestHeaders = Request.Headers;
Stream inputStream = Request.InputStream;

if(AuthorizationService.IsAuthenticWebhook(requestHeaders, inputStream, shopifySecretKey))
{
    //Webhook is authentic.
}
else
{
    //Webhook is not authentic and should not be acted on.
}
```

You can also pass in the request body as a string, rather than using the input stream. However, the request
body string **needs to be identical to the way it was sent from Shopify**. If it has been modified the verification will fail -- even if just one space is in the wrong place.

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

if(AuthorizationService.IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey))
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

I've put together a small guide called **_Shopify Billing 101: A Developer's Guide To Getting Paid For Your Apps_**,
and you can get for **free** by joining the mailing list for **_Mastering Shopify Development_** (a training course
for building Shopify apps with C# and ASP.NET).

[Just head over here to get your free guide to the Shopify billing API.](https://nozzlegear.com/landing/shopify-billing-101?ref=ShopifySharp)

Note that recurring charges are activated immediately after a user accepts them. At one time it was necessary to activate the charge after it was accepted, but Shopify has changed this behavior and it's no longer required or possible.

### Create a recurring charge

```c#
var service = new RecurringChargeService(myShopifyUrl, shopAccessToken);
var charge = new RecurringCharge()
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
var service = new RecurringChargeService(myShopifyUrl, shopAccessToken);

var charge = await service.GetAsync(chargeId);
```

### Listing recurring charges

```c#
var service = new RecurringChargeService(myShopifyUrl, shopAccessToken);

IEnumerable<RecurringCharge> charges = await service.ListAsync();
```

### Deleting a charge

Charges cannot be deleted unless they've been activated. Shopify automatically deletes pending charges
after 48 hours pass without activation.

```c#
var service = new RecurringChargeService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(chargeId);
```

## One-time application charges

Just like with the above recurring charges, the Shopify billing API lets you create a one-time application
charge on the shop owner's account. One-time charges cannot be deleted.

### Create a one-time charge

```c#
var service = new ChargeService(myShopifyUrl, shopAccessToken);
var charge = new Charge()
{
    Name = "Lorem Ipsum Charge",
    Price = 12.34,
    Test = true, //Marks this charge as a test, meaning it won't charge the shop owner.
}

charge = await service.CreateAsync(charge);
```

### Retrieve a one-time charge

```c#
var service = new ChargeService(myShopifyUrl, shopAccessToken);

var charge = await service.GetAsync(chargeId);
```

### Listing one-time charges

```c#
var service = new ChargeService(myShopifyUrl, shopAccessToken);

IEnumerable<Charge> charges = await service.ListAsync();
```

### Activating a charge

Just like recurring charges, creating a one-time charge does not actually charge the shop owner. You need to
send them to the charge's `ConfirmationUrl`, have them accept the charge, then activate it.

```c#
var service = new ChargeService(myShopifyUrl, shopAccessToken);

await service.ActivateAsync(chargeId);
```

## Usage charges

Shopify's Usage Charges let you set a capped amount on a recurring application charge, and only charge for usage. For example, you can create a charge that's capped at $100.00 per month, and then charge e.g. $1.00 for every 1000 emails your user sends using your app.

To create a UsageCharge, you first need to create a RecurringCharge with a `CappedAmount` value and a `Terms` string. Your customers will see the terms when activating the recurring charge, so set it to something they can read like "\$1.00 per 1000 emails".

### Create a usage charge

```cs
var service = new UsageChargeService(myShopifyUrl, shopAccessToken);

string description = "Used 1000 emails";
double price = 1.00;

var usageCharge = await service.CreateAsync(recurringChargeId, description, price);
```

### Get a usage charge

```cs
var service = new UsageChargeService(myShopifyUrl, shopAccessToken);

var usageCharge = await service.GetAsync(recurringChargeId, usageChargeId);
```

### List usage charges

```cs
var service = new UsageChargeService(myShopifyUrl, shopAccessToken);

var usageCharges = await service.ListAsync(recurringChargeId);
```

## Shops

### Retrieving shop information

```c#
var service = new ShopService(myShopifyUrl, shopAccessToken);

var shop = await service.GetAsync();
```

### Uninstalling your app

In cases where user intervention is not required, you can send a request to a Shopify shop to force it to uninstall your application. After sending this request, your shop access token will be immediately revoked and invalidated.

Uninstalling an application is an irreversible operation. Be entirely sure that you no longer need to make API calls for the shop in which the application has been installed.

Uninstalling an application also performs various cleanup tasks within Shopify. Registered Webhooks, ScriptTags and App Links will be destroyed as part of this operation. Also if an application is uninstalled during key rotation, both the old and new Access Tokens will be rendered useless.

```cs
var service = new ShopService(myShopifyUrl, shopAccessToken);

var shop = await service.UninstallAppAsync()
```

## Customers

### Creating a customer

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
var customer = new Customer()
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
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId);
```

### Retrieving a customer with certain fields

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.GetAsync(customerId, "first_name,last_name,email");

//Returns a customer with only FirstName, LastName and Email fields. All other fields are null.
```

### Updating a customer

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
var customer = await service.UpdateAsync(customerId, new Customer()
{
    Email = "test-update@example.com"
});
```

### Deleting a customer

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(customerId);
```

### Counting customers

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
int customerCount = await service.CountAsync();
```

### Listing customers

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<Customer> customers = await Service.ListAsync();
```

### Listing orders for a customer

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<Order> orders = await service.ListOrdersForCustomerAsync(customerId);
```

### Searching customers

```c#
var service =  new CustomerService(myShopifyUrl, shopAccessToken);
IEnumerable<Customer> customers = await Service.SearchAsync("Jane country:United States");

//Searches for a customer from the United States with a name like 'Jane'.
//There is a noticeable 3-30 second delay between creating a customer and Shopify
//indexing it for a search.
```

## Orders

### Creating an order

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);
var order = new Order()
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
    LineItems = new List<LineItem>()
    {
        new LineItem()
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
var service = new OrderService(myShopifyUrl, shopAccessToken);
var order = await service.GetAsync(orderId);
```

### Updating an order

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);
var order = await service.UpdateAsync(orderId, new Order()
{
    Notes = "test notes."
});
```

### Deleting an order

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId);
```

### Counting orders

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);
int orderCount = await service.CountAsync();
```

### Listing orders

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);
IEnumerable<Order> orders = await service.ListAsync();
```

### Close an order

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);

await service.CloseAsync(orderId);
```

### Reopen a closed order

```c#
var service = new OrderService(myShopifyUrl, shopAccessToken);

await service.OpenAsync(orderId);
```

### Cancel an order

```cs
var service = new OrderService(myShopifyUrl, shopAccessToken);

await service.CancelAsync(orderId);
```

## Products

### Creating a product

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);
var product = new Product()
{
    Title = "Burton Custom Freestlye 151",
    Vendor = "Burton",
    BodyHtml = "<strong>Good snowboard!</strong>",
    ProductType = "Snowboard",
    Images = new List<ProductImage>
    {
        new ProductImage
        {
            Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
        }
    },
};

product = await service.CreateAsync(product);

//By default, creating a product will publish it. To create an unpublished product:+1:
product = await service.CreateAsync(product, new ProductCreateOptions() { Published = false });

```

### Retrieving a product

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);
var product = await service.GetAsync(productId);
```

### Updating a product

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);
var product = await service.UpdateAsync(productId, new Product()
{
    Title = "New product title"
});
```

### Deleting a product

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId);
```

### Counting products

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);
int productCount = await service.CountAsync();
```

### Listing products

```c#
var service = new ProductService(myShopifyUrl, shopAccessToken);
IEnumerable<Product> products = await service.ListAsync();

//Optionally filter the results
var filter = new ProductFilterOptions()
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
var service = new ProductService(myShopifyUrl, shopAccessToken);
var product = await service.PublishAsync(productId);
```

### Unpublishing a product

```cs
var service = new ProductService(myShopifyUrl, shopAccessToken);
var product = await service.UnpublishAsync(productId);
```

## Webhooks

### Creating a webhook

```c#
var service = new WebhookService(myShopifyUrl, shopAccessToken);
Webhook hook = new Webhook()
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
var service = new WebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.GetAsync(webhookId);
```

### Updating a webhook

```c#
var service = new WebhookService(myShopifyUrl, shopAccessToken);
var webhook = await service.UpdateAsync(webhookId, new Webhook()
{
    Address = "https://my.webhook.url.com/new/path
});
```

### Deleting a webhook

```c#
var service = new WebhookService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(webhookId);
```

### Counting webhooks

```c#
var service = new WebhookService(myShopifyUrl, shopAccessToken);
int webhookCount = await service.CountAsync();
```

### Listing webhooks

```c#
var service = new WebhookService(myShopifyUrl, shopAccessToken);
IEnumerable<Webhook> webhooks = await service.ListAsync();
```

## Script Tags

Script tags let you add remote javascript tags that are loaded into the pages of a shop's storefront, letting you
dynamically change the functionality of their shop without manually editing their store's template.

### Creating a script tag

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);
var tag = new ScriptTag()
{
    Event = "onload",
    Src  = "https://example.com/my-javascript-file.js",
    DisplayScope = 'all'
}

tag = await service.CreateAsync(tag);
```

### Retrieving a script tag

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);
var tag = await service.GetAsync(tagId);
```

### Updating a script tag

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);
var tag = await service.UpdateAsync(tagId, new ScriptTag()
{
    Src = "https://example.com/my-new-javascript-file.js";
});
```

### Deleting a script tag

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(tagId);
```

### Counting script tags

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);
int tagCount = await service.CountAsync();

//Optionally filter the count to only those tags with a specific Src
int filteredTagCount = await service.CountAsync("https://example.com/my-filtered-url.js");
```

### Listing script tags

```c#
var service = new ScriptTagService(myShopifyUrl, shopAccessToken);
var tags = await service.ListAsync();

//Optionally filter the list to only those tags with a specific Src
var filteredTags = await service.ListAsync(new ScriptTagListOptions() {
    Src = FilteredSrc
});
```

## Assets

The `AssetService` lets you create, update and delete a store theme's asset files. Unlike other API services in ShopifySharp, the `AssetService` has a single `.CreateOrUpdateAsync` method due to the way Shopify's API handles assets. If an asset has a unique `Key` value, it will be created. If not, it will be updated. You can copy an asset by setting the new asset's `SourceKey` to the target's `Key` value.

Shopify asset's do not have an id, but rather a key string; they're also organized into type 'buckets'. For a liquid template, it's full key would be `templates/liquid.index`; for an image, its key would be `assets/my-image.png`.

Finally, all assets are tied to a specific theme, and you need that theme's id to interact with assets. You can use the [`ThemeService`](#themes) to get a list of the shop's themes, or the `ShopService` to get the currently active theme's id.

### Creating an asset

```cs
var service = new AssetService(myShopifyUrl, shopAccessToken);
var asset = new Asset()
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
var service = new AssetService(myShopifyUrl, shopAccessToken);
var key = "templates/index.liquid";

var asset = await service.GetAsync(themeId, key);
```

### Listing assets

```cs
var service = new AssetService(myShopifyUrl, shopAccessToken);

var assets = await service.ListAsync(themeId);
```

### Updating assets

```cs
var service = new AssetService(myShopifyUrl, shopAccessToken);

//Note: Updating an asset does not return it's 'Value' property.
//You must specifically refresh it with service.GetAsync
var asset = await service.UpdateAsync(themeId, assetId, new Asset()
{
    Value = "<h1>Hello, world! I've been updated.</h1>";
});
```

### Copying an asset

You can create a new asset by copying an already existing one. Just set the new asset's `SourceKey` property to
match the target's `Key` property.

```cs
var service = new AssetService(myShopifyUrl, shopAccessToken);
var asset = new Asset()
{
    Key = "templates/test.liquid",
    SourceKey = originalAsset.Key
};

//Note: Creating an asset does not return it's 'Value' property.
//You must specifically refresh it with service.GetAsync
asset = await service.UpdateAsync(themeId, assetId, asset);
```

## Themes

The `ThemeService` lets you create, update, list, get and delete a store's themes.

### Creating a theme

When you create a theme, you can optionally pass in a URL that points to a .zip file containing all of the new theme's files. Shopify will then copy those files into the theme. Be aware that copying files is not instant, and the theme's `Processing` flag will be set to `true` until it's done.

You cannot update or delete a theme that is still processing.

```c#
var service = new ThemeService(myShopifyUrl, shopAccessToken);
var theme = new Theme()
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
var service = new ThemeService(myShopifyUrl, shopAccessToken);
var theme = await service.GetAsync(themeId);
```

### Updating a theme

Remember, you can't update a theme if its `Processing` flag is set to `true`. Shopify will automatically set it to `false` once it's done processing. Additionally, you cannot set a theme's role from `"main"` to `"unpublished"`. Instead, you need to set a different theme's role to `"main"`.

```c#
var service = new ThemeService(myShopifyUrl, shopAccessToken);
var theme = await service.UpdateAsync(themeId, new Theme()
{
    Role = ThemeRole.Main,
    Name = "My updated theme."
});
```

### Deleting a theme

```c#
var service = new ThemeService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(themeId);
```

### Listing themes

```c#
var service = new ThemeService(myShopifyUrl, shopAccessToken);
var themes = await service.ListAsync();
```

## Redirects

A `Redirect` lets you create URL redirects on a Shopify store. When a store visitor navigates to a redirect's `Path`, they'll be redirected to the redirect's `Target`.

### Creating a redirect

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);
var redirect = new Redirect()
{
    Path = "/ipod",
    Target  = "https://apple.com/ipod"
}

redirect = await service.CreateAsync(redirect);
```

### Retrieving a redirect

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);
var redirect = await service.GetAsync(redirectId);
```

### Updating a redirect

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);
var redirect = await service.UpdateAsync(redirectId, new Redirect()
{
    Target = "https://apple.com/ipad",
    Path = "/ipad"
});
```

### Deleting a redirect

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(redirectId);
```

### Counting redirects

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);
int redirectCount = await service.CountAsync();

//Optionally filter the count to only those redirects with a specific path or target
int filteredRedirectCount = await service.CountAsync(path: "/ipod", target: "https://apple.com/ipod/");
```

### Listing redirects

```c#
var service = new RedirectService(myShopifyUrl, shopAccessToken);
var redirects = await service.ListAsync();

//Optionally filter the list to only those redirects with a specific path or target
var filteredRedirects = await service.ListAsync(new RedirectListOptions() {
    Path = "/ipod",
    Target = "https://apple.com/ipod"
});
```

## Collects

A `Collect` is an object that connects a product to a custom collection.

### Creating a collect

```c#
var service = new CollectService(myShopifyUrl, shopAccessToken);
var collect = new Collect()
{
    CollectionId = collectionId,
    ProductId = productId
}

collect = await service.CreateAsync(collect);
```

### Retrieving a collect

```c#
var service = new CollectService(myShopifyUrl, shopAccessToken);
var collect = await service.GetAsync(collectId);
```

### Deleting a collect

```c#
var service = new CollectService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(collectId);
```

### Counting collects

```c#
var service = new CollectService(myShopifyUrl, shopAccessToken);
int collectCount = await service.CountAsync();

//Optionally filter the count to only those collects for a certain product or collection
int filteredCollectCount = await service.CountAsync(new CollectFilterOptions()
{
    ProductId = productId,
    CollectionId = collectionId
});
```

### Listing collects

```c#
var service = new CollectService(myShopifyUrl, shopAccessToken);
var collects = await service.ListAsync();

//Optionally filter the list to only those collects for a certain product or collection
var filteredCollects = await service.CountAsync(new CollectFilterOptions()
{
    ProductId = productId,
    CollectionId = collectionId
});
```

---

## Fulfillments

A fulfillment represents a shipment of one or more items in an order. All fulfillments are tied to a single order.

### Creating a fulfillment

This will completely fulfill all of the line items in the order.

```c#
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new Fulfillment()
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
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new Fulfillment()
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
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = new Fulfillment()
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
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = await service.GetAsync(orderId, fulfillmentId);
```

### Updating a fulfillment

```cs
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillment = await service.UpdateAsync(orderId, fulfillmentId, new Fulfillment()
{
    TrackingCompany = "John Doe's Tracking Company"
});
```

### Counting fulfillments

```c#
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
int fulfillmentCount = await service.CountAsync(orderId);
```

### Listing fulfillments

```c#
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
var fulfillments = await service.ListAsync(orderId);
```

### Completing a fulfillment

Fulfillments can only be completed if their `Status` is `pending`.

```cs
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
await service.CompleteAsync(orderId, fulfillmentId)
```

### Cancelling a fulfillment

Fulfillments can only be cancelled if their `Status` is `pending`.

```cs
var service = new FulfillmentService(myShopifyUrl, shopAccessToken);
await service.CancelAsync(orderId, fulfillmentId)
```

---

## Assigned Fulfillment Orders

The AssignedFulfillmentOrder resource allows you to retrieve all the fulfillment orders that are assigned to an app at the shop level.

### Listing assigned fulfillment orders

Retrieves a list of fulfillment orders on a shop for a specific app.

```c#
var service = new AssignedFulfillmentOrderService(myShopifyUrl, shopAccessToken);

//Optionally filter the list to only those assigned fulfillments with a specific status
var filterStatus = new AssignedFulfillmentOrderFilter()
{
    AssignmentStatus = "fulfillment_requested"
});

var assignedFulfillments = await service.ListAsync(filterStatus);
```

---

## Fulfillment Events

The FulfillmentEvent resource represents tracking events that belong to a fulfillment of one or more items in an order.

### Creates a fulfillment event

Creates a new FulfillmentEvent on the fulfillment.

```c#
var service = new FulfillmentEventService(myShopifyUrl, shopAccessToken);
var fulfillmentEvent = new FulfillmentEvent()
{
    OrderId = 1234532,
    FulfillmentId = 156185165,
    Status = "confirmed"
}

fulfillmentEvent = await service.CreateAsync(orderId, fulfillmentId, fulfillmentEvent);
```

### List fulfillment events

Retrieves a list of fulfillment events for a specific fulfillment

```c#
var service = new FulfillmentEventService(myShopifyUrl, shopAccessToken);
var fulfillmentEvents = await service.ListAsync(orderId, fulfillmentId);
```

### Get a Fulfillment Event

Retrieves a specific fulfillment event

```c#
var service = new FulfillmentEventService(myShopifyUrl, shopAccessToken);
var fulfillmentEvent = await service.GetAsync(orderId, fulfillmentId, fulfillmentEventId);
```

### Delete A Fulfillment Event

```cs
var service = new FulfillmentEventService(myShopifyUrl, shopAccessToken);
await service.DeleteAsync(orderId, fulfillmentId, fulfillmentEventId)
```

--

## Fulfillment Orders

The FulfillmentOrder resource represents either an item or a group of items in an order that are to 
be fulfilled from the same location. There can be more than one fulfillment order for an order at a given location.

> **TODO**
> - [ ] Cancel a fulfillment order
> - [ ] Mark a fulfillment order as incomplete
> - [ ] Move a fulfillment order to a new location
> - [ ] Mark the fulfillment order as open
> - [ ] Reschedule the fulfill_at time of a scheduled fulfillment order
> - [ ] Retrieve a specific fulfillment order

### List Fulfillment Orders

Retrieves a list of fulfillment orders for a specific order

```c#
var service = new FulfillmentOrderService(myShopifyUrl, shopAccessToken);
var fulfillmentOrders = await service.ListAsync(orderId);
```

---

## Fulfillment Requests

The FulfillmentRequest resource represents a fulfillment request made by the merchant to a 
fulfillment service for a fulfillment order.

### Create A Fulfillment Request

Sends a fulfillment request to the fulfillment service of a fulfillment order

```c#
var service = new FulfillmentRequestService(myShopifyUrl, shopAccessToken);

// Optionally, you can request only specific item to fulfilled.
var fulfillmentRequest = new FulfillmentRequest()
{
    FulfillmentRequestOrderLineItems = new List<FulfillmentRequestOrderLineItems>(){}
};
var fulfillmentOrder = await service.CreateAsync(fulfillmentOrderId, fulfillmentRequest);
```

### Accept A Fulfillment Request

Accepts a fulfillment request sent to a fulfillment service for a fulfillment order

```c#
var service = new FulfillmentRequestService(myShopifyUrl, shopAccessToken);
var fulfillmentOrder = await service.AcceptAsync(fulfillmentOrderId, "Your order will be filled shortly.");
```

### Reject A Fulfillment Request

Reject a fulfillment request sent to a fulfillment service for a fulfillment order

```c#
var service = new FulfillmentRequestService(myShopifyUrl, shopAccessToken);
var fulfillmentOrder = await service.AcceptAsync(fulfillmentOrderId, "Fulfillment services have been suspended for this store.");
```

---

## Fulfillment Services

A Fulfillment Service is a third party warehouse that prepares and ships orders on behalf of the store owner. 
Fulfillment services charge a fee to package and ship items and update product inventory levels. 
Some well known fulfillment services with Shopify integrations include: Amazon, Shipwire, and Rakuten. 
When an app registers a new FulfillmentService on a store, Shopify automatically creates a Location 
that's associated to that fulfillment service.

### Create a Fulfillment Service

```c#
var service = new FulfillmentServiceService(myShopifyUrl, shopAccessToken);
var fulfillmentService = await service.CreateAsync(new FulfillmentServiceEntity()
{
    Name = "Your Company Name", 
    CallbackUrl = "http://yourcompany.com", 
    InventoryManagement = true,
    TrackingSupport = true,
    FulfillmentOrdersOptIn = true,
    RequiresShippingMethod = true, 
    Format = "json"
});
```

### List Fulfillment Services

Retrieves a list of fulfillment orders for a specific order

```c#
var service = new FulfillmentServiceService(myShopifyUrl, shopAccessToken);
// Optional Filter
var filter = new FulfillmentServiceListFilter(){ Scope = "all"};
var fulfillmentServices = await service.ListAsync(filter);
```

### Get a Fulfillment Service

Retrieves a single Fulfillment Service

```c#
var service = new FulfillmentServiceService(myShopifyUrl, shopAccessToken);
// Optional Filter
var fields = "id,name,email";
var fulfillmentService = await service.GetAsync(fulfillmentServiceId, fields);
```

### Modify a Fulfillment Service

Update a Fulfillment Service. Not all fields are updatable

```c#
var service = new FulfillmentServiceService(myShopifyUrl, shopAccessToken);
var fulfillmentService = await service.UpdateAsync(fulfillmentServiceId, fulfillmentServiceEntity);
```

### Delete a Fulfillment Service

```c#
var service = new FulfillmentServiceService(myShopifyUrl, shopAccessToken);
var fulfillmentService = await service.DeleteAsync(fulfillmentServiceId);
```

---

## Transactions

Transactions are created for every order that results in an exchange of money. All transactions are tied to a single order.

### Creating a full capture transaction

By omitting an `Amount` value, this transaction will capture the full amount.

**Note**: to create a `Capture` transaction, the order must have an `Authorization` transaction on it. However, an `Authorization` transaction can only be created at the time the order was created.

```cs
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transaction = new Transaction()
{
    Kind = "capture"
};

await service.CreateAsync(orderId, transaction);
```

### Creating a partial capture transaction

This method will capture a specified amount on a previously authorized order.

**Note**: to create a `Capture` transaction, the order must have an `Authorization` transaction on it. However, an `Authorization` transaction can only be created at the time the order was created.

```cs
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transaction = new Transaction()
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
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transaction = new Transaction()
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
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transaction = new Transaction()
{
    Kind = "void"
};

//Throws an error.
await service.CreateAsync(orderId, transaction);
```

### Getting a transaction

```cs
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transaction = await service.GetAsync(orderId, transactionId);
```

### Counting transactions

```cs
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(orderId);
```

### Listing transactions

```cs
var service = new TransactionService(myShopifyUrl, shopAccessToken);
var transactions = await service.ListAsync(orderId);

//Optionally filter the list to those after the given id
var transactions = await service.ListAsync(orderId, sinceId);
```

## Pages

A `Page` represents a web page on the merchant's Shopify storefront.

### Creating a page

```cs
var service = new PageService(myShopifyUrl, shopAccessToken);
var page = new Page()
{
    CreatedAt = DateTime.UtcNow,
    Title = "Burton Custom Freestlye 151",
    BodyHtml = "<strong>Good snowboard!</strong>",
};

page = await service.CreateAsync(page);
```

### Counting a page

```cs
var service = new PageService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing pages

```cs
var service = new PageService(myShopifyUrl, shopAccessToken);
var pages = await service.ListAsync();
```

### Retrieving a page

```cs
var service = new PageService(myShopifyUrl, shopAccessToken);
var page = await service.GetAsync(pageId);
```

### Updating a page

```cs
var service = new PageService(myShopifyUrl, shopAccessToken);
var page = await service.UpdateAsync(pageId, new Page()
{
    Title = "My new page title"
});
```

### Deleting a page

```c#
var service = new PageService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(pageId);
```

## Metafields

### Creating a metafield

```cs
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = new MetaField()
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
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId, "products");
```

### Listing metafields

```cs
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
var metafields = await service.ListAsync(productId, "products");
```

### Getting a metafield

```cs
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = await service.GetAsync(metafieldId);
```

### Updating a metafield

```cs
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
var metafield = await service.UpdateAsync(metafieldId, new MetaField()
{
    Value = "45"
});
```

### Deleting a metafield

```cs
var service = new MetaFieldService(myShopifyUrl, shopAccessToken);
await service.DeleteAsync(metafieldId);
```

## Custom Collections

A custom collection is a grouping of products that a shop owner can create to make their shops easier to browse. A shop owner creates a custom collection and then selects the products that will go into it.

### Creating a custom collection

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.CreateAsync(new CustomCollection()
{
    Title = "My Custom Collection",
    Published = true,
    PublishedAt = DateTime.UtcNow,
    Image = new CustomCollectionImage()
    {
        Src = "https://placekitten.com/250/250"
    }
});
```

### Getting a custom collection

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.GetAsync(collectionId);
```

### Counting custom collections

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing custom collections

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);
var collections = await service.ListAsync();
```

### Updating a custom collection

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.UpdateAsync(collectionId, new Collection()
{
    Title = "My new collection title"
});
```

### Deleting a custom collection

```cs
var service = new CustomCollectionService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(collectionId);
```

## Product Images

Product Images represent the various different images for a product. All product images are tied to an owner product, and therefore you'll need to pass that product's id to each product image method.

### Creating a product image

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.CreateAsync(productId, new ProductImage()
{
    Metafields = new List<MetaField>()
    {
        new MetaField()
        {
            Key = "alt",
            Value = "new alt tag content",
            ValueType = "string",
            Namespace = "tags"
        }
    },
    Src = "https://placekitten.com/200/300"
});
```

### Getting a product image

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.GetAsync(productId, imageId);
```

### Counting product images

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId);
```

### Listing product images

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);
var images = await service.ListAsync(productId);
```

### Updating a product image

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);
var image = await service.UpdateAsync(productId, imageId, new Image()
{
    Position = 2
});
```

### Deleting a product image

```cs
var service = new ProductImageService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId, imageId);
```

## Locations

A Location represents a geographical location where your stores, headquarters, and/or pop-up shops exist. These locations can be used to track sales and to help Shopify configure the tax rates to charge when selling products.

### Listing locations

```cs
var service = new LocationService(myShopifyUrl, shopAccessToken);
var locations = await service.ListAsync();
```

### Getting a location

```cs
var service = new LocationService(myShopifyUrl, shopAccessToken);
var location = await service.GetAsync(locationId);
```

## Events

Events are generated by specific Shopify resources when specific things happen, such as the creation of an article, the placement or fulfillment of an order, the addition or deletion of a product, and so on. By requesting events, your app can get a "log" of important occurrences in the operation of a shop.

**Caution:** the events returned by the Events API should not be considered to be realtime. Events might not appear in the list returned by the API until a few seconds after they've occurred. In rare cases (<1% of the time) it can take up to a few minutes for some events to appear.

### Counting events

```cs
var service = new EventService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Getting an event

```cs
var service = new EventService(myShopifyUrl, shopAccessToken);
var event = await service.GetAsync(eventId);
```

### Listing events

```cs
var service = new EventService(myShopifyUrl, shopAccessToken);
var events = await service.ListAsync();
```

### Listing events for a specific subject (e.g. Order or Product)

You can filter your event list result to only the events created by a specific "subject"; i.e. you can list all events for one specific Order, Product, Article, etc. When filtering events in this way, you must supply both the "subject" type _and_ its id.

Known subject types are 'Articles', 'Blogs', 'Custom_Collections', 'Comments', 'Orders', 'Pages', 'Products' and 'Smart_Collections'. A current list of subject types can be found at [https://help.shopify.com/api/reference/event](https://help.shopify.com/api/reference/event).

```cs
var service = new EventService(myShopifyUrl, shopAccessToken);
var subjectType = "Order";
var orderEvents = await service.ListAsync(orderId, subjectType);
```

## Order Risks

The Order risk assessment is used to indicate to a merchant the fraud checks that have been done on an order.

### Create an Order Risk

```cs
var service = new OrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.CreateAsync(orderId, new OrderRisk()
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
var service = new OrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.GetAsync(orderId, riskId);
```

### Update an Order Risk

```cs
var service = new OrderRiskService(myShopifyUrl, shopAccessToken);
var risk = await service.UpdateAsync(orderId, riskId, new Risk()
{
    Message = "An updated risk message"
});
```

### List Order Risks

```cs
var service = new OrderRiskService(myShopifyUrl, shopAccessToken);
var risks = await service.ListAsync(orderId);
```

### Delete an Order Risk

```cs
var service = new OrderRiskService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId, riskId);
```

## Smart Collections

A smart collection is a grouping of products defined by simple rules set by shop owners. A shop owner creates a smart collection and then sets the rules that determine which products go in them. Shopify automatically changes the contents of smart collections based on their rules.

### Creating a Smart Collection

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.CreateAsync(new SmartCollection()
{
   Title = "My Smart Collection",
   Handle = "my-url-slug",
   BodyHtml = "\<h1\>Hello world!\</h1\>",
   Image = new SmartCollectionImage()
   {
       // Base-64 image attachment
       Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
   }
});
```

### Updating a Smart Collection

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.UpdateAsync(smartCollectionId, new SmartCollection()
{
    Title = "My updated title"
});
```

### Getting a Smart Collection

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollection = await service.GetAsync(smartCollectionId);
```

### Counting Smart Collections

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Listing Smart Collections

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);
var smartCollections = await service.ListAsync();
```

### Deleting a Smart Collection

```cs
var service = new SmartCollectionService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(smartCollectionId);
```

## Product Variants

A product variant is a different version of a product, such as differing sizes or differing colors. Without product variants, you would have to treat the small, medium and large versions of a t-shirt as three separate products; product variants let you treat the small, medium and large versions of a t-shirt as variations of the same product.

### Creating a Product with a variant in one go

```cs
 var product = new Product()
 {
     Title = "Test Product Walter",
     Vendor = "Burton",
     BodyHtml = "<strong>Good snowboard!</strong>",
     ProductType = "Snowboard",
     Images = images,
     //Make sure to give your product the correct variant option
     Options = new List<ProductOption>
     {
         new ProductOption
         {
             Name = "Color"
         }
     },
     //And then create a collection of variants or assign the "Variants" property
     //to an already defined collection.
     Variants = new List<ProductVariant>
     {
         new ProductVariant
         {
             Option1 = "Black",
         },
         new ProductVariant
         {
             Option1 = "Green",
         },
     }
 };
```

### Creating a Product Variant

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.CreateAsync(productId, new ProductVariant()
{
    Option1 = "blue",
    Price = 123.45,
});
```

### Getting a Product Variant

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.GetAsync(variantId);
```

### Updating a Product Variant

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);
var variant = await service.UpdateAsync(variantId, new Variant()
{
    Price = 543.21
});
```

### Listing Product Variants

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);
var variants = await service.ListAsync(productId);
```

### Counting Product Variants

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(productId);
```

### Deleting a Product Variant

```cs
var service = new ProductVariantService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(productId, variantId);
```

## Blogs

In addition to an online storefront, Shopify shops come with a built-in blogging engine, allowing a shop to have one or more blogs. **This service is for interacting with blogs themselves, not [blog posts](#articles)**.

### Creating a Blogs

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);
var blog = await service.CreateAsync(new Blog()
{
    Title = "My new blog"
});
```

### Getting a Blog

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);
var blog = await service.GetAsync(blogId);
```

### Updating a Blog

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);
var blog = await service.UpdateAsync(blogId, new Blog()
{
    Comments = "moderate"
});
```

### Listing Blogs

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);
var blogs = await service.ListAsync();
```

### Counting Blogs

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Deleting a Blog

```cs
var service = new BlogService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(blogId);
```

## Articles

Articles are objects representing a blog post. Each article belongs to a [Blog](#blogs).

### Creating an Article

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
var article = await service.CreateAsync(blogId, new Article()
{
    Title = "My new Article title",
    Author = "John Smith",
    Tags = "This Post, Has Been Tagged",
    BodyHtml = "<h1>Hello world!</h1>",
    Image = new ArticleImage()
    {
        Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
    }
});
```

### Getting an Article

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
var article = await service.GetAsync(blogId, articleId);
```

### Updating an Article

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
var article = await service.UpdateAsync(blogId, articleId, new Article()
{
    Title = "My new title"
});
```

### Listing Articles

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
var articles = await service.ListAsync(blogId);
```

### Counting Articles

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync(blogId);
```

### Deleting an Article

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(blogId, articleId);
```

### Listing all Article authors

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
IEnumerable<string> authors = await service.ListAuthorsAsync();
```

### Listing all Article tags

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
IEnumerable<string> tags = await service.ListTagsAsync();
```

### Listing all Article tags for a single Blog

```cs
var service = new ArticleService(myShopifyUrl, shopAccessToken);
IEnumerable<string> tags = await service.ListTagsForBlogAsync(blogId);
```

## Application Credits

Shopify's Application Credit API lets you offer credits for payments your app customers have made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.

The total amount of all Application Credits created by an application must not exceed:

1. Total amount paid to the application by the shop owner in the last 30 days.
2. Total amount of pending receivables in the partner account associated with the application.

Additionally, Application Credits cannot be used by private applications.

### Creating an Application Credit

```cs
var service = new ApplicationCreditService(myShopifyUrl, shopAccessToken);
var credit = await service.CreateAsync(new ApplicationCredit()
{
    Description = "Refund for Foo",
    Amount = 10.00m
});
```

### Getting an Application Credit

```cs
var service = new ApplicationCreditService(myShopifyUrl, shopAccessToken);
var charge = await service.GetAsync(creditId);
```

### Listing Application Credits

```cs
var service = new ApplicationCreditService(myShopifyUrl, shopAccessToken);
var charges = await service.ListAsync();
```

## Discounts

Developers can create a discount code with the `DiscountService`. A merchant's customers can enter the discount code during the checkout process to redeem percentage-based, fixed amount, or free shipping discounts on a specific product, collection or order.

**Discounts require a Shopify Plus subscription.**

### Creating a Discount

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);
var discount = await service.CreateAsync(new Discount()
{
    DiscountType = "fixed_amount",
    Value = "10.00",
    DiscountCode = "AuntieDot",
    MinimumOrderAmount = "40.00",
});
```

### Getting a Discount

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);
var discount = await service.GetAsync(discountId):
```

### Listing Discounts

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);
var discounts = await service.ListAsync();
```

### Deleting a Discount

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(discountId);
```

### Disabling a Discount

Discount codes can be disabled via that API, which makes them inactive and unusable until reenabled.

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);

await service.DisableAsync(discountId);
```

### Enabling a Discount

Once disabled, a discount cannot be used by any customer until it's enabled.

```cs
var service = new DiscountService(myShopifyUrl, shopAccessToken);

await service.EnableAsync(discountId);
```

## Policies

Developers can get the list of policies that a merchant has configured for their store, such as their refund or privacy policies.

### Listing Policies

```cs
var service = new PolicyService(myShopifyUrl, shopAccessToken);
var policies = await service.ListAsync();
```

## Shipping Zones

Developers can get the list of shipping zones, their countries, provinces, and shipping rates.

### Listing Shipping Zones

```cs
var service = new ShippingZoneService(myShopifyUrl, shopAccessToken);
var shippingZones = await service.ListAsync();
```

## Gift Cards

Developers can create a gift card with the `GiftCardService`.

**Gift Cards require a Shopify Plus subscription.**

### Listing Gift Cards

```cs
var service = new GiftCardService(myShopifyUrl, shopAccessToken);
var giftCards = await service.ListAsync();
```

### Creating a Gift Card

```cs
var service = new GiftCardService(myShopifyUrl, shopAccessToken);
var giftCard = await service.CreateAsync(new GiftCard()
{
    InitialValue = 100,
    Code = "abc-bcd-efg"
});
```

### Getting a Gift Card

```cs
var service = new GiftCardService(myShopifyUrl, shopAccessToken);
var giftCard = await service.GetAsync(giftCardId):
```

### Disabling a Gift Card

Gift Cards can be disabled via that API, which makes them inactive and unusable until reenabled.

```cs
var service = new GiftCardService(myShopifyUrl, shopAccessToken);

await service.DisableAsync(discountId);
```

### Counting a Gift Cards

```c#
var service =  new GiftCardService(myShopifyUrl, shopAccessToken);
int giftCardCount = await service.CountAsync();
```

### Searching a Gift Cards

```c#
var service =  new GiftCardService(myShopifyUrl, shopAccessToken);
IEnumerable<GiftCard> giftCards = await Service.SearchAsync("code: abc-bcd-efg");
```

## Gift Card Adjustments

Developers can create adjustments on existing gift cards with the `GiftCardAdjustmentService`.

**Gift Cards require a Shopify Plus subscription and also the Gift Card Adjustment endpoint needs to be enabled on your store, contact Shopify plus support for more info.**

### Listing Gift Card Adjustments

```cs
var service = new GiftCardAdjustmentService(myShopifyUrl, shopAccessToken);
var giftCardAdjustments = await service.ListAsync(giftCardId);
```

### Creating a Gift Card Adjustment

```cs
var service = new GiftCardAdjustmentService(myShopifyUrl, shopAccessToken);
var giftCard = await service.CreateAsync(giftCardId, new GiftCardAdjustment()
{
    Amount = -1.00,
});
```

### Getting a Gift Card Adjustment

```cs
var service = new GiftCardAdjustmentService(myShopifyUrl, shopAccessToken);
var giftCardAdjustment = await service.GetAsync(giftCardId, adjustmentId):
```

## Price Rules

The Price Rules API allows you to dynamically create discounts with multiple conditions that can be applied at checkout to cart items or shipping lines via a discount code. Price rules can be created for a fixed value discount, a percentage discount, or a shipping line discount. You can also specify the dates for which the price rule is valid, the number of times the price rule can be applied, and to which products, collections, variants, customer groups and even shipping countries the price rule can be applied.

### Creating a Price Rule

```cs
var service = new PriceRuleService(myShopifyUrl, shopAccessToken);
var priceRule = await service.CreateAsync(new PriceRule()
{
    Title = "My price rule",
    ValueType = "percentage",
    TargetType = "line_item",
    TargetSelection = "all",
    AllocationMethod = "across",
    Value = -10.0m,
    CustomerSelection = "all",
    OncePerCustomer = false,
    PrerequisiteSubtotalRange = new PrerequisiteValueRange()
    {
        GreaterThanOrEqualTo = 40m
    },
    StartsAt = new DateTimeOffset(DateTime.Now)
});
```

### Updating a Price Rule

```cs
var service = new PriceRuleService(myShopifyUrl, shopAccessToken);
var updatedRule = await service.UpdateAsync(ruleId, new PriceRule()
{
    Value = -15.0m
});
```

### Getting a Price Rule

```cs
var service = new PriceRuleService(myShopifyUrl, shopAccessToken);
var priceRule = await service.GetAsync(ruleId);
```

### Listing Price Rules

```cs
var service = new PriceRuleService(myShopifyUrl, shopAccessToken);
var priceRules = await service.ListAsync();
```

### Deleting a Price Rule

```cs
var service = new PriceRuleService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(ruleId);
```

## Users

Developers can retrieve users with the `UserService`.

**The Users API requires a Shopify Plus subscription.**

### Listing Users

```cs
var service = new UserService(myShopifyUrl, shopAccessToken);
var users = await service.ListAsync();
```

### Getting a User

```cs
var service = new UserService(myShopifyUrl, shopAccessToken);
var user = await service.GetAsync(userId):
```

## Abandoned Checkouts

This is used to return abandoned checkouts. A checkout is considered abandoned when a customer has entered their billing & shipping info, but has yet to complete the purchase.

### Listing Abandoned Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkouts = await service.ListAsync();
```

### Count Abandoned Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

## Draft Orders

You can use the DraftOrder resource to allow merchants to create orders on behalf of customers. This is useful for Shopify merchants who receive orders through outside channels and enables a wide range of use cases including the following:

-   Create new orders for sales made by phone, in person, via chat, or by other means. Credit card payments for these orders can subsequently be entered in the Shopify admin.
-   Send invoices to customers to pay with a secure checkout link.
-   Use custom items to represent additional costs or products that aren't displayed in a shop's inventory.
-   Re-create mistaken orders.
-   Sell products at discount or wholesale rates.
-   Take pre-orders.

### Listing Draft Orders

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var draftOrders = await service.ListAsync();
```

### Counting Draft orders

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var count = await service.CountAsync();
```

### Getting a Draft Order

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var draftOrder = await service.GetAsync(draftOrderId);
```

### Create a Draft Order

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var draftOrder = await Service.CreateAsync(new DraftOrder()
{
    LineItems = new List<DraftLineItem>()
    {
        new DraftLineItem()
        {
            Title = "My custom line item",
            Price = 15.00m,
            Quantity = 1,
        }
    },
    Note = "Hello world!"
});
```

### Update a Draft Order

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var original = await Service.GetAsync(originalOrderId);
original.Note = "My new note";

var updated = await Service.UpdateAsync(originalOrderId, original);
```

### Delete a Draft Order

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(orderId);
```

### Send a Draft Order invoice

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
var invoice = await service.SendInvoiceAsync(new DraftOrderInvoice()
{
    To = "customer@example.com",
    Subject = "Your order is ready to pay",
    CustomMessage = "Please pay!"
});
```

### Complete a Draft Order

```cs
var service = new DraftOrderService(myShopifyUrl, shopAccessToken);
bool paymentPending = false;
var draftOrder = await service.CompleteAsync(orderId, paymentPending);
```

## Access Scopes

The Access Scope API allows you to retrieve the permissions that a merchant has granted to an app, such as `read_orders` and `write_products`. The list of access scopes is retrieved based on the access token used for the request, and only returns those scopes associated with the token.

### List Access Scopes

```cs
var service = new AccessScopeService(myShopifyUrl, shopAccessToken);
var scopes = await service.ListAsync();
```

## Checkouts

If you're building an app with the Sales Channel SDK, then you can use the Checkout API to let customers purchase products from Shopify stores that have installed your sales channel.

Shopify uses the Checkout resource to manage a user's cart as it transitions to a paid order. This process includes specifying which line items are included in the checkout, attaching a customer's shipping and payment details, and calculating tax and shipping rates. Credit card payments can be attached to a Checkout using the Payment resource.

### Create Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkout = await service.CreateAsync(new Checkout
{
    Email = "joshua@nozzlegear.com"
});
```

### Complete Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkoutToken = "token";
var checkout = await service.CompleteAsync(checkoutToken);
```

### Get Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkoutToken = "token";
var checkout = await service.GetAsync(checkoutToken);
```

### Updates Checkouts

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkoutToken = "token";
var checkout = await service.UpdateAsync(checkoutToken, new Checkout
{
    Email = "updated-email@nozzlegear.com"
});
```

### List Shipping Rates for Checkout

```cs
var service = new CheckoutService(myShopifyUrl, shopAccessToken);
var checkoutToken = "token";
var shippingRates = await service.ListShippingRatesAsync(checkoutToken);
```

## Collections

API version 2020-01 introduces the new "Collections" endpoint, which can be used to get the base details and list of products associated with either a [Custom Collection](#custom-collections) or [Smart Collection](#smart-collections). 

This endpoint **cannot** be used to manipulate the products, collects, custom collections or smart collections. You must use the entity's respective ShopifySharp service to do that (i.e. `CollectService`, `ProductService`, `CustomCollectionService` and `SmartCollectionService`).

### Getting a Collection

```cs
var service = new CollectionService(myShopifyUrl, shopAccessToken);
var collection = await service.GetAsync(collectionId);
```

### Listing products belonging to a Collection

```cs
var service = new CollectionService(myShopifyUrl, shopAccessToken);
var products = await service.ListAsync(collectionId);
```

## StorefrontAccessTokens

You can use the StorefrontAccessToken resource to generate storefront access tokens. Storefront access tokens are used to delegate unauthenticated access scopes to clients that need to access the unautheticated Storefront API. A sales channel can generate a storefront access token and then pass it to a consuming client, such as JavaScript or a mobile application.

**There is a hard limit of 100 tokens per Shopify store.**

### Creating a StorefrontAccessToken

To create a StorefrontAccessToken, you must pass in a title for the token. There are no constraints on the uniqueness of the title. 

```cs
var service = new StorefrontAccessTokenService(myShopifyUrl, shopAccessToken);
var token = await service.CreateAsync("My storefront access token");
```

### Deleting a StorefrontAccessToken

```cs
var service = new StorefrontAccessTokenService(myShopifyUrl, shopAccessToken);

await service.DeleteAsync(storefrontAccessTokenId);
```

### Listing StorefrontAccessTokens

This endpoint is not paginated, because there is a limit of only 100 storefront access tokens per shop.

```cs
var service = new StorefrontAccessTokenService(myShopifyUrl, shopAccessToken);
var list = await service.ListAsync();
```

## Multipass

Multipass login is for store owners who have a separate website and a Shopify store. It redirects users from the website to the Shopify store and seamlessly logs them in with the same email address they used to sign up for the original website. If no account with that email address exists yet, one is created. There is no need to synchronize any customer databases.

### Creating a Multipass redirect url

To create a multipass redirect url 

```cs
string url = MultipassService.GetMultipassUrl(
	new Customer() {
		Email = "test@example.com",
		MultipassIdentifier = Guid.Tostring(),
		CreatedAt = DateTimeOffset.Now
		....
	},
	Utils.MyShopifyUrl,
	Utils.AccessToken
);
```

# Handling Shopify's API rate limit

The Shopify API allows for an average of 2 API calls per second, with a burst limit of up to 40 API calls. Once you hit that 40 burst limit, Shopify will return a 429 Too Many Requests result. The limit is there to prevent you and thousands of other developers from overloading Shopify's servers by going hard in the paint with hundreds of requests every second. Unfortunately, it's pretty easy to write a `for` loop while trying to close a list of orders, and then start getting exceptions after closing the first 40.

By default, ShopifySharp will **not** retry requests that get throttled by the rate limit, and instead this package will throw a `ShopifyRateLimitException` that you can catch and decide to retry:

```cs
foreach (var order in listOfOrders)
{
	try
	{
		await orderService.CloseAsync(order.Id.Value);
	}
	catch (ShopifyRateLimitException e)
	{
		//Wait for 10 seconds before trying again.
		await Task.Delay(10000);

		//If this throws an exception again, loop will break and the exception will be thrown.
		await orderService.CloseAsync(order.Id.Value);
	}
}
```

However, ShopifySharp also has request execution policies that you can use to implement a retry strategy. Currently there are three execution policies bundled with the library:

1. `DefaultRequestExecutionPolicy`: This is the default policy, which will throw a `ShopifyRateLimitException` when the API rate limit has been reached.
2. `RetryExecutionPolicy`: If a request throws a `ShopifyRateLimitException`, this policy will keep retrying it until it is successful.
3. `SmartRetryExecutionPolicy`: This policy attempts to use a leaky bucket strategy by proactively limiting the number of requests that will result in a `ShopifyRateLimitException`. For example: if 100 requests are created in parallel, only 40 should be sent immediately, and the remaining 60 requests should be throttled at 1 per 500ms.

You have two different ways to set an execution policy. You can set a policy on a per-instance basis:

```cs
var service = new ProductService(myShoipfyUrl, accessToken);

service.SetExecutionPolicy(new RetryExecutionPolicy());
```

Or you can set a **global** execution policy:

```cs
ShopifyService.SetGlobalExecutionPolicy(new RetryExecutionPolicy());
```

Note that **instance-specific policies will always be used over global execution policies**. In addition, if you clear the instance-specific policy by passing `null`, **the instance will then switch over to the global execution policy**.

Keep in mind that the `RetryExecutionPolicy` and the `SmartRetryExecutionPolicy` will keep retrying your requests – potentially until the end of time – until they are successful. It's up to you to ensure that such a strategy won't impact the performance of your applications.

If you need a custom policy to do something more complicated or to e.g. implement request logging, you can create your own request policy that extends the `ShopifySharp.IRequestExecutionPolicy` interface. [Check here](https://github.com/nozzlegear/ShopifySharp/blob/master/ShopifySharp/Infrastructure/Policies/RetryExecutionPolicy.cs) for an example.

# Custom Filters

Occasionally we get requests to add certain properties to one of the List or Count filters that isn't documented anywhere by Shopify. For example, at one point it was possible to add a `name` prop to the `OrderFilter` that would make it possible to search for an `Order` by its name. Unfortunately this `name` filter was never documented and Shopify eventually removed that functionality, but it's a perfect example of wanting to use custom properties on the filters.

Officially, my stance is that I tend to favor not adding undocumented things to this package on the fear that it will someday break and I'll have a big headache fielding questions and issues here on GitHub when it does. However, in the case of Filters it's possible for you to implement your own custom filter without it being officially supported!

It's as easy as creating your own class that extends whichever filter your method accepts. For example, let's pretend that `name` search still works when listing Shopify orders, but this package doesn't support it. The `OrderService.ListAsync` method accepts an `OrderFilter` argument, so to get the `name` property sent along with the API call, all you need to do is create your own custom filter that extends `OrderFilter`:

```cs
public class MyCustomOrderFilter : OrderFilter
{
    [JsonProperty("name")] // This will serialize the value as `name` when sent to the API endpoint.
    public string Name { get; set; }
}
```

Your custom order filter still has all of the original properties of the base `OrderFilter` class, _plus_ it has your new `Name` property. Since your custom filter extends the class that `OrderService.ListAsync` was looking for, you can now pass it as an argument to that method without any problems:

```cs
var list = await orderService.ListAsync(new MyCustomOrderFilter()
{
    Name = "1001"
});
```

If you need even more fine-grained control over what gets sent through your custom filter, you can also override the `ToParameters` or `ToSingleParameter` methods of the filter. Those methods are called by the service when it's serializing the filter to a querystring.

[You can take a look at the `Parameterizable` class (which is used by all filters) for a look at the current implementation](https://github.com/nozzlegear/ShopifySharp/blob/85a0eed28937eee2870e9104a55796e1a1039cfb/ShopifySharp/Infrastructure/Parameterizable.cs#L18) and what you can do in those methods.

# "Why don't you use enums?"

I'm a big fan of using enums to make things easier for C# devs, because it removes a lot of the headache that comes with trying to remember all the valid string options for certain properties. With enums, we get those options hardcoded by default. We can easily scroll up and down the list of known values and select the one we need, without having to worry about typos.

Many Shopify objects have string properties that only accept a predetermined list of values, and these properties are perfect for matching to C# enums. Unfortunately, Shopify has a habit of only documenting the most used values and leaving the developer to guess the rest. On top of that, they sometimes change those enums completely, [such as this case where they changed the enums used for filtering orders without announcing it](https://github.com/nozzlegear/ShopifySharp/issues/64).

That's a problem when it comes to strongly-typed languages like C#. If you receive an enum property that doesn't have a value matching the enum, you're going to get a big fat exception thrown in your face. This is especially problematic when these undocumented enum values are sent to you automatically in webhooks.

On top of that, if there's an enum value that you need to send but isn't in ShopifySharp, you'll need to wait until a new version of the lib is released before you can use it.

Enums would be much better suited to ShopifySharp if Shopify themselves used API versioning, but sadly that isn't the case. After struggling with undocumented values and unannounced changes that break apps through two major releases of ShopifySharp, I've made the decision to pull the plug on almost all enums in the lib.

What were previously enums in ShopifySharp 1.x and 2.x are now string properties. This change will prevent breaking your app when an enum value changes, and will allow you to quickly update your app when a new enum value is released without waiting on an update to ShopifySharp first.

# Tests

The test suite relies on your own Shopify credentials, including your Shopify API key, a shop's \*.myshopify.com URL, and an access
token with full permissions for that shop. [This blog post](https://nozzlegear.com/blog/generating-shopify-authorization-credentials)
will show you exactly what you need to do to get a shop access token with full permissions.

Once you have those credentials you'll need to the following keys/values to your environment variables:

```
SHOPIFYSHARP_API_KEY = value

SHOPIFYSHARP_SECRET_KEY = value

SHOPIFYSHARP_ACCESS_TOKEN = value

SHOPIFYSHARP_MULTIPASS_SECRET = value

SHOPIFYSHARP_MY_SHOPIFY_URL = value
```

**New features will not be published until they have test coverage**. If you'd like your pull request to be published, make sure you write tests for it!

ShopifySharp is now using [xUnit](https://xunit.github.io/) for tests. New tests should all follow the format of other tests in 4.0. You can use the [Article](https://github.com/nozzlegear/ShopifySharp/blob/master/ShopifySharp.Tests/Article_Tests.cs) test as an example, **but I would highly recommend that you [use the provided ShopifySharp Test snippet in the VSCode folder instead](https://github.com/nozzlegear/ShopifySharp/blob/master/.vscode/snippets.csharp.json)**. Create a new `*_Tests.cs` file and type `test-shopifysharp` in VSCode:

![shopifysharp-test](https://cloud.githubusercontent.com/assets/2417276/25457929/94bc71dc-2a9d-11e7-80ac-72352715504e.gif)
