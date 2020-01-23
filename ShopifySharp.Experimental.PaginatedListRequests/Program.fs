open System
open System.Collections.Generic
open System.Net.Http

type ListResult =
    { NextPageLink : string option
      PreviousPageLink : string option }
    
let parseUrlFromLink (link : string) : string option =
    let regex = System.Text.RegularExpressions.Regex "<(.*)>;"
    let matches = regex.Match link
    
    if not matches.Success then
        None
    else 
        matches.Groups
        |> Seq.skip 1
        |> Seq.tryHead
        |> Option.map (fun group -> group.Value)
        
let parsePageInfoFromUrl (url : string) : string option =
    let querySubstring =
        let startIndex = url.IndexOf '?'
        url.Substring startIndex
    let splitQuery =
        querySubstring.Split [|'?'; '&'|]
        |> Seq.map (fun segment ->
            let splitResult = segment.Split [|'='|]
            let key = splitResult.[0]
            let value = 
                match Seq.length splitResult with
                | 2 ->
                    splitResult.[1]
                | _ ->
                    ""
            KeyValuePair(key, value)
         )
    
    splitQuery
    |> Seq.tryFind (fun kvp -> kvp.Key = "page_info")
    |> Option.map (fun kvp -> kvp.Value)

let parseLinkHeader (headerValue : string) : ListResult =
//    let value =
//        """
//        <https://stages-test-shop-2.myshopify.com/admin/api/2020-01/orders.json?limit=50&page_info=eyJkaXJlY3Rpb24iOiJwcmV2IiwibGFzdF9pZCI6MjAwNjA3NTgwMTcwMywibGFzdF92YWx1ZSI6IjIwMTktMTItMzAgMTU6MTY6MTEifQ>; rel="previous", <https://stages-test-shop-2.myshopify.com/admin/api/2020-01/orders.json?limit=50&page_info=eyJkaXJlY3Rpb24iOiJuZXh0IiwibGFzdF9pZCI6MTkzMzI3NTY5MzE1OSwibGFzdF92YWx1ZSI6IjIwMTktMTItMDMgMDM6MjU6NDMifQ>; rel="next""
//        """
    let links : String[] =
        headerValue.Trim().Split [|','|]
    let previousPageLink : string option =
        links
        |> Seq.tryFind (fun link -> link.Contains "rel=\"previous\"")
        |> Option.bind (parseUrlFromLink >> Option.bind parsePageInfoFromUrl)
    let nextPageLink : string option =
        links
        |> Seq.tryFind (fun link -> link.Contains "rel=\"next\"")
        |> Option.bind (parseUrlFromLink >> Option.bind parsePageInfoFromUrl)
    
    { PreviousPageLink = previousPageLink
      NextPageLink = nextPageLink }

let listOrdersAndGetHeader () : Async<ListResult> =
    let baseUrl = "https://stages-test-shop-2.myshopify.com/admin/api/2020-01/orders.json?limit=50"
//    let nextPageUrl = "https://stages-test-shop-2.myshopify.com/admin/api/2020-01/orders.json?limit=50&page_info=eyJkaXJlY3Rpb24iOiJuZXh0IiwibGFzdF9pZCI6MTkzMzI3NTY5MzE1OSwibGFzdF92YWx1ZSI6IjIwMTktMTItMDMgMDM6MjU6NDMifQ"
//    let previousePageUrl = "https://stages-test-shop-2.myshopify.com/admin/api/2020-01/orders.json?limit=50&page_info=eyJkaXJlY3Rpb24iOiJwcmV2IiwibGFzdF9pZCI6MjAwNjA3NTgwMTcwMywibGFzdF92YWx1ZSI6IjIwMTktMTItMzAgMTU6MTY6MTEifQ"
    
    async {
        let client = new HttpClient()
        let request = new HttpRequestMessage()
        request.RequestUri <- Uri baseUrl
        request.Method <- HttpMethod.Get
        request.Headers.Add("X-Shopify-Access-Token", System.Environment.GetEnvironmentVariable("ACCESS_TOKEN"))
        
        let! result =
            client.SendAsync request
            |> Async.AwaitTask
            
        let linkHeader =
            match result.Headers |> Seq.tryFind (fun h -> h.Key = "Link") with
            | Some h ->
                System.String.Join(" ", h.Value)
            | None ->
                failwithf "Could not find Link header in response headers."
            
        let parseResult = parseLinkHeader linkHeader
        
        return parseResult 
    }

[<EntryPoint>]
let main argv =
    let parseResult =
        listOrdersAndGetHeader()
        |> Async.RunSynchronously
        
    printfn "Result is %A" parseResult
    
    0 // return an integer exit code
