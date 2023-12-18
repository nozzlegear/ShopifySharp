namespace ShopifySharp.Experimental

open System.Net.Http
open System.Threading
open ShopifySharp
open ShopifySharp.Infrastructure

module ScriptTags =
    type ScriptTagProperty =
        | DisplayScope
        | Event
        | Src 
    with
        member x.RawJsonName =
            match x with
            | DisplayScope -> "display_scope"
            | Event -> "event"
            | Src -> "src"
            
    type ScriptTagEvent =
        | OnLoad
    with
        member x.RawJsonName =
            match x with
            | OnLoad -> "onload"
            
    type ScriptTagDisplayScope =
        | OnlineStore
        | OrderStatus
        | All
    with
        member x.RawJsonName =
            match x with
            | OnlineStore -> "online_store"
            | OrderStatus -> "order_status"
            | All -> "all"
            
    type ScriptTagProperties = Map<ScriptTagProperty, JsonValue>
    
    let toRawPropertyNames (properties : ScriptTagProperties) =
        properties
        |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties : ScriptTagProperties) : ScriptTagProperties =
        properties
        |> Map.add name value
        
    /// Begins building a new script tag dictionary which can be serialized to JSON.
    /// `let myScriptTag = newScriptTag |> src "https://example.com" |> event OnLoad`
    let newScriptTag : ScriptTagProperties =
        Map.empty
        
    /// Explicitly sets the value of a property to null when serialized to JSON.
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    let removeProperty property : ScriptTagProperties -> ScriptTagProperties =
        Map.remove property
        
    let src (x : string) =
        JsonValue.String x |> add Src
        
    let event (x : ScriptTagEvent) =
        JsonValue.String x.RawJsonName |> add Event
        
    let displayScope (x : ScriptTagDisplayScope) =
        JsonValue.String x.RawJsonName |> add DisplayScope

    let inline private (=>) a b =
        a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects
        
    // Extend the base ShopifySharp.ScriptTagService to include methods for creating/updating with property dictionaries.
    type Service(shopDomain : string, accessToken : string, ?policy : IRequestExecutionPolicy) =
        inherit ScriptTagService (shopDomain, accessToken)

        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p

        member x.CreateAsync (tag : ScriptTagProperties) =
            let req = base.BuildRequestUri("script_tags.json")
            let data = dict [ "script_tag" => tag ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Post, CancellationToken.None, content, "script_tag")
            |> mapTask (_.Result)
            
        member x.UpdateAsync (id : int64, tag : ScriptTagProperties) =
            let req = base.BuildRequestUri($"script_tags/{id}.json")
            let data = dict [ "script_tag" => tag ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Put, CancellationToken.None, content, "script_tag")
            |> mapTask (_.Result)

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
