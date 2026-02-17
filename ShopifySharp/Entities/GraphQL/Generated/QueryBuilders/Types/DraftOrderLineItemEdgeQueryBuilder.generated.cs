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
    public sealed class DraftOrderLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<DraftOrderLineItemEdge, DraftOrderLineItemEdgeQueryBuilder>
    {
        protected override DraftOrderLineItemEdgeQueryBuilder Self => this;

        public DraftOrderLineItemEdgeQueryBuilder() : this("draftOrderLineItemEdge")
        {
        }

        public DraftOrderLineItemEdgeQueryBuilder(string name) : base(new Query<DraftOrderLineItemEdge>(name))
        {
        }

        public DraftOrderLineItemEdgeQueryBuilder(IQuery<DraftOrderLineItemEdge> query) : base(query)
        {
        }

        public DraftOrderLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DraftOrderLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }
    }
}