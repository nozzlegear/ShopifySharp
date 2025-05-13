#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.Services.Graph;

namespace ShopifySharp.Tests.Services.Graph;

public static class GraphServiceTestUtils
{
    public const string Query =
        """
        {
          orders(first:10)
          {
            nodes
            {
              id
              createdAt
              name
              phone
              lineItems(first: 10)
              {
                nodes
                {
                  title
                  quantity
                }
              }
            }
          }
        }
        """;

    public const string QueryWithVariables =
        """
        query ($firstOrders: Int!, $firstLineItems: Int!)
        {
          orders(first: $firstOrders)
          {
            nodes
            {
              id
              createdAt
              name
              phone
              lineItems(first: $firstLineItems)
              {
                nodes
                {
                  title
                  quantity
                }
              }
            }
          }
        }
        """;

    public static GraphRequest MakeGraphRequest(Action<GraphRequest>? customize = null)
    {
        var graphRequestForVariables = new GraphRequest
        {
            Query = QueryWithVariables,
            Variables = new Dictionary<string, object>
            {
                {"firstOrders", 10},
                {"firstLineItems", 20},
            },
            EstimatedQueryCost = 7,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw,
        };
        customize?.Invoke(graphRequestForVariables);
        return graphRequestForVariables;
    }
}
