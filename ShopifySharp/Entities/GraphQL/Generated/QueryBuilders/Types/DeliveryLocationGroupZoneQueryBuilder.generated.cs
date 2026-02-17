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
    public sealed class DeliveryLocationGroupZoneQueryBuilder : FieldsQueryBuilderBase<DeliveryLocationGroupZone, DeliveryLocationGroupZoneQueryBuilder>
    {
        protected override DeliveryLocationGroupZoneQueryBuilder Self => this;

        public DeliveryLocationGroupZoneQueryBuilder() : this("deliveryLocationGroupZone")
        {
        }

        public DeliveryLocationGroupZoneQueryBuilder(string name) : base(new Query<DeliveryLocationGroupZone>(name))
        {
        }

        public DeliveryLocationGroupZoneQueryBuilder(IQuery<DeliveryLocationGroupZone> query) : base(query)
        {
        }

        public DeliveryLocationGroupZoneQueryBuilder MethodDefinitionCounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionCountsQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinitionCounts>("methodDefinitionCounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionCountsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinitionCounts>(query);
            return this;
        }

        public DeliveryLocationGroupZoneQueryBuilder MethodDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinitionConnection>("methodDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinitionConnection>(query);
            return this;
        }

        public DeliveryLocationGroupZoneQueryBuilder Zone(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryZone>("zone");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryZone>(query);
            return this;
        }
    }
}