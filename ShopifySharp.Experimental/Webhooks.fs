namespace ShopifySharp.Experimental

open System.Collections.Generic
open System.Net.Http
open ShopifySharp
open FSharp.Control.Tasks.V2.ContextInsensitive
open ShopifySharp.Infrastructure

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

    // Extend the base ShopifySharp.WebhookService to include methods for creating/updating webhooks.
    type Service(shopDomain: string, accessToken: string, ?policy: IRequestExecutionPolicy) = 
        inherit WebhookService (shopDomain, accessToken)
        
        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p
        
        /// Serializes the map of properties to a `Map<string, obj>`, which ShopifySharp can then serialize to JSON.
        let mapToDictionary properties =
            let rec nextProperty (list: (WebhookProperty * obj option) list) (output: Map<string, obj>)  = 
                match list with 
                | [] -> output
                | (key, value) :: rest -> 
                    let value = value |> Option.defaultValue (box null)
                    Map.add (key.ToJsonName) (value) output 
                    |> nextProperty rest

            nextProperty (Map.toList properties) Map.empty
        
        member x.CreateAsync (webhook: WebhookProperties) =
            let req = base.PrepareRequest "webhooks.json"
            let data = dict [ "webhook", mapToDictionary webhook ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<Webhook>(req, HttpMethod.Post, content, "webhook")
            
        member x.UpdateAsync (id: int64) (webhook: WebhookProperties) =
            let req = base.PrepareRequest (sprintf "webhooks/%i.json" id)
            let data = dict [ "webhook", mapToDictionary webhook ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<Webhook>(req, HttpMethod.Put, content, "webhook")

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
