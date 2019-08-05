namespace ShopifySharp.Experimental
open System.Collections.Generic

module Webhooks = 
    type private Properties = Map<string, PropertyValue>
    let private add name value (properties: Properties) = 
        properties
        |> Map.add name value 

    let newWebhook: Properties = Map.empty
    let address = add "address"
    let fields = add "fields"
    let format = add "format"
    let metafieldNamespaces = add "metafield_namespaces"
    let topic = add "topic"

    // Current usage:
    let private myWebhook = 
        newWebhook
        |> address (NotNull <| box "Some address")
        |> format (NotNull <| box "json")
        |> metafieldNamespaces Null
        // Creates the following data:
        // { address: "Some address", format: "json", metafield_namespaces: null }

    // Ideal usage
    // let private myWebhook = 
    //      newWebhook
    //      |> setValue Address "Some address"
    //      |> setValue Format "json"
    //      |> setNull MetafieldNamespaces
    //      |> remove Topic // Remove does not set the value to null, it removes the entire value from the map so it is not sent at all