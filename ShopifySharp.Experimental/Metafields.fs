namespace ShopifySharp.Experimental

module Metafields =
    type MetafieldProperty =
        | Key
        | Value
        | ValueType
        | Namespace
        | Description
    with
        member x.RawJsonName =
            match x with
            | Key -> "key"
            | Value -> "value"
            | ValueType -> "value_type"
            | Namespace -> "namespace"
            | Description -> "description"
    
    type MetafieldValueType =
        | String
        | Integer 
    with
        member x.RawJsonName =
            match x with
            | String -> "string"
            | Integer -> "integer"
    
    type MetafieldValue =
        | String of string
        | Integer of int
        
    type MetafieldProperties = Map<MetafieldProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: MetafieldProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
    
    let private add name value (properties: MetafieldProperties): MetafieldProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new metafield dictionary which can be serialized to JSON.
    /// `let myMetafield = newMetafield |> key "Key" |> value (MetafieldValue.String "hello world") |> valueType MetafieldValueType.String`
    /// </summary>
    let newMetafield: MetafieldProperties =
        Map.empty
        
    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null
        
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : MetafieldProperties -> MetafieldProperties =
        Map.remove property
        
    let key (x: string) =
        JsonValue.String x |> add Key
        
    let value (x: MetafieldValue) =
        match x with
        | String s -> JsonValue.String s |> add Value
        | Integer i -> JsonValue.Int i |> add Value
        
    let valueType (x: MetafieldValueType) =
        JsonValue.String x.RawJsonName |> add ValueType
        
    let nameSpace (x: string) =
        JsonValue.String x |> add Namespace
        
    let description (x: string) =
        JsonValue.String x |> add Description 