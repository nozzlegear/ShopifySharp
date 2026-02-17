#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CalculatedLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<CalculatedLineItemEdge, CalculatedLineItemEdgeQueryBuilder>
    {
        protected override CalculatedLineItemEdgeQueryBuilder Self => this;

        public CalculatedLineItemEdgeQueryBuilder() : this("calculatedLineItemEdge")
        {
        }

        public CalculatedLineItemEdgeQueryBuilder(string name) : base(new Query<CalculatedLineItemEdge>(name))
        {
        }

        public CalculatedLineItemEdgeQueryBuilder(IQuery<CalculatedLineItemEdge> query) : base(query)
        {
        }

        public CalculatedLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CalculatedLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }
    }
}