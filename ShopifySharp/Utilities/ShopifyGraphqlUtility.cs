#nullable enable
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Utilities;

public interface IShopifyGraphqlUtility
{
    Task<string> GetSchemaAsJsonStringAsync(ShopifyApiCredentials credentials, string apiVersion, CancellationToken cancellationToken = default);
}

public class ShopifyGraphqlUtility : IShopifyGraphqlUtility
{
    private const string IntrospectionOperationName = "IntrospectionQuery";
    private const string IntrospectionQuery =
        """
        query IntrospectionQuery {
          __schema {
            queryType { name }
            mutationType { name }
            subscriptionType { name }
            types { ...FullType }
            directives { name description locations args { ...InputValue } }
          }
        }
        fragment FullType on __Type {
          kind name description
          fields(includeDeprecated: true) {
            name description args { ...InputValue } type { ...TypeRef }
            isDeprecated deprecationReason
          }
          inputFields { ...InputValue }
          interfaces { ...TypeRef }
          enumValues(includeDeprecated: true) { name description isDeprecated deprecationReason }
          possibleTypes { ...TypeRef }
        }
        fragment InputValue on __InputValue {
          name description type { ...TypeRef } defaultValue
        }
        fragment TypeRef on __Type {
          kind name ofType { kind name ofType { kind name ofType { kind name ofType { kind name }}}}
        }
        """;

    private readonly Version? _assemblyVersion = typeof(IShopifyGraphqlUtility).GetTypeInfo().Assembly.GetName().Version;
    private string UserAgent => $"ShopifySharp v{_assemblyVersion} (https://github.com/nozzlegear/shopifysharp)";

    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IShopifyDomainUtility _shopifyDomainUtility;

    public ShopifyGraphqlUtility(IServiceProvider serviceProvider)
    {
        _httpClientFactory = InternalServiceResolver.GetServiceOrDefault<IHttpClientFactory>(
            serviceProvider, () => new InternalHttpClientFactory());
        _shopifyDomainUtility = InternalServiceResolver.GetServiceOrDefault<IShopifyDomainUtility>(
            serviceProvider, () => new ShopifyDomainUtility());
    }

    public async Task<string> GetSchemaAsJsonStringAsync(
        ShopifyApiCredentials credentials,
        string apiVersion,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(apiVersion))
            throw new ArgumentNullException(nameof(apiVersion));

        var uriBuilder = new UriBuilder(_shopifyDomainUtility.BuildShopDomainUri(credentials.ShopDomain))
        {
            Path = $"admin/api/{apiVersion}/graphql.json"
        };

        var client = _httpClientFactory.CreateClient();
        using var requestData = new JsonContent(new
        {
            query = IntrospectionQuery,
            operationName = IntrospectionOperationName,
        });
        var msg = new HttpRequestMessage(HttpMethod.Post, uriBuilder.Uri)
        {
            Content = requestData,
        };
        msg.Headers.Add("User-Agent", UserAgent);
        msg.Headers.Add("X-Shopify-Access-Token", credentials.AccessToken);
        msg.Headers.Add("Accept", "application/json");

        using var response = await client.SendAsync(msg, cancellationToken);
        var responseBody = await response.Content.ReadAsStringAsync();
        var requestInfo = $"HTTP {msg.Method} request to {msg.RequestUri}";

        ShopifyService.CheckResponseExceptions(requestInfo, response, responseBody);

        return responseBody;
    }
}
