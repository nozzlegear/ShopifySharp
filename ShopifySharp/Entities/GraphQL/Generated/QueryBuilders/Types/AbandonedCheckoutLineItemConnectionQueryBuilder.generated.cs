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
    public sealed class AbandonedCheckoutLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItemConnection, AbandonedCheckoutLineItemConnectionQueryBuilder>
    {
        protected override AbandonedCheckoutLineItemConnectionQueryBuilder Self => this;

        public AbandonedCheckoutLineItemConnectionQueryBuilder() : this("abandonedCheckoutLineItemConnection")
        {
        }

        public AbandonedCheckoutLineItemConnectionQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItemConnection>(name))
        {
        }

        public AbandonedCheckoutLineItemConnectionQueryBuilder(IQuery<AbandonedCheckoutLineItemConnection> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItemEdge>(query);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItem>(query);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}