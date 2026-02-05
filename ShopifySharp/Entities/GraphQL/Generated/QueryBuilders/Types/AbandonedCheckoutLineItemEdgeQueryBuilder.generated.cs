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
    public sealed class AbandonedCheckoutLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItemEdge, AbandonedCheckoutLineItemEdgeQueryBuilder>
    {
        protected override AbandonedCheckoutLineItemEdgeQueryBuilder Self => this;

        public AbandonedCheckoutLineItemEdgeQueryBuilder() : this("abandonedCheckoutLineItemEdge")
        {
        }

        public AbandonedCheckoutLineItemEdgeQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItemEdge>(name))
        {
        }

        public AbandonedCheckoutLineItemEdgeQueryBuilder(IQuery<AbandonedCheckoutLineItemEdge> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AbandonedCheckoutLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItem>(query);
            return this;
        }
    }
}