namespace ShopifySharp.Experimental

module Webhooks = 
    type WebhookProperty = 
        | Address 
        | Fields 
        | Format 
        | MetafieldNamespaces 
        | Topic 
    with 
        member x.ToJsonName = 
            match x with 
            | Address -> "address"
            | Fields -> "fields"
            | Format -> "format"
            | MetafieldNamespaces -> "metafield_namespaces"
            | Topic -> "topic"

    type private WebhookProperties = Map<WebhookProperty, obj option>

    let private add name value (properties: WebhookProperties): WebhookProperties = 
        properties
        |> Map.add name value 

    /// <summary>
    /// Begins building a new webhook dictionary which can be serialized to JSON.
    /// `let myWebhook = newWebhook |> address "https://example.com" |> topic "app/uninstalled" |> format "json"`
    /// </summary>
    let newWebhook : WebhookProperties = 
        Map.empty
    let address (s: string) = 
        Some (box s) |> add Address
    let fields (s: string seq) = 
        Some (box s) |> add Fields
    let format (s: string) = 
        Some (box s) |> add Format 
    let metafieldNamespaces (s: string seq) = 
        Some (box s) |> add MetafieldNamespaces
    let topic (s: string) = 
        Some (box s) |> add Topic
    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull topic = 
        add topic None
    /// <summary>
    /// Removes a property entirely when the webhook is serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty topic : WebhookProperties -> WebhookProperties = 
        Map.remove topic