namespace ShopifySharp.Experimental

open System.Net.Http
open System.Threading
open ShopifySharp
open ShopifySharp.Infrastructure

module Charges = 
    type ChargeProperty =
        | Name
        | Price
        | ReturnUrl
        | Test
    with
        member x.RawJsonName =
            match x with
            | Name -> "name"
            | Price -> "price"
            | ReturnUrl -> "return_url"
            | Test -> "test"
        
    type ChargeProperties = Map<ChargeProperty, JsonValue>
    
    let toRawPropertyNames (properties : ChargeProperties) =
        properties
        |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties : ChargeProperties) : ChargeProperties =
        properties
        |> Map.add name value
        
    /// Begins building a new charge dictionary which can be serialized to JSON.
    /// `let myCharge = newCharge |> name "Super Cool Charge" |> price 15.00M`
    let newCharge : ChargeProperties =
        Map.empty
        
    /// Explicitly sets the value of a property to null when serialized to JSON.
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    let removeProperty property : ChargeProperties -> ChargeProperties =
        Map.remove property

    let name = JsonValue.String >> add Name 
        
    let price = JsonValue.Decimal >> add Price
        
    let returnUrl = JsonValue.String >> add ReturnUrl 
        
    let test = JsonValue.Bool >> add Test
    
    let inline private (=>) a b =
        a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects
        
    // Extend the base ShopifySharp.ChargeService to include methods for creating/updating with property dictionaries.
    type Service(shopDomain : string, accessToken : string, ?policy : IRequestExecutionPolicy) =
        inherit ChargeService (shopDomain, accessToken)

        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p

        member x.CreateAsync (data : ChargeProperties) =
            let req = base.BuildRequestUri("application_charges.json")
            let data = dict [ "application_charge" => data ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<Charge>(req, HttpMethod.Post, CancellationToken.None, content, "application_charge")
            |> mapTask (_.Result)

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
