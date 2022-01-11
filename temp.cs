// Note: need to use double curly brackets or else String.Format will get confused and throw an exception
var mutation = @"
    mutation {{
        appSubscriptionCreate(
            name: "{0}"
            returnUrl: "{1}"
            lineItems: [
            {{
                plan: {{
                    appRecurringPricingDetails: {{
                        price: {{ 
                            amount: {2}, 
                            currencyCode: USD 
                        }}
                        interval: ANNUAL
                    }}
                }}
            }}
            ]
        ) {{
            appSubscription {{
                id
            }}
            confirmationUrl
            userErrors {{
                field
                message
            }}
        }}
    }}";

// Format the mutation with your variables
mutation = String.Format(mutation, "My plan name", "https://example.com/return-url", 10.00m);

// Create the subscription
var service = new ShopifySharp.GraphService(shopifyShopDomain, accessToken);
var response = await service.PostAsync(mutation);

// Check for errors
var userErrors = response.Item("userErrors");

if (userErrors != null)
{
    // TODO: handle error here
    var field = userErrors.Value<string>("field");
    var message = userErrors.Value<string>("message");

    throw new Exception("Could not create annual subscription. Shopify returned error '" + field + "': " + message);
}

// Get the subscription id and the confirmation url
var appSubscription = response.Item("appSubscription");
// Graph IDs are strings
string subscriptionId = appSubscription.Value<string>("id");
string confirmationUrl = response.Value<string>("confirmationUrl");

// Redirect your user to the confirmation url
return Redirect(confirmationUrl);
