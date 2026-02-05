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
    public sealed class DeliveryRateProviderUnionCasesBuilder : UnionCasesBuilderBase<DeliveryRateProvider, DeliveryRateProviderUnionCasesBuilder>
    {
        protected override DeliveryRateProviderUnionCasesBuilder Self => this;

        public DeliveryRateProviderUnionCasesBuilder(string fieldName = "deliveryRateProvider") : this(new Query<DeliveryRateProvider>(fieldName))
        {
        }

        public DeliveryRateProviderUnionCasesBuilder(IQuery<DeliveryRateProvider> query) : base(query)
        {
        }

        public DeliveryRateProviderUnionCasesBuilder OnDeliveryParticipant(Action<DeliveryParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryParticipant>("... on DeliveryParticipant");
            var queryBuilder = new DeliveryParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryRateProviderUnionCasesBuilder OnDeliveryRateDefinition(Action<DeliveryRateDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryRateDefinition>("... on DeliveryRateDefinition");
            var queryBuilder = new DeliveryRateDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}