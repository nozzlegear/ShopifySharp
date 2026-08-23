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
    public sealed class DeliveryCarrierCalculatedOptionDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierCalculatedOptionDefinition, DeliveryCarrierCalculatedOptionDefinitionQueryBuilder>
    {
        protected override DeliveryCarrierCalculatedOptionDefinitionQueryBuilder Self => this;

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder() : this("deliveryCarrierCalculatedOptionDefinition")
        {
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder(string name) : base(new Query<DeliveryCarrierCalculatedOptionDefinition>(name))
        {
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder(IQuery<DeliveryCarrierCalculatedOptionDefinition> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder FreeDeliveryMinimumValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("freeDeliveryMinimumValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder IncludedCollections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("includedCollections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder IncludedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("includedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionQueryBuilder RateGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedRateGroupConnection>("rateGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierCalculatedRateGroupConnection>(query);
            return this;
        }
    }
}