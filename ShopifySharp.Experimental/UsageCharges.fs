namespace ShopifySharp.Experimental

open System.Net.Http
open ShopifySharp
open ShopifySharp.Infrastructure

module UsageCharges = 
    type UsageChargeProperty =
        | Description
        | Price
    with
        member x.RawJsonName =
            match x with
            | Description -> "description"
            | Price -> "price"
            
    type UsageChargeProperties = Map<UsageChargeProperty, JsonValue>
    
    let toRawPropertyNames (properties : UsageChargeProperties) =
        properties
        |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties : UsageChargeProperties) : UsageChargeProperties =
        properties
        |> Map.add name value
        
    /// Begins building a new usage charge dictionary which can be serialized to JSON.
    /// `let myCharge = newUsageCharge |> description "Used 5 Foos" |> price 15.00M`
    let newUsageCharge : UsageChargeProperties =
        Map.empty
        
    /// Explicitly sets the value of a property to null when serialized to JSON.
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    let removeProperty property : UsageChargeProperties -> UsageChargeProperties =
        Map.remove property
        
    let description = JsonValue.String >> add Description
    
    let price = JsonValue.Decimal >> add Price
    
    let inline private (=>) a b =
        a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects
        
    // Extend the base ShopifySharp.UsageChargeService to include methods for creating/updating with property dictionaries.
    type Service(shopDomain : string, accessToken : string, ?policy : IRequestExecutionPolicy) =
        inherit UsageChargeService (shopDomain, accessToken)

        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p

        member x.CreateAsync (recurringChargeId : int64, data : UsageChargeProperties) =
            let req = base.PrepareRequest (sprintf "recurring_application_charges/%i/usage_charges.json" recurringChargeId)
            let data = dict [ "usage_charge" => data ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<UsageCharge>(req, HttpMethod.Post, content, "usage_charge")

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
