module Tests

open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.Webhooks

let inline private (=>) a b = a, box b

[<Fact>]
let ``Serializes webhook properties to a dictionary`` () =
    let service = Webhooks.Service.NewService "domain" "token"
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> service.MapToDictionary
    let expected = Map [
        "address" => "https://example.com"
        "format" => "json"
        "fields" => seq ["field1"; "field2"]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq ["namespace1"; "namespace2"]
    ]
        
    Assert.Equal<Map<string, obj>>(dictionary, expected)

[<Fact>]
let ``Serializes webhook properties to a dictionary with explicit null values`` () =
    let service = Webhooks.Service.NewService "domain" "token"
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.makePropertyNull WebhookProperty.Format 
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> service.MapToDictionary
    let expected = Map [
        "address" => "https://example.com"
        "format" => null
        "fields" => seq ["field1"; "field2"]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq ["namespace1"; "namespace2"]
    ]
        
    Assert.Equal<Map<string, obj>>(dictionary, expected)
    
[<Fact>]
let ``Removes properties from the dictionary`` () =
    let service = Webhooks.Service.NewService "domain" "token"
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.format "json"
        |> Webhooks.makePropertyNull WebhookProperty.Format
        |> Webhooks.removeProperty WebhookProperty.Format
        |> Webhooks.fields ["field1"; "field2"]
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> service.MapToDictionary
    let expected = Map [
        "address" => "https://example.com"
        "fields" => seq ["field1"; "field2"]
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq ["namespace1"; "namespace2"]
    ]
        
    Assert.Equal<Map<string, obj>>(dictionary, expected)
    Assert.False(Map.containsKey "format" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let service = Webhooks.Service.NewService "domain" "token"
    let dictionary =
        Webhooks.newWebhook
        |> Webhooks.address "https://example.com"
        |> Webhooks.topic "app/uninstalled"
        |> Webhooks.metafieldNamespaces ["namespace1"; "namespace2"]
        |> service.MapToDictionary
    let expected = Map [
        "address" => "https://example.com"
        "topic" => "app/uninstalled"
        "metafield_namespaces" => seq ["namespace1"; "namespace2"]
    ]
        
    Assert.Equal<Map<string, obj>>(dictionary, expected)
    Assert.False(Map.containsKey "format" dictionary)
    Assert.False(Map.containsKey "fields" dictionary)
