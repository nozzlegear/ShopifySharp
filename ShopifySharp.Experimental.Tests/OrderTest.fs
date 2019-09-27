module OrderTests

open System.Collections
open Xunit
open ShopifySharp.Experimental

let inline private (=>) a b =
    match b with
    | :? seq as b -> a, b
    | _ -> a, b

[<Fact>]
let ``Merges order properties and creation option properties`` () =
    let order =
        Orders.newOrder
        |> Orders.email "foo@example.com"
        |> Orders.fulfillmentStatus Orders.OrderFulfillmentStatus.Fulfilled
        |> Orders.lineItems [
            OrderLineItems.newLineItem
            |> OrderLineItems.variantId 457924702L
            |> OrderLineItems.quantity 1
        ]
    let creationOptions =
        Orders.CreationOptions.newCreationOptions
        |> Orders.CreationOptions.sendReceipt true
        |> Orders.CreationOptions.sendFulfillmentReceipt true
    let merged = Orders.mergeOrderAndCreationOptions order creationOptions
    let expected = Map [
        "email" => "foo@example.com"
        "fulfillment_status" => "fulfilled"
        "send_receipt" => true
        "send_fulfillment_receipt" => true 
        "line_items" => seq [
            Map [
                "variant_id" => 457924702L
                "quantity" => 1
            ] |> box 
        ]
    ]
    
    Assert.Equal(box expected, JsonValue.MapPropertyValuesToObjects merged)
    
    
