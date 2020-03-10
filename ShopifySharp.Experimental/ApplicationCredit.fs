namespace ShopifySharp.Experimental

open System.Net.Http
open System.Threading
open ShopifySharp
open ShopifySharp.Infrastructure

module ApplicationCredits = 
    type ApplicationCreditProperty =
        | Description
        | Amount
        | Test 
    with
        member x.RawJsonName =
            match x with
            | Description -> "description"
            | Amount -> "amount"
            | Test -> "test"
            
    type ApplicationCreditProperties = Map<ApplicationCreditProperty, JsonValue>
    
    let toRawPropertyNames (properties : ApplicationCreditProperties) =
        properties
        |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties : ApplicationCreditProperties) : ApplicationCreditProperties =
        properties
        |> Map.add name value
        
    /// Begins building a new application credit dictionary which can be serialized to JSON.
    /// `let myCredit = newApplicationCredit |> description "Refund for XYZ" |> amount 15.00M |> test false`
    let newApplicationCredit : ApplicationCreditProperties =
        Map.empty
        
    /// Explicitly sets the value of a property to null when serialized to JSON.
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    let removeProperty property : ApplicationCreditProperties -> ApplicationCreditProperties =
        Map.remove property
        
    /// The description of the application credit.
    let description = JsonValue.String >> add Description
    
    /// The amount refunded by the application credit.
    let amount = JsonValue.Decimal >> add Amount
    
    /// Whether or not the application credit is a test transaction
    let test = JsonValue.Bool >> add Test 
    
    let inline private (=>) a b =
        a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects
        
    // Extend the base ShopifySharp.ApplicationCreditService to include methods for creating/updating with property dictionaries.
    type Service(shopDomain : string, accessToken : string, ?policy : IRequestExecutionPolicy) =
        inherit ApplicationCreditService (shopDomain, accessToken)

        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p

        member x.CreateAsync (data : ApplicationCreditProperties) =
            let req = base.PrepareRequest "application_credits.json"
            let data = dict [ "application_credit" => data ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<ApplicationCredit>(req, HttpMethod.Post, CancellationToken.None, content, "usage_charge")
            |> mapTask (fun response -> response.Result)

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
