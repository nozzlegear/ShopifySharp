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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DraftOrderAvailableDeliveryOptionsOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderAvailableDeliveryOptions, DraftOrderAvailableDeliveryOptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderAvailableDeliveryOptions>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder Arguments { get; }
        protected override DraftOrderAvailableDeliveryOptionsOperationQueryBuilder Self => this;

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder() : this("draftOrderAvailableDeliveryOptions")
        {
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder(string name) : base(new Query<DraftOrderAvailableDeliveryOptions>(name))
        {
            Arguments = new DraftOrderAvailableDeliveryOptionsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder(IQuery<DraftOrderAvailableDeliveryOptions> query) : base(query)
        {
            Arguments = new DraftOrderAvailableDeliveryOptionsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder AvailableLocalDeliveryRates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder> build)
        {
            var query = new Query<DraftOrderShippingRate>("availableLocalDeliveryRates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderShippingRate>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder AvailableLocalPickupOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PickupInStoreLocationQueryBuilder> build)
        {
            var query = new Query<PickupInStoreLocation>("availableLocalPickupOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PickupInStoreLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PickupInStoreLocation>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder AvailableShippingRates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder> build)
        {
            var query = new Query<DraftOrderShippingRate>("availableShippingRates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderShippingRate>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}