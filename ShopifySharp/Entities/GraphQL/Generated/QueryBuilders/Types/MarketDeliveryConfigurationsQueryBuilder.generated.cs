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
    public sealed class MarketDeliveryConfigurationsQueryBuilder : FieldsQueryBuilderBase<MarketDeliveryConfigurations, MarketDeliveryConfigurationsQueryBuilder>
    {
        protected override MarketDeliveryConfigurationsQueryBuilder Self => this;

        public MarketDeliveryConfigurationsQueryBuilder() : this("marketDeliveryConfigurations")
        {
        }

        public MarketDeliveryConfigurationsQueryBuilder(string name) : base(new Query<MarketDeliveryConfigurations>(name))
        {
        }

        public MarketDeliveryConfigurationsQueryBuilder(IQuery<MarketDeliveryConfigurations> query) : base(query)
        {
        }

        public MarketDeliveryConfigurationsQueryBuilder Shipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingConfigurationQueryBuilder> build)
        {
            var query = new Query<ShippingConfiguration>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingConfiguration>(query);
            return this;
        }
    }
}