namespace ShopifySharp.Experimental

module Customers =
    type CustomerProperty =
        | FirstName
        | LastName
        | Email
        | Phone
        | AcceptsMarketing
        | Note
        | CustomerTags
        | Addresses
        | MultipassIdentifier
        | TaxExempt
        | TaxExemptions
        | Metafields
    with
        member x.RawJsonName =
            match x with
            | FirstName -> "first_name"
            | LastName -> "last_name"
            | Email -> "email"
            | Phone -> "phone"
            | AcceptsMarketing -> "accepts_marketing"
            | Note -> "note"
            | CustomerTags -> "tags"
            | Addresses -> "addresses"
            | MultipassIdentifier -> "multipass_identifier"
            | TaxExempt -> "tax_exempt"
            | TaxExemptions -> "tax_exemptions"
            | Metafields -> "metafields"
            
    type CustomerProperties = Map<CustomerProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: CustomerProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties: CustomerProperties): CustomerProperties = 
        properties |> Map.add name value 

    /// <summary>
    /// Begins building a new webhook dictionary which can be serialized to JSON.
    /// `let myCustomer = newCustomer |> firstName "John" |> lastName "Doe" |> phone "555-555-5555"`
    /// </summary>
    let newCustomer : CustomerProperties = 
        Map.empty
        
    let firstName (x: string) =
        JsonValue.String x |> add FirstName
        
    let lastName (x: string) =
        JsonValue.String x |> add LastName
        
    let email (x: string) =
        JsonValue.String x |> add Email
        
    let phone (x: string) =
        JsonValue.String x |> add Phone
        
    let acceptsMarketing (x: bool) =
        JsonValue.Bool x |> add AcceptsMarketing
        
    let note (x: string) =
        JsonValue.String x |> add Note
        
    let tags (x: string) =
        JsonValue.String x |> add CustomerTags
        
    let addresses (x: ShopifySharp.Experimental.Addresses.AddressProperties seq) =
        Seq.map (ShopifySharp.Experimental.Addresses.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add Addresses
        
    let multipassIdentifier (x: string) =
        JsonValue.String x |> add MultipassIdentifier
     
    let taxExempt (x: bool) =
        JsonValue.Bool x |> add TaxExempt
        
    let taxExemptions (x: string seq) =
        Seq.map JsonValue.String x
        |> JsonValue.Array
        |> add TaxExemptions
        
    let metafields (x: ShopifySharp.Experimental.Metafields.MetafieldProperties seq) =
        Seq.map (ShopifySharp.Experimental.Metafields.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add Metafields
        
