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
    public sealed class DeliveryCustomizationConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationConnection, DeliveryCustomizationConnectionQueryBuilder>
    {
        protected override DeliveryCustomizationConnectionQueryBuilder Self => this;

        public DeliveryCustomizationConnectionQueryBuilder() : this("deliveryCustomizationConnection")
        {
        }

        public DeliveryCustomizationConnectionQueryBuilder(string name) : base(new Query<DeliveryCustomizationConnection>(name))
        {
        }

        public DeliveryCustomizationConnectionQueryBuilder(IQuery<DeliveryCustomizationConnection> query) : base(query)
        {
        }

        public DeliveryCustomizationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationEdge>(query);
            return this;
        }

        public DeliveryCustomizationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}