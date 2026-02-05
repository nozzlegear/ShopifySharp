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

        public DraftOrderLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }
    }
}