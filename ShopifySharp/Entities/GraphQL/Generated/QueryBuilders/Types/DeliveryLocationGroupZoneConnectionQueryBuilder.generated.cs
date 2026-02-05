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
    public sealed class DeliveryLocationGroupZoneConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryLocationGroupZoneConnection, DeliveryLocationGroupZoneConnectionQueryBuilder>
    {
        protected override DeliveryLocationGroupZoneConnectionQueryBuilder Self => this;

        public DeliveryLocationGroupZoneConnectionQueryBuilder() : this("deliveryLocationGroupZoneConnection")
        {
        }

        public DeliveryLocationGroupZoneConnectionQueryBuilder(string name) : base(new Query<DeliveryLocationGroupZoneConnection>(name))
        {
        }

        public DeliveryLocationGroupZoneConnectionQueryBuilder(IQuery<DeliveryLocationGroupZoneConnection> query) : base(query)
        {
        }

        public DeliveryLocationGroupZoneConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroupZoneEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroupZoneEdge>(query);
            return this;
        }

        public DeliveryLocationGroupZoneConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroupZone>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroupZone>(query);
            return this;
        }

        public DeliveryLocationGroupZoneConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}