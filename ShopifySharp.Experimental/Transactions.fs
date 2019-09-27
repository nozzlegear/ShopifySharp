namespace ShopifySharp.Experimental

module Transactions =
    type TransactionProperty =
        | Amount
        | Authorization 
        | Currency
        | Kind
        | ParentId
        | Status 
        | Test
    with
        member x.RawJsonName =
            match x with
            | Amount -> "amount"
            | Authorization ->  "authorization"
            | Currency -> "currency"
            | Kind -> "kind"
            | ParentId -> "parent_id"
            | Status -> "status"
            | Test -> "test"
            
    type TransactionKind =
        | Authorization
        | Capture
        | Sale
        | Void
        | Refund
    with
        member x.RawJsonName =
            match x with
            | Authorization -> "authorization"
            | Capture -> "capture"
            | Sale -> "sale"
            | Void -> "void"
            | Refund -> "refund"
            
    type TransactionStatus =
        | Pending
        | Failure
        | Success
        | Error
    with
        member x.RawJsonName =
            match x with
            | Pending -> "pending"
            | Failure -> "failure"
            | Success -> "success"
            | Error -> "error"
    
    type TransactionProperties = Map<TransactionProperty, JsonValue>
    
    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: TransactionProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties: TransactionProperties): TransactionProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new transaction dictionary which can be serialized to JSON.
    /// `let myTransaction = newTransaction |> kind "sale" |> status "success" |> amount 238.47`
    /// </summary>
    let newTransaction: TransactionProperties =
        Map.empty

    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null
    
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : TransactionProperties -> TransactionProperties =
        Map.remove property

    let amount (x: decimal) =
        JsonValue.Decimal x |> add Amount
        
    let authorization (x: string) =
        JsonValue.String x |> add TransactionProperty.Authorization
        
    let currency (x: string) =
        JsonValue.String x |> add Currency
        
    let kind (x: TransactionKind) =
        JsonValue.String x.RawJsonName |> add Kind
        
    let parentId (x: int64) =
        JsonValue.Int64 x |> add ParentId
        
    let status (x: TransactionStatus) =
        JsonValue.String x.RawJsonName |> add Status
        
    let isTest (x: bool) =
        JsonValue.Bool x |> add Test
