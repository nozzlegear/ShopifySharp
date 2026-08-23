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
    public sealed class DeliveryOptionDefinitionQueryBuilder : FieldsQueryBuilderBase<IDeliveryOptionDefinition, DeliveryOptionDefinitionQueryBuilder>
    {
        protected override DeliveryOptionDefinitionQueryBuilder Self => this;

        public DeliveryOptionDefinitionQueryBuilder() : this("deliveryOptionDefinition")
        {
        }

        public DeliveryOptionDefinitionQueryBuilder(string name) : base(new Query<IDeliveryOptionDefinition>(name))
        {
        }

        public DeliveryOptionDefinitionQueryBuilder(IQuery<IDeliveryOptionDefinition> query) : base(query)
        {
        }

        public DeliveryOptionDefinitionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder FreeDeliveryMinimumValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("freeDeliveryMinimumValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder IncludedCollections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("includedCollections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder IncludedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("includedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder OnDeliveryCarrierCalculatedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedOptionDefinition>("... on DeliveryCarrierCalculatedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder OnDeliveryFlatRateOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateOptionDefinition>("... on DeliveryFlatRateOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder OnDeliveryValueBasedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedOptionDefinition>("... on DeliveryValueBasedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder OnDeliveryWeightBasedOptionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedOptionDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedOptionDefinition>("... on DeliveryWeightBasedOptionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedOptionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DeliveryOptionDefinitionQueryBuilder DeliveryOptionDefinition(Action<DeliveryOptionDefinitionInterfaceCasesBuilder> build)
        {
            var query = new Query<IDeliveryOptionDefinition>("deliveryOptionDefinition");
            var unionBuilder = new DeliveryOptionDefinitionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}