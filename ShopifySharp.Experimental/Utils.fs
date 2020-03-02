[<AutoOpen>]
module ShopifySharp.Experimental.Utils

open System.Threading.Tasks
        
let mapTask (fn : 'a -> 'b) (task : Task<'a>) =
    let computation = 
        async {
            let! result = Async.AwaitTask task
            return fn result 
        }
    Async.StartAsTask computation 
