module WebhookTests

open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.Webhooks
open System.Threading.Tasks

let inline private (=>) a b = a, box b
let private service = Webhooks.Service.NewService "https://example.myshopify.com" "test token"
    
type UpdateFunction = (int64 * Webhooks.WebhookProperties) -> Task<ShopifySharp.Webhook>
type CreateFunction = Webhooks.WebhookProperties -> Task<ShopifySharp.Webhook>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: UpdateFunction = service.UpdateAsync
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true 

[<Fact>]
let ``Serializes webhook properties to a dictionary`` () =
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> Webhooks.toRawPropertyNames
    let expected = Map [
        "address" => "https://example.com"
        "format" => "json"
        "fields" => seq [ box "field1"; box "field2"]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq [ box "namespace1"; box "namespace2" ]
    ]
        
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)

[<Fact>]
let ``Serializes webhook properties to a dictionary with explicit null values`` () =
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.makePropertyNull WebhookProperty.Format 
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> Webhooks.toRawPropertyNames
    let expected = Map [
        "address" => "https://example.com"
        "format" => null
        "fields" => seq [ box "field1"; box "field2" ]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq [ box "namespace1"; box "namespace2" ]
    ]
        
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.makePropertyNull WebhookProperty.Format
        |> Webhooks.removeProperty WebhookProperty.Format
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> Webhooks.toRawPropertyNames
    let expected = Map [
        "address" => "https://example.com"
        "fields" => seq [ box "field1"; box "field2"]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq [ box "namespace1"; box "namespace2"]
    ]
        
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "format" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> Webhooks.toRawPropertyNames
    let expected = Map [
        "address" => "https://example.com"
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq [box "namespace1"; box "namespace2"]
    ]
        
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "format" dictionary)
    Assert.False(Map.containsKey "fields" dictionary)

[<Fact>]
let ``Replaces properties if they already exist`` () =
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.topic "hello/world"
        |> Webhooks.toRawPropertyNames
    let expected = Map [
        "address" => "https://example.com"
        "topic" => "hello/world"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
