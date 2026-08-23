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
    public sealed class DeliveryWeightBasedOptionDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedOptionDefinition, DeliveryWeightBasedOptionDefinitionQueryBuilder>
    {
        protected override DeliveryWeightBasedOptionDefinitionQueryBuilder Self => this;

        public DeliveryWeightBasedOptionDefinitionQueryBuilder() : this("deliveryWeightBasedOptionDefinition")
        {
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder(string name) : base(new Query<DeliveryWeightBasedOptionDefinition>(name))
        {
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder(IQuery<DeliveryWeightBasedOptionDefinition> query) : base(query)
        {
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder FreeDeliveryMinimumValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("freeDeliveryMinimumValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder IncludedCollections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("includedCollections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder IncludedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("includedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionQueryBuilder RateGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroupConnection>("rateGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroupConnection>(query);
            return this;
        }
    }
}