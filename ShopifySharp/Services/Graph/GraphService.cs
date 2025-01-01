using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Text.Json;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for using or manipulating Shopify's Graph API.
/// </summary>
public class GraphService : ShopifyService, IGraphService
{
    private readonly string _apiVersion;

    public override string APIVersion => _apiVersion ?? base.APIVersion;

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        string apiVersion = null
    ) : base(myShopifyUrl, shopAccessToken)
    {
        _apiVersion = apiVersion;
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        IShopifyDomainUtility shopifyDomainUtility
    ) : base(myShopifyUrl, shopAccessToken, shopifyDomainUtility)
    {

    }

    public virtual async Task<T> PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(new Dictionary<string, object>
        {
            {"query", graphRequest.Query},
            {"variables", graphRequest.Variables},
        });
        var res = await PostAsync<JsonDocument>(json, "application/json", graphRequest.EstimatedQueryCost, cancellationToken);
        // TODO: if we always scope down to "data" here, is it possible to get things like "extensions"?
        return res.RootElement.GetProperty("data").Deserialize<T>();
    }

    public virtual async Task<JsonDocument> PostAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        return await PostAsync<JsonDocument>(graphRequest, cancellationToken);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(JToken body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var res = await PostAsync<JToken>(body.ToString(Formatting.None), "application/json", graphqlQueryCost, cancellationToken);
        return res["data"];
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var res = await PostAsync<JToken>(graphqlQuery, "application/graphql", graphqlQueryCost, cancellationToken);
        return res["data"];
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual Task<JsonElement> SendAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        return SendAsync(new GraphRequest { Query = graphqlQuery }, graphqlQueryCost, cancellationToken);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JsonElement> SendAsync(GraphRequest request, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var body = System.Text.Json.JsonSerializer.Serialize(request);
        var res = await PostAsync<JsonDocument>(body, "application/json", graphqlQueryCost, cancellationToken);
        return res.RootElement.GetProperty("data");
    }

#if NET6_0_OR_GREATER
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual Task<TResult> SendAsync<TResult>(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
        where TResult : class
    {
        return SendAsync<TResult>(new GraphRequest { Query = graphqlQuery }, graphqlQueryCost, cancellationToken);
    }

    /// <summary>
    /// Issue a single value query and return the value as an strongly typed object.
    /// Use a type from the ShopifySharp.GraphQL namespace
    /// </summary>
    /// <typeparam name="TResult">Use a type from the ShopifySharp.GraphQL namespace</typeparam>
    /// <param name="request"></param>
    /// <param name="graphqlQueryCost"></param>
    /// <param name="cancellationToken"></param>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<TResult> SendAsync<TResult>(GraphRequest request, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
        where TResult : class
    {
        return (TResult)await PostAsync(request, typeof(TResult), graphqlQueryCost, cancellationToken);
    }

    public virtual Task<object> PostAsync(string graphqlQuery, Type resultType, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        return PostAsync(new GraphRequest { query = graphqlQuery }, resultType, graphqlQueryCost, cancellationToken);
    }

    public virtual async Task<object> PostAsync(GraphRequest request, Type resultType, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var elt = await this.SendAsync(request, graphqlQueryCost, cancellationToken);
        var ptyElt = elt.EnumerateObject().Single().Value;
        return GraphQL.Serializer.Deserialize(ptyElt.GetRawText(), resultType);
    }
#endif

    private async Task<T> PostAsync<T>(string body, string mediaType, int? graphqlQueryCost, CancellationToken cancellationToken)
    {
        var req = BuildRequestUri("graphql.json");
        var content = new StringContent(body, Encoding.UTF8, mediaType);
        return await SendAsync<T>(req, content, graphqlQueryCost, cancellationToken);
    }

    /// <summary>
    /// Content agnostic way to send the request, regardless of Json or GraphQL.
    /// </summary>
    /// <param name="req">The RequestUri.</param>
    /// <param name="content">The HttpContent, be it GraphQL or Json.</param>
    /// <param name="graphqlQueryCost">An estimation of the cost of this query.</param>
    /// <returns>A JToken containing the data from the request.</returns>
    protected virtual async Task<T> SendAsync<T>(RequestUri req, HttpContent content, int? graphqlQueryCost, CancellationToken cancellationToken = default)
    {
        var response = await ExecuteRequestCoreAsync<T>(req, HttpMethod.Post, cancellationToken, content, null, null, graphqlQueryCost, DateParseHandling.None);

        CheckForErrors(response);

        return response.Result;
    }

    /// <summary>
    /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API doesn't work well without potentially throwing unnecessary errors. This loses the requestId, but otherwise is capable of passing along the message.
    /// </summary>
    /// <param name="requestResult">The <see cref="RequestResult{JToken}" /> response from ExecuteRequestAsync.</param>
    /// <exception cref="ShopifyException">Thrown if <paramref name="requestResult"/> contains an error.</exception>
    protected virtual void CheckForErrors<T>(RequestResult<T> requestResult)
    {
        var res = JToken.Parse(requestResult.RawResult);

        if (res["errors"] != null)
        {
            var errorList = new List<string>();

            foreach (var error in res["errors"])
            {
                if (error["message"] is not null)
                {
                    errorList.Add(error["message"].ToString());
                }
            }

            var message = errorList.FirstOrDefault() ?? "Unable to parse Shopify's error response, please inspect exception's RawBody property and report this issue to the ShopifySharp maintainers.";
            var requestId = ParseRequestIdResponseHeader(requestResult.ResponseHeaders);

            throw new ShopifyHttpException(requestResult.RequestInfo, HttpStatusCode.OK, errorList, message, requestResult.RawResult, requestId);
        }
    }
}

