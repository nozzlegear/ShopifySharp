namespace ShopifySharp.Experimental

open ShopifySharp

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
        let baseService = WebhookService(shopDomain, accessToken)

        do Option.iter (fun p -> baseService.SetExecutionPolicy p) policy
        
        /// <summary>
        /// Serializes the map of <see cref="WebhookProperty" /> to a JSON string.
        /// </summary>
        let mapToJson (map: WebhookProperties) = 
            let rec nextProperty (list: (WebhookProperty * obj option) list) (output: Map<string, obj>)  = 
                match list with 
                | [] -> ShopifySharp.Infrastructure.Serializer.Serialize output
                | (key, value) :: rest -> 
                    let value = value |> Option.defaultValue (box null)
                    Map.add (key.ToJsonName) (value) output 
                    |> nextProperty rest

            nextProperty (Map.toList map) (Map.empty)

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
        member x.APIVersion = baseService.APIVersion 
        member x.SetExecutionPolicy = baseService.SetExecutionPolicy
        member x.Count = baseService.CountAsync >> Async.AwaitTask
        member x.List = baseService.ListAsync >> Async.AwaitTask
        member x.Delete = baseService.DeleteAsync >> Async.AwaitTask
        member x.Create webhook =
            let json = mapToJson webhook 
            failwith "Not implemented"
        member x.Update webhook = 
            let json = mapToJson webhook 
            failwith "Not implemented"
