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
    public sealed class AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder : FieldsQueryBuilderBase<DiscountAllocationConnection, AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder>, IHasArguments<AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder>
    {
        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder Arguments { get; }
        protected override AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder Self => this;

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder(string name) : base(new Query<DiscountAllocationConnection>(name))
        {
            Arguments = new AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder(IQuery<DiscountAllocationConnection> query) : base(query)
        {
            Arguments = new AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder SetArguments(Action<AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAllocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocationEdge>(query);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DiscountAllocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocation>(query);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}