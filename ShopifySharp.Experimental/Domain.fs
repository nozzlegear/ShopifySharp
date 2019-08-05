namespace ShopifySharp.Experimental

type PropertyValue = 
    | Null
    | NotNull of obj
type PropertyName = string 
type Property = PropertyName * PropertyValue