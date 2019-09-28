module WebhookTests

open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.Webhooks

let inline private (=>) a b = a, box b

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