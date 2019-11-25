namespace ShopifySharp.Experimental

module TaxLines =
    type TaxLineProperty =
         | Price
         | Rate
         | Title
    with
        member x.RawJsonName =
            match x with
            | Price -> "price"
            | Rate -> "rate"
            | Title -> "title"
    
    type TaxLineProperties = Map<TaxLineProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: TaxLineProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties: TaxLineProperties): TaxLineProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new tax line dictionary which can be serialized to JSON.
    /// `let myTaxLine = newTaxLine |> price 11.94M |> rate 0.06M |> title "State Tax"`
    /// </summary>
    let newTaxLine: TaxLineProperties =
        Map.empty

    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null
    
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : TaxLineProperties -> TaxLineProperties =
        Map.remove property
        
    let price (x: decimal) =
        JsonValue.Decimal x |> add Price
        
    let rate (x: decimal) =
        JsonValue.Decimal x |> add Rate
        
    let title (x: string) =
        JsonValue.String x |> add Title 
