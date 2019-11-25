namespace ShopifySharp.Experimental
open System.Collections.Generic

module OrderLineItems =
    type OrderLineItemProperty =
        | Grams
        | Price
        | Quantity
        | Properties 
        | TaxLines
        | Title
        | Taxable
        | VariantId
    with
        member x.RawJsonName =
            match x with
            | Grams -> "grams"
            | Price -> "price"
            | Quantity -> "quantity"
            | Properties -> "properties"
            | TaxLines -> "tax_lines"
            | Title -> "title"
            | Taxable -> "taxable"
            | VariantId -> "variant_id"
            
    type OrderLineItemProperties = Map<OrderLineItemProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: OrderLineItemProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
    
    let private add name value (properties: OrderLineItemProperties): OrderLineItemProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new line item dictionary which can be serialized to JSON.
    /// `let myLineItem = newLineItem |> grams 600 |> price 99.99M |> title "Clicky keyboard"`
    /// </summary>
    let newLineItem: OrderLineItemProperties =
        Map.empty

    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : OrderLineItemProperties -> OrderLineItemProperties =
        Map.remove property
        
    let grams (x: int) =
        JsonValue.Int x |> add Grams
        
    let price (x: decimal) =
        JsonValue.Decimal x |> add Price
        
    let quantity (x: int) =
        JsonValue.Int x |> add Quantity
        
    let properties (x: KeyValuePair<string, string> seq) =
        let toMap (x: KeyValuePair<string, string>) =
            Map [
                "name", JsonValue.String x.Key
                "value", JsonValue.String x.Value
            ]

        Seq.map (toMap >> JsonValue.Dictionary) x            
        |> JsonValue.Array
        |> add Properties
        
    let taxLines (x: ShopifySharp.Experimental.TaxLines.TaxLineProperties seq) =
        Seq.map (ShopifySharp.Experimental.TaxLines.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add TaxLines 
        
    let title (x: string) =
        JsonValue.String x |> add Title
        
    let taxable (x: bool) =
        JsonValue.Bool x |> add Taxable
        
    let variantId (x: int64) =
        JsonValue.Int64 x |> add VariantId 
