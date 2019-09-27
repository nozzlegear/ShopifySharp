namespace ShopifySharp.Experimental

open System.Net.Http
open ShopifySharp
open ShopifySharp.Infrastructure

module Webhooks = 
    type WebhookProperty = 
        | Address 
        | Fields 
        | Format 
        | MetafieldNamespaces 
        | Topic 
    with 
        member x.RawJsonName = 
            match x with 
            | Address -> "address"
            | Fields -> "fields"
            | Format -> "format"
            | MetafieldNamespaces -> "metafield_namespaces"
            | Topic -> "topic"

    type WebhookProperties = Map<WebhookProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: WebhookProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties: WebhookProperties): WebhookProperties = 
        properties |> Map.add name value 

    /// <summary>
    /// Begins building a new webhook dictionary which can be serialized to JSON.
    /// `let myWebhook = newWebhook |> address "https://example.com" |> topic "app/uninstalled" |> format "json"`
    /// </summary>
    let newWebhook : WebhookProperties = 
        Map.empty
        
    let address =
        JsonValue.String >> add Address
        
    let fields (x: string seq) =
        Seq.map JsonValue.String x
        |> JsonValue.Array
        |> add Fields
        
    let format =
        JsonValue.String >> add Format
        
    let metafieldNamespaces (x: string seq) =
        Seq.map JsonValue.String x
        |> JsonValue.Array
        |> add MetafieldNamespaces
        
    let topic =
        JsonValue.String >> add Topic
        
    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull topic = 
        add topic JsonValue.Null
        
    /// <summary>
    /// Removes a property entirely when the webhook is serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty topic : WebhookProperties -> WebhookProperties = 
        Map.remove topic
        
    let inline private (=>) a b = a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects

    // Extend the base ShopifySharp.WebhookService to include methods for creating/updating webhooks.
    type Service(shopDomain: string, accessToken: string, ?policy: IRequestExecutionPolicy) = 
        inherit WebhookService (shopDomain, accessToken)
        
        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p
        
        member x.CreateAsync (webhook: WebhookProperties) =
            let req = base.PrepareRequest "webhooks.json"
            let data = dict [ "webhook" => webhook ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<Webhook>(req, HttpMethod.Post, content, "webhook")
            
        member x.UpdateAsync (id: int64) (webhook: WebhookProperties) =
            let req = base.PrepareRequest (sprintf "webhooks/%i.json" id)
            let data = dict [ "webhook" => webhook ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<Webhook>(req, HttpMethod.Put, content, "webhook")

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
