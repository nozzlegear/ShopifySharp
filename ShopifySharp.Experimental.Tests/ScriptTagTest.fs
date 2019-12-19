module ScriptTagTests

open System.Threading.Tasks
open Xunit
open ShopifySharp.Experimental
open ShopifySharp.Experimental.ScriptTags

let private service = ScriptTags.Service.NewService "https://example.myshopify.com" "test token"

type UpdateFunction = (int64 * ScriptTags.ScriptTagProperties) -> Task<ShopifySharp.ScriptTag>
type CreateFunction = ScriptTags.ScriptTagProperties -> Task<ShopifySharp.ScriptTag>

[<Fact>]
let ``Function signatures match what they are expected to be`` () =
    // The test itself does nothing but pass. The compiler should throw errors if the signatures ever change.
    let _: UpdateFunction = service.UpdateAsync
    let _: CreateFunction = service.CreateAsync
    
    Assert.True true
    
[<Fact>]
let ``Serializes script tag properties to a dictionary`` () =
    let dictionary =
        ScriptTags.newScriptTag
        |> ScriptTags.src "https://example.com/tag.js"
        |> ScriptTags.event OnLoad
        |> ScriptTags.displayScope All
        |> ScriptTags.toRawPropertyNames
    let expected = Map [
        "src" => "https://example.com/tag.js"
        "event" => "onload"
        "display_scope" => "all"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    
[<Fact>]
let ``Serializes script tag properties to a dictionary with explicit null values`` () =
    let dictionary =
        ScriptTags.newScriptTag
        |> ScriptTags.src "https://example.com/tag.js"
        |> ScriptTags.event OnLoad
        |> ScriptTags.makePropertyNull Event
        |> ScriptTags.displayScope All
        |> ScriptTags.toRawPropertyNames
    let expected = Map [
        "src" => "https://example.com/tag.js"
        "event" => null
        "display_scope" => "all"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    
[<Fact>]
let ``Removes properties from the dictionary`` () = 
    let dictionary =
        ScriptTags.newScriptTag
        |> ScriptTags.src "https://example.com/tag.js"
        |> ScriptTags.event OnLoad
        |> ScriptTags.makePropertyNull Event
        |> ScriptTags.removeProperty Event
        |> ScriptTags.displayScope All
        |> ScriptTags.toRawPropertyNames
    let expected = Map [
        "src" => "https://example.com/tag.js"
        "display_scope" => "all"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "event" dictionary)
    
[<Fact>]
let ``Does not add unused properties`` () =
    let dictionary =
        ScriptTags.newScriptTag
        |> ScriptTags.src "https://example.com/tag.js"
        |> ScriptTags.toRawPropertyNames
    let expected = Map [
        "src" => "https://example.com/tag.js"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
    Assert.False(Map.containsKey "event" dictionary)
    Assert.False(Map.containsKey "display_scope" dictionary)
    
[<Fact>]
let ``Replaces properties if they already exist`` () = 
    let dictionary =
        ScriptTags.newScriptTag
        |> ScriptTags.src "https://example.com/tag.js"
        |> ScriptTags.event OnLoad
        |> ScriptTags.displayScope All
        |> ScriptTags.src "https://example.com/another/tag.js"
        |> ScriptTags.toRawPropertyNames
    let expected = Map [
        "src" => "https://example.com/another/tag.js"
        "event" => "onload"
        "display_scope" => "all"
    ]
    
    Assert.Equal(expected, JsonValue.MapPropertyValuesToObjects dictionary)
