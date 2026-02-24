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
    public sealed class SubscriptionContractDiscountsQueryBuilder : FieldsQueryBuilderBase<SubscriptionManualDiscountConnection, SubscriptionContractDiscountsQueryBuilder>, IHasArguments<SubscriptionContractDiscountsArgumentsBuilder>
    {
        public SubscriptionContractDiscountsArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractDiscountsQueryBuilder Self => this;

        public SubscriptionContractDiscountsQueryBuilder(string name) : base(new Query<SubscriptionManualDiscountConnection>(name))
        {
            Arguments = new SubscriptionContractDiscountsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractDiscountsQueryBuilder(IQuery<SubscriptionManualDiscountConnection> query) : base(query)
        {
            Arguments = new SubscriptionContractDiscountsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractDiscountsQueryBuilder SetArguments(Action<SubscriptionContractDiscountsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionContractDiscountsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscountEdge>(query);
            return this;
        }

        public SubscriptionContractDiscountsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionContractDiscountsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}