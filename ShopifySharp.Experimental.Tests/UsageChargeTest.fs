module UsageChargeTests

open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.UsageCharges

let private service = Service.NewService "https://example.myshopify.com" "test token"

type CreateFunction = (int64 * UsageChargeProperties) -> Task<ShopifySharp.UsageCharge>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true

[<Fact>]
let ``Serializes usage charge properties to a dictionary`` () =
    let dictionary =
        UsageCharges.newUsageCharge
        |> UsageCharges.description "Used 5 Foos"
        |> UsageCharges.price 1.17M
        |> UsageCharges.toRawPropertyNames
    let expected = Map [
        "description" => "Used 5 Foos"
        "price" => 1.17M
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Serializes usage charge properties to a dictionary with explicit null values`` () =
    let dictionary =
        UsageCharges.newUsageCharge
        |> UsageCharges.description "Used 5 Foos"
        |> UsageCharges.price 1.17M
        |> UsageCharges.makePropertyNull UsageCharges.Price
        |> UsageCharges.toRawPropertyNames
    let expected = Map [
        "description" => "Used 5 Foos"
        "price" => null
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let dictionary =
        UsageCharges.newUsageCharge
        |> UsageCharges.description "Used 5 Foos"
        |> UsageCharges.price 1.17M
        |> UsageCharges.makePropertyNull UsageCharges.Price
        |> UsageCharges.removeProperty UsageCharges.Price
        |> UsageCharges.toRawPropertyNames
    let expected = Map [
        "description" => "Used 5 Foos"
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "price" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        UsageCharges.newUsageCharge
        |> UsageCharges.description "Used 5 Foos"
        |> UsageCharges.toRawPropertyNames
    let expected = Map [
        "description" => "Used 5 Foos"
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "price" dictionary)
    
[<Fact>]
let ``Replaces properties if they already exist`` () =
    let dictionary =
        UsageCharges.newUsageCharge
        |> UsageCharges.description "Used 5 Foos"
        |> UsageCharges.price 1.17M
        |> UsageCharges.price 5.25M
        |> UsageCharges.toRawPropertyNames
    let expected = Map [
        "description" => "Used 5 Foos"
        "price" => 5.25M
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)

