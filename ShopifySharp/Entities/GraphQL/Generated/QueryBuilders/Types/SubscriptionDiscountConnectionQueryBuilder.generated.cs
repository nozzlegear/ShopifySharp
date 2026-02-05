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
    public sealed class SubscriptionDiscountConnectionQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountConnection, SubscriptionDiscountConnectionQueryBuilder>
    {
        protected override SubscriptionDiscountConnectionQueryBuilder Self => this;

        public SubscriptionDiscountConnectionQueryBuilder() : this("subscriptionDiscountConnection")
        {
        }

        public SubscriptionDiscountConnectionQueryBuilder(string name) : base(new Query<SubscriptionDiscountConnection>(name))
        {
        }

        public SubscriptionDiscountConnectionQueryBuilder(IQuery<SubscriptionDiscountConnection> query) : base(query)
        {
        }

        public SubscriptionDiscountConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountEdge>(query);
            return this;
        }

        public SubscriptionDiscountConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public SubscriptionDiscountConnectionQueryBuilder Nodes(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("nodes");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}