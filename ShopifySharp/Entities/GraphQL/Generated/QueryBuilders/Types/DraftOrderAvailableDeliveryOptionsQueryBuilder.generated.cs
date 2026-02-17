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
    public sealed class DraftOrderAvailableDeliveryOptionsQueryBuilder : FieldsQueryBuilderBase<DraftOrderAvailableDeliveryOptions, DraftOrderAvailableDeliveryOptionsQueryBuilder>
    {
        protected override DraftOrderAvailableDeliveryOptionsQueryBuilder Self => this;

        public DraftOrderAvailableDeliveryOptionsQueryBuilder() : this("draftOrderAvailableDeliveryOptions")
        {
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder(string name) : base(new Query<DraftOrderAvailableDeliveryOptions>(name))
        {
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder(IQuery<DraftOrderAvailableDeliveryOptions> query) : base(query)
        {
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder AvailableLocalDeliveryRates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder> build)
        {
            var query = new Query<DraftOrderShippingRate>("availableLocalDeliveryRates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderShippingRate>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder AvailableLocalPickupOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PickupInStoreLocationQueryBuilder> build)
        {
            var query = new Query<PickupInStoreLocation>("availableLocalPickupOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PickupInStoreLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PickupInStoreLocation>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder AvailableShippingRates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder> build)
        {
            var query = new Query<DraftOrderShippingRate>("availableShippingRates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderShippingRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderShippingRate>(query);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}