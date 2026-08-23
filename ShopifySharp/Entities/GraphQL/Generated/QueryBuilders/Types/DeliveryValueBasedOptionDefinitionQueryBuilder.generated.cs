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
    public sealed class DeliveryValueBasedOptionDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedOptionDefinition, DeliveryValueBasedOptionDefinitionQueryBuilder>
    {
        protected override DeliveryValueBasedOptionDefinitionQueryBuilder Self => this;

        public DeliveryValueBasedOptionDefinitionQueryBuilder() : this("deliveryValueBasedOptionDefinition")
        {
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder(string name) : base(new Query<DeliveryValueBasedOptionDefinition>(name))
        {
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder(IQuery<DeliveryValueBasedOptionDefinition> query) : base(query)
        {
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder FreeDeliveryMinimumValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("freeDeliveryMinimumValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder IncludedCollections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("includedCollections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder IncludedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("includedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryValueBasedOptionDefinitionQueryBuilder RateGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroupConnection>("rateGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroupConnection>(query);
            return this;
        }
    }
}