module RecurringChargeTests

open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.RecurringCharges

let private service = RecurringCharges.Service.NewService "https://example.myshopify.com" "test token"

type CreateFunction = RecurringChargeProperties -> Task<ShopifySharp.RecurringCharge>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true

[<Fact>]
let ``Serializes recurring charge properties to a dictionary`` () =
    let dictionary =
        RecurringCharges.newRecurringCharge
        |> RecurringCharges.cappedAmount 5.0M
        |> RecurringCharges.name "My Charge"
        |> RecurringCharges.price 1.17M
        |> RecurringCharges.returnUrl "https://example.com/activate-charge"
        |> RecurringCharges.terms "These are the charge terms"
        |> RecurringCharges.test false
        |> RecurringCharges.trialDays 14 
        |> RecurringCharges.toRawPropertyNames
    let expected = Map [
        "capped_amount" => 5.0M
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "terms" => "These are the charge terms"
        "test" => false
        "trial_days" => 14 
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Serializes recurring charge properties to a dictionary with explicit null values`` () =
    let dictionary =
        RecurringCharges.newRecurringCharge
        |> RecurringCharges.cappedAmount 5.0M
        |> RecurringCharges.name "My Charge"
        |> RecurringCharges.price 1.17M
        |> RecurringCharges.returnUrl "https://example.com/activate-charge"
        |> RecurringCharges.terms "These are the charge terms"
        |> RecurringCharges.test false
        |> RecurringCharges.trialDays 14
        |> RecurringCharges.makePropertyNull RecurringCharges.TrialDays
        |> RecurringCharges.toRawPropertyNames
    let expected = Map [
        "capped_amount" => 5.0M
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "terms" => "These are the charge terms"
        "test" => false
        "trial_days" => null 
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary) 
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let dictionary =
        RecurringCharges.newRecurringCharge
        |> RecurringCharges.cappedAmount 5.0M
        |> RecurringCharges.name "My Charge"
        |> RecurringCharges.price 1.17M
        |> RecurringCharges.returnUrl "https://example.com/activate-charge"
        |> RecurringCharges.terms "These are the charge terms"
        |> RecurringCharges.test false
        |> RecurringCharges.trialDays 14
        |> RecurringCharges.makePropertyNull RecurringCharges.TrialDays
        |> RecurringCharges.removeProperty RecurringCharges.TrialDays
        |> RecurringCharges.toRawPropertyNames
    let expected = Map [
        "capped_amount" => 5.0M
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "terms" => "These are the charge terms"
        "test" => false
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "trial_days" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        RecurringCharges.newRecurringCharge
        |> RecurringCharges.cappedAmount 5.0M
        |> RecurringCharges.name "My Charge"
        |> RecurringCharges.price 1.17M
        |> RecurringCharges.returnUrl "https://example.com/activate-charge"
        |> RecurringCharges.terms "These are the charge terms"
        |> RecurringCharges.test false
        |> RecurringCharges.toRawPropertyNames
    let expected = Map [
        "capped_amount" => 5.0M
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "terms" => "These are the charge terms"
        "test" => false
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "trial_days" dictionary)
    
[<Fact>]
let ``Replaces properties if they already exist`` () =
    let dictionary =
        RecurringCharges.newRecurringCharge
        |> RecurringCharges.cappedAmount 5.0M
        |> RecurringCharges.name "My Charge"
        |> RecurringCharges.price 1.17M
        |> RecurringCharges.returnUrl "https://example.com/activate-charge"
        |> RecurringCharges.terms "These are the charge terms"
        |> RecurringCharges.test false
        |> RecurringCharges.test true 
        |> RecurringCharges.toRawPropertyNames
    let expected = Map [
        "capped_amount" => 5.0M
        "name" => "My Charge"
        "price" => 1.17M
        "return_url" => "https://example.com/activate-charge"
        "terms" => "These are the charge terms"
        "test" => true
    ]    
   
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
