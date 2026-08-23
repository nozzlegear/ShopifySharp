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
    public sealed class ShippingConfigurationQueryBuilder : FieldsQueryBuilderBase<ShippingConfiguration, ShippingConfigurationQueryBuilder>
    {
        protected override ShippingConfigurationQueryBuilder Self => this;

        public ShippingConfigurationQueryBuilder() : this("shippingConfiguration")
        {
        }

        public ShippingConfigurationQueryBuilder(string name) : base(new Query<ShippingConfiguration>(name))
        {
        }

        public ShippingConfigurationQueryBuilder(IQuery<ShippingConfiguration> query) : base(query)
        {
        }

        public ShippingConfigurationQueryBuilder IsEnabled()
        {
            base.InnerQuery.AddField("isEnabled");
            return this;
        }

        public ShippingConfigurationQueryBuilder OptionDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryOptionDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryOptionDefinitionConnection>("optionDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryOptionDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryOptionDefinitionConnection>(query);
            return this;
        }

        public ShippingConfigurationQueryBuilder OptionDefinitionsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("optionDefinitionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }
    }
}