#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ReturnableFulfillmentLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentLineItemEdge, ReturnableFulfillmentLineItemEdgeQueryBuilder>
    {
        protected override ReturnableFulfillmentLineItemEdgeQueryBuilder Self => this;

        public ReturnableFulfillmentLineItemEdgeQueryBuilder() : this("returnableFulfillmentLineItemEdge")
        {
        }

        public ReturnableFulfillmentLineItemEdgeQueryBuilder(string name) : base(new Query<ReturnableFulfillmentLineItemEdge>(name))
        {
        }

        public ReturnableFulfillmentLineItemEdgeQueryBuilder(IQuery<ReturnableFulfillmentLineItemEdge> query) : base(query)
        {
        }

        public ReturnableFulfillmentLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReturnableFulfillmentLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItem>(query);
            return this;
        }
    }
}