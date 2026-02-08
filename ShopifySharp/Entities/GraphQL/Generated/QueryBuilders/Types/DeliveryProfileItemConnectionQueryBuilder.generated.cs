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
    public sealed class DeliveryProfileItemConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileItemConnection, DeliveryProfileItemConnectionQueryBuilder>
    {
        protected override DeliveryProfileItemConnectionQueryBuilder Self => this;

        public DeliveryProfileItemConnectionQueryBuilder() : this("deliveryProfileItemConnection")
        {
        }

        public DeliveryProfileItemConnectionQueryBuilder(string name) : base(new Query<DeliveryProfileItemConnection>(name))
        {
        }

        public DeliveryProfileItemConnectionQueryBuilder(IQuery<DeliveryProfileItemConnection> query) : base(query)
        {
        }

        public DeliveryProfileItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItemEdge>(query);
            return this;
        }

        public DeliveryProfileItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItem>(query);
            return this;
        }

        public DeliveryProfileItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}