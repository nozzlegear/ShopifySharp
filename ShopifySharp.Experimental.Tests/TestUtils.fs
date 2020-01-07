[<AutoOpen>]
module TestUtils
    /// A custom operator for easily adding key/value pairs to a dictionary while casting the value to object.
    let inline (=>) a b = a, box b

