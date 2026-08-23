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
    public sealed class SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder : FieldsQueryBuilderBase<ProductVariantConnection, SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder>, IHasArguments<SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder>
    {
        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder Self => this;

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder(string name) : base(new Query<ProductVariantConnection>(name))
        {
            Arguments = new SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder(IQuery<ProductVariantConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder SetArguments(Action<SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantEdge>(query);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}