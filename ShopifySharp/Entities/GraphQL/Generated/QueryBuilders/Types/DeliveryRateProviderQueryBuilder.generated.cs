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
    public sealed class DeliveryRateProviderQueryBuilder : FieldsQueryBuilderBase<DeliveryRateProvider, DeliveryRateProviderQueryBuilder>
    {
        protected override DeliveryRateProviderQueryBuilder Self => this;

        public DeliveryRateProviderQueryBuilder() : this("deliveryRateProvider")
        {
        }

        public DeliveryRateProviderQueryBuilder(string name) : base(new Query<DeliveryRateProvider>(name))
        {
        }

        public DeliveryRateProviderQueryBuilder(IQuery<DeliveryRateProvider> query) : base(query)
        {
        }

        public DeliveryRateProviderQueryBuilder DeliveryRateProvider(Action<DeliveryRateProviderUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryRateProvider>("deliveryRateProvider");
            var unionBuilder = new DeliveryRateProviderUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}