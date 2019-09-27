namespace ShopifySharp.Experimental
open System.Collections.Generic

module Orders =
    type OrderProperty =
        | BuyerAcceptsMarketing
        | Email
        | FulfillmentStatus
        | SendReceipt
        | SendFulfillmentReceipt
        | LineItems
        | Transactions
        | TotalTax
        | Currency
        | TaxLines
        | FinancialStatus
        | Customer
        | BillingAddress
        | ShippingAddress
        | Note
        | NoteAttributes
        | Phone
        | Metafields
        | OrderTags
    with
        member x.RawJsonName =
            match x with
            | BuyerAcceptsMarketing -> "buyer_accepts_marketing"
            | Email -> "email"
            | FulfillmentStatus -> "fulfillment_status"
            | SendReceipt -> "send_receipt"
            | SendFulfillmentReceipt -> "send_fulfillment_receipt"
            | LineItems -> "line_items"
            | Transactions -> "transactions"
            | TotalTax -> "total_tax"
            | Currency -> "currency"
            | TaxLines -> "tax_lines"
            | FinancialStatus -> "financial_status"
            | Customer -> "customer"
            | BillingAddress -> "billing_address"
            | ShippingAddress -> "shipping_address"
            | Note -> "note"
            | NoteAttributes -> "note_attributes"
            | Phone -> "phone"
            | Metafields -> "metafields"
            | OrderTags -> "tags"
            
    type OrderFinancialStatus =
        | Pending
        | Authorized
        | PartiallyPaid
        | Paid
        | PartiallyRefunded
        | Refunded
        | Voided
    with
        member x.RawJsonName =
            match x with
            | Pending -> "pending"
            | Authorized -> "authorized"
            | PartiallyPaid -> "partially_paid"
            | Paid -> "paid"
            | PartiallyRefunded -> "partially_refunded"
            | Refunded -> "refunded"
            | Voided -> "voided"
            
    type OrderFulfillmentStatus =
        | Fulfilled
        | Partial
        | Restocked
    with
        member x.RawJsonName =
            match x with
            | Fulfilled -> "fulfilled"
            | Partial -> "partial"
            | Restocked -> "restocked"

    type OrderProperties = Map<OrderProperty, JsonValue>

    /// Serializes the map of properties to a `Map<string, JsonValue>`, which ShopifySharp can then serialize to JSON.
    let toRawPropertyNames (properties: OrderProperties) =
        properties |> JsonValue.MapPropertyNamesToStrings (fun key -> key.RawJsonName)
        
    let private add name value (properties: OrderProperties): OrderProperties =
        properties
        |> Map.add name value
        
    /// <summary>
    /// Begins building a new order dictionary which can be serialized to JSON.
    /// `let myOrder = newOrder |> note "this is a note" |> total_tax 5.00 |> financialStatus Authorized`
    /// </summary>
    let newOrder: OrderProperties =
        Map.empty

    /// <summary>
    /// Explicitly sets the value of a property to null when serialized to JSON.
    /// </summary>
    let makePropertyNull property =
        add property JsonValue.Null 
    
    /// <summary>
    /// Removes a property entirely when serialized to JSON. Not even null will be sent in its place.
    /// </summary>
    let removeProperty property : OrderProperties -> OrderProperties =
        Map.remove property 
    
    let buyerAcceptsMarketing (x: bool) =
        JsonValue.Bool x |> add BuyerAcceptsMarketing
        
    let email (x: string) =
        JsonValue.String x |> add Email
        
    let fulfillmentStatus (x: OrderFulfillmentStatus) =
        JsonValue.String x.RawJsonName |> add FulfillmentStatus
        
    let sendReceipt (x: bool) =
        JsonValue.Bool x |> add SendReceipt
        
    let sendFulfillmentReceipt (x: bool) =
        JsonValue.Bool x |> add SendFulfillmentReceipt
        
    let lineItems (x: OrderLineItems.OrderLineItemProperties seq) =
        Seq.map (OrderLineItems.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add LineItems 
        
    let transactions (x: Transactions.TransactionProperties seq) =
        Seq.map (Transactions.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add Transactions
        
    let totalTax (x: decimal) =
        JsonValue.Decimal x |> add TotalTax
        
    let currency (x: string) =
        JsonValue.String x |> add Currency
        
    let taxLines (x: TaxLines.TaxLineProperties seq) =
        Seq.map (TaxLines.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add TaxLines 
        
    let financialStatus (x: OrderFinancialStatus) =
        JsonValue.String x.RawJsonName |> add FinancialStatus
        
    let customer (x: Customers.CustomerProperties) =
        Customers.toRawPropertyNames x
        |> JsonValue.Dictionary
        |> add Customer
        
    let billingAddress (x: Addresses.AddressProperties) =
        Addresses.toRawPropertyNames x
        |> JsonValue.Dictionary
        |> add BillingAddress
        
    let shippingAddress (x: Addresses.AddressProperties) =
        Addresses.toRawPropertyNames x
        |> JsonValue.Dictionary
        |> add ShippingAddress
        
    let note (x: string) =
        JsonValue.String x |> add Note
        
    let noteAttributes (x: KeyValuePair<string, string> seq) =
        let toMap (x: KeyValuePair<string, string>) =
            Map [
                "name", JsonValue.String x.Key
                "value", JsonValue.String x.Value
            ]

        Seq.map (toMap >> JsonValue.Dictionary) x            
        |> JsonValue.Array
        |> add NoteAttributes
        
    let phone (x: string) =
        JsonValue.String x |> add Phone
        
    let metafields (x: Metafields.MetafieldProperties seq) =
        Seq.map (Metafields.toRawPropertyNames >> JsonValue.Dictionary) x
        |> JsonValue.Array
        |> add Metafields

    let tags (x: string) =
        JsonValue.String x |> add OrderTags