module ChargeTests

open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.Charges

let private service = Charges.Service.NewService "https://example.myshopify.com" "test token"

type CreateFunction = ChargeProperties -> Task<ShopifySharp.Charge>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true

[<Fact>]
let ``Serializes charge properties to a dictionary`` () =
    let dictionary =
        Charges.newCharge
        |> Charges.name "My Charge"
        |> Charges.price 1.17M
        |> Charges.returnUrl "https://example.com/activate-charge"
        |> Charges.test false
        |> Charges.toRawPropertyNames
    let expected = Map [
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "test" => false
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Serializes charge properties to a dictionary with explicit null values`` () =
    let dictionary =
        Charges.newCharge
        |> Charges.name "My Charge"
        |> Charges.price 1.17M
        |> Charges.returnUrl "https://example.com/activate-charge"
        |> Charges.test false
        |> Charges.makePropertyNull Charges.Test 
        |> Charges.toRawPropertyNames
    let expected = Map [
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "test" => null
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let dictionary =
        Charges.newCharge
        |> Charges.name "My Charge"
        |> Charges.price 1.17M
        |> Charges.returnUrl "https://example.com/activate-charge"
        |> Charges.test false
        |> Charges.makePropertyNull Charges.Test
        |> Charges.removeProperty Charges.Test
        |> Charges.toRawPropertyNames
    let expected = Map [
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "test" dictionary)
    
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        Charges.newCharge
        |> Charges.name "My Charge"
        |> Charges.price 1.17M
        |> Charges.returnUrl "https://example.com/activate-charge"
        |> Charges.toRawPropertyNames
    let expected = Map [
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "test" dictionary)
    
[<Fact>]
let ``Replaces properties if they already exist`` () =
    let dictionary =
        Charges.newCharge
        |> Charges.name "My Charge"
        |> Charges.returnUrl "https://example.com/activate-charge"
        |> Charges.returnUrl "hello world"
        |> Charges.toRawPropertyNames
    let expected = Map [
        "name" => "My Charge"
        "return_url" => "hello world"
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
