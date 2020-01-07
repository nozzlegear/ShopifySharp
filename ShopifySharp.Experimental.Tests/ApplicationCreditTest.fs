module ApplicationCreditTests

open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.ApplicationCredits

let private service = Service.NewService "https://example.myshopify.com" "test token"

type CreateFunction = ApplicationCreditProperties -> Task<ShopifySharp.ApplicationCredit>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true

[<Fact>]
let ``Serializes application credit properties to a dictionary`` () =
    let dictionary =
        ApplicationCredits.newApplicationCredit
        |> ApplicationCredits.description "My Test Refund"
        |> ApplicationCredits.test false 
        |> ApplicationCredits.amount 1.17M
        |> ApplicationCredits.toRawPropertyNames
    let expected = Map [
        "description" => "My Test Refund"
        "test" => false
        "amount" => 1.17M
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Serializes application credit properties to a dictionary with explicit null values`` () =
    let dictionary =
        ApplicationCredits.newApplicationCredit
        |> ApplicationCredits.description "My Test Refund"
        |> ApplicationCredits.test false 
        |> ApplicationCredits.amount 1.17M
        |> ApplicationCredits.makePropertyNull ApplicationCredits.Amount
        |> ApplicationCredits.toRawPropertyNames
    let expected = Map [
        "description" => "My Test Refund"
        "test" => false
        "amount" => null
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let dictionary =
        ApplicationCredits.newApplicationCredit
        |> ApplicationCredits.description "My Test Refund"
        |> ApplicationCredits.test false 
        |> ApplicationCredits.amount 1.17M
        |> ApplicationCredits.makePropertyNull ApplicationCredits.Amount
        |> ApplicationCredits.removeProperty ApplicationCredits.Amount
        |> ApplicationCredits.toRawPropertyNames
    let expected = Map [
        "description" => "My Test Refund"
        "test" => false
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "amount" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        ApplicationCredits.newApplicationCredit
        |> ApplicationCredits.description "My Test Refund"
        |> ApplicationCredits.test false 
        |> ApplicationCredits.toRawPropertyNames
    let expected = Map [
        "description" => "My Test Refund"
        "test" => false
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "amount" dictionary)
    
[<Fact>]
let ``Replaces properties if they already exist`` () =
    let dictionary =
        ApplicationCredits.newApplicationCredit
        |> ApplicationCredits.description "My Test Refund"
        |> ApplicationCredits.test false 
        |> ApplicationCredits.amount 1.17M
        |> ApplicationCredits.amount 5.25M
        |> ApplicationCredits.toRawPropertyNames
    let expected = Map [
        "description" => "My Test Refund"
        "test" => false
        "amount" => 5.25M
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)


