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
    public sealed class DeliveryFlatRateOptionDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRateOptionDefinition, DeliveryFlatRateOptionDefinitionQueryBuilder>
    {
        protected override DeliveryFlatRateOptionDefinitionQueryBuilder Self => this;

        public DeliveryFlatRateOptionDefinitionQueryBuilder() : this("deliveryFlatRateOptionDefinition")
        {
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder(string name) : base(new Query<DeliveryFlatRateOptionDefinition>(name))
        {
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder(IQuery<DeliveryFlatRateOptionDefinition> query) : base(query)
        {
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder FreeDeliveryMinimumValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("freeDeliveryMinimumValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder IncludedCollections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("includedCollections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder IncludedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("includedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryFlatRateOptionDefinitionQueryBuilder RateGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroupConnection>("rateGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroupConnection>(query);
            return this;
        }
    }
}