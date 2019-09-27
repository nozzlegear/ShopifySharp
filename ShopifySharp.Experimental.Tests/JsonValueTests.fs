module JsonValueTests

open System.Collections.Generic
open Xunit
open ShopifySharp.Experimental

let inline private (=>) a b = a, box b

[<Fact>]
let ``Serializes raw integer value`` () =
    let value = JsonValue.Int 5
    
    Assert.Equal(box 5, value.RawJsonValue)

[<Fact>]
let ``Serializes raw string value`` () =
    let value = JsonValue.String "hello world"
    
    Assert.Equal(box "hello world", value.RawJsonValue)
    
[<Fact>]
let ``Serializes raw int64 value`` () =
    let value = JsonValue.Int64 987654321L
    
    Assert.Equal(box 987654321L, value.RawJsonValue)
    
[<Fact>]
let ``Serializes raw decimal value`` () =
    let value = JsonValue.Decimal 1.17M
    
    Assert.Equal(box 1.17M, value.RawJsonValue)
    
[<Fact>]
let ``Serializes raw bool value`` () =
    let value = JsonValue.Bool true
    
    Assert.Equal(box true, value.RawJsonValue)
    
[<Fact>]
let ``Serializes null value`` () =
    let value = JsonValue.Null
    
    Assert.Equal(box null, value.RawJsonValue)
    
[<Fact>]
let ``Serializes list value`` () =
    let value =
        [ JsonValue.String "hello"; JsonValue.String "world" ]
        |> Seq.ofList
        |> JsonValue.Array 
    let expected = Seq.ofList [ "hello"; "world" ]
    
    Assert.Equal(box expected, value.RawJsonValue)
    
[<Fact>]
let ``Serializes simple dictionary value`` () =
    let value =
        [ "hello", JsonValue.String "world"; "foo", JsonValue.String "bar" ]
        |> Map.ofList<string, JsonValue>
        |> JsonValue.Dictionary
    let expected = Map [
        "hello" => "world"
        "foo" => "bar"
    ]
    Assert.Equal(box expected, value.RawJsonValue)
    
[<Fact>]
let ``Serializes dictionaries with list children`` () =
    let list = Seq.ofList [ JsonValue.String "hello"; JsonValue.String "world" ]
    let value =
        [ "foo", JsonValue.Array list ]
        |> Map.ofList
        |> JsonValue.Dictionary
    let expected = Map [
        "foo" => [ box "hello"; box "world" ]
    ]
    
    Assert.Equal(box expected, value.RawJsonValue)
    
[<Fact>]
let ``Serializes complex dictionary value`` () =
    let childList =
        Seq.ofList [ JsonValue.String "test1"; JsonValue.Int 25 ]
        |> JsonValue.Array 
    let childDict =
        [ "helloAgain", JsonValue.String "abcd"; "fooAgain", JsonValue.Bool true ]
        |> Map.ofList<string, JsonValue>
        |> JsonValue.Dictionary
    let value =
        Map [
            "hello", JsonValue.String "world"
            "foo", JsonValue.Null
            "bar", JsonValue.Int 5
            "baz", JsonValue.Int64 123456L
            "bat", JsonValue.Bool false
            "list", childList
            "dict", childDict ]
        |> JsonValue.Dictionary
    let expected = Map [
        "hello" => "world"
        "foo" => null
        "bar" => 5
        "baz" => 123456L
        "bat" => false
        "list" => [ box "test1"; box 25 ]
        "dict" => Map [
            "helloAgain" => "abcd"
            "fooAgain" => true 
        ]
    ]
    
    Assert.Equal(box expected, value.RawJsonValue)
    
[<Fact>]
let ``Serializes a map of property names and json values to an IDictionary<string, obj>`` () =
    let childList =
        Seq.ofList [ JsonValue.String "test1"; JsonValue.Int 25 ]
        |> JsonValue.Array 
    let childDict =
        [ "helloAgain", JsonValue.String "abcd"; "fooAgain", JsonValue.Bool true ]
        |> Map.ofList<string, JsonValue>
        |> JsonValue.Dictionary
    let value = Map [
        "hello", JsonValue.String "world"
        "foo", JsonValue.Null
        "bar", JsonValue.Int 5
        "baz", JsonValue.Int64 123456L
        "bat", JsonValue.Bool false
        "list", childList
        "dict", childDict 
    ]
    let expected = Map [
        "hello" => "world"
        "foo" => null
        "bar" => 5
        "baz" => 123456L
        "bat" => false
        "list" => [ box "test1"; box 25 ]
        "dict" => Map [
            "helloAgain" => "abcd"
            "fooAgain" => true 
        ]
    ]
    
    Assert.Equal(box expected, JsonValue.MapPropertyValuesToObjects value)

let ``Serializes a Map to string property names`` () =
    let fn = function
        | 5 ->  "five"
        | 10 -> "ten"
        | 15 -> "fifteen"
        | x -> failwithf "Unrecognized key %i" x
    let value = Map [
        5, JsonValue.Int 5
        10, JsonValue.Int 10
        15, JsonValue.Int 15 
    ]
    let expected = Map [
        "five", JsonValue.Int 5
        "ten", JsonValue.Int 10
        "fifteen", JsonValue.Int 15 
    ]
    
    Assert.Equal(box expected, JsonValue.MapPropertyNamesToStrings fn value)
    Assert.Equal(box expected, value |> JsonValue.MapPropertyNamesToStrings fn |> JsonValue.MapPropertyValuesToObjects)