namespace ShopifySharp.Experimental
open System.Collections.Generic
open System.Collections.Generic

type JsonValue =
    | String of string 
    | Int of int
    | Int64 of int64
    | Decimal of decimal 
    | Bool of bool
    | Dictionary of Map<string,JsonValue>
    | Array of JsonValue seq
    | Null
with
    member x.RawJsonValue =
        match x with
        | Null -> box null 
        | String s -> box s
        | Int i -> box i
        | Int64 i -> box i
        | Decimal i -> box i
        | Bool b -> box b
        | Dictionary d -> d |> Map.map (fun _ i -> i.RawJsonValue) |> box 
        | Array a -> box [ for i in a do yield i.RawJsonValue ]
    /// Maps the values of a `Map<string, JsonValue>` to an `IDictionary<string, JsonValue>` which can be serialized to JSON.
    static member MapPropertyValuesToObjects (x: Map<string, JsonValue>): IDictionary<string, obj> =
        x
        |> Map.map (fun _ i -> i.RawJsonValue)
        :> IDictionary<string, obj>
    /// Maps the keys of a `Map<'a, JsonValue>` to a `Map<string, JsonValue>` by calling `fn` to get a key's JSON name.
    static member MapPropertyNamesToStrings (fn: 'a -> string) (x: Map<'a, JsonValue>): Map<string, JsonValue> =
        Map.toSeq x
        |> Seq.map (fun (key, value) -> fn key, value)
        |> Map.ofSeq
