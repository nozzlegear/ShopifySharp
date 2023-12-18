namespace ShopifySharp.Experimental

open System.Net.Http
open System.Threading
open ShopifySharp
open ShopifySharp.Infrastructure

module RecurringCharges = 
    type RecurringChargeProperty =
        | CappedAmount
        | Name
        | Price
        | ReturnUrl
        | Terms
        | Test
        | TrialDays
    with
        member x.RawJsonName =
            match x with
            | CappedAmount -> "capped_amount"
            | Name -> "name"
            | Price -> "price"
            | ReturnUrl -> "return_url"
            | Terms -> "terms"
            | Test -> "test"
            | TrialDays -> "trial_days"
 
    type RecurringChargeProperties = Map<RecurringChargeProperty, JsonValue>
    
    let toRawPropertyNames (properties : RecurringChargeProperties) =
        properties
        |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties : RecurringChargeProperties) : RecurringChargeProperties =
        properties
        |> Map.add name value
        
    /// Begins building a new recurring charge dictionary which can be serialized to JSON.
    /// `let myCharge = newRecurringCharge |> name "Super Cool Monthly Charge" |> price 15.00M |> trialDays 15`
    let newRecurringCharge : RecurringChargeProperties =
        Map.empty
        
    /// Explicitly sets the value of a property to null when serialized to JSON.
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    let removeProperty property : RecurringChargeProperties -> RecurringChargeProperties =
        Map.remove property
        
    let cappedAmount = JsonValue.Decimal >> add CappedAmount
    
    let name = JsonValue.String >> add Name
    
    let price = JsonValue.Decimal >> add Price
    
    let returnUrl = JsonValue.String >> add ReturnUrl
    
    let terms = JsonValue.String >> add Terms
    
    let test = JsonValue.Bool >> add Test
    
    let trialDays = JsonValue.Int >> add TrialDays
    
    let inline private (=>) a b =
        a, toRawPropertyNames b |> JsonValue.MapPropertyValuesToObjects
        
    // Extend the base ShopifySharp.RecurringChargeService to include methods for creating/updating with property dictionaries.
    type Service(shopDomain : string, accessToken : string, ?policy : IRequestExecutionPolicy) =
        inherit RecurringChargeService (shopDomain, accessToken)

        // Set the execution policy if one was given
        do match policy with | None -> (); | Some p -> base.SetExecutionPolicy p

        member x.CreateAsync (data : RecurringChargeProperties) =
            let req = base.BuildRequestUri("recurring_application_charges.json")
            let data = dict [ "recurring_application_charge" => data ]
            let content = new JsonContent(data)
            base.ExecuteRequestAsync<RecurringCharge>(req, HttpMethod.Post, CancellationToken.None, content, "recurring_application_charge")
            |> mapTask (_.Result)

        static member NewService domain accessToken = Service(domain, accessToken)
        static member NewServiceWithPolicy domain accessToken policy = Service(domain, accessToken, policy)
