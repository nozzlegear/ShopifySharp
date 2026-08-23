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
    public sealed class DeliveryOptionDefinitionInterfaceCasesBuilder : InterfaceCasesBuilderBase<IDeliveryOptionDefinition, DeliveryOptionDefinitionInterfaceCasesBuilder>
    {
        protected override DeliveryOptionDefinitionInterfaceCasesBuilder Self => this;

        public DeliveryOptionDefinitionInterfaceCasesBuilder(string fieldName = "node") : this(new Query<IDeliveryOptionDefinition>(fieldName))
        {
        }

        public DeliveryOptionDefinitionInterfaceCasesBuilder(IQuery<IDeliveryOptionDefinition> query) : base(query)
        {
        }

        public DeliveryOptionDefinitionInterfaceCasesBuilder OnDeliveryCarrierCalculatedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedOptionDefinition>("... on DeliveryCarrierCalculatedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryOptionDefinitionInterfaceCasesBuilder OnDeliveryFlatRateOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateOptionDefinition>("... on DeliveryFlatRateOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryOptionDefinitionInterfaceCasesBuilder OnDeliveryValueBasedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedOptionDefinition>("... on DeliveryValueBasedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryOptionDefinitionInterfaceCasesBuilder OnDeliveryWeightBasedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedOptionDefinition>("... on DeliveryWeightBasedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}