namespace ShopifySharp.Experimental

module Addresses =
    type AddressProperty =
        | Address1
        | Address2
        | City
        | Company
        | Country
        | CountryCode
        | CountryName
        | Default
        | FirstName
        | LastName
        | Phone
        | Province
        | ProvinceCode
        | Zip
    with
        member x.RawJsonName =
            match x with
            | Address1 -> "address1"
            | Address2 -> "address2"
            | City -> "city"
            | Company -> "company"
            | Country -> "country"
            | CountryCode -> "country_code"
            | CountryName -> "country_name"
            | Default -> "default"
            | FirstName -> "first_name"
            | LastName -> "last_name"
            | Phone -> "phone"
            | Province -> "province"
            | ProvinceCode -> "province_code"
            | Zip -> "zip"
    
    type AddressProperties = Map<AddressProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: AddressProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
    
    let private add name value (properties: AddressProperties): AddressProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new address dictionary which can be serialized to JSON.
    /// `let myAddress = newAddress |> firstName "John" |> lastName "Doe" |> address1 "123 Fake St."`
    /// </summary>
    let newAddress: AddressProperties =
        Map.empty

    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null
    
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : AddressProperties -> AddressProperties =
        Map.remove property
        
    let address1 (x: string) =
        JsonValue.String x |> add Address1
        
    let address2 (x: string) =
        JsonValue.String x |> add Address2
        
    let city (x: string) =
        JsonValue.String x |> add City
        
    let company (x: string) =
        JsonValue.String x |> add Company
        
    let country (x: string) =
        JsonValue.String x |> add Country
        
    let countryCode (x: string) =
        JsonValue.String x |> add CountryCode
        
    let countryName (x: string) =
        JsonValue.String x |> add CountryName
        
    let isDefault (x: bool) =
        JsonValue.Bool x |> add Default
        
    let firstName (x: string) =
        JsonValue.String x |> add FirstName
        
    let lastName (x: string) =
        JsonValue.String x |> add LastName
        
    let phone (x: string) =
        JsonValue.String x |> add Phone
        
    let province (x: string) =
        JsonValue.String x |> add Province
        
    let provinceCode (x: string) =
        JsonValue.String x |> add ProvinceCode
        
    let zip (x: string) =
        JsonValue.String x |> add Zip 
