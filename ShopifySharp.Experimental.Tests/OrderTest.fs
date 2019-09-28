module OrderTests

open System.Collections
open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental

let inline private (=>) a b = a, box b
let private service = Orders.Service.NewService "https://example.myshopify.com" "test token"

type UpdateFunction = (int64 * Orders.OrderProperties) -> Task<ShopifySharp.Order>
type CreateFunction = Orders.OrderProperties -> Task<ShopifySharp.Order>
type CreateWithOptionsFunction = (Orders.OrderProperties * Orders.CreationOptions.CreationOptionProperties) -> Task<ShopifySharp.Order>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: UpdateFunction = service.UpdateAsync
    let _: CreateFunction = service.CreateAsync
    let _: CreateWithOptionsFunction = service.CreateAsync
    
    Assert.True true 

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
