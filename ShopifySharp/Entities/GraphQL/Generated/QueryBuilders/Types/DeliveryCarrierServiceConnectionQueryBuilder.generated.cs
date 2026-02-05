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
    public sealed class DeliveryCarrierServiceConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceConnection, DeliveryCarrierServiceConnectionQueryBuilder>
    {
        protected override DeliveryCarrierServiceConnectionQueryBuilder Self => this;

        public DeliveryCarrierServiceConnectionQueryBuilder() : this("deliveryCarrierServiceConnection")
        {
        }

        public DeliveryCarrierServiceConnectionQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceConnection>(name))
        {
        }

        public DeliveryCarrierServiceConnectionQueryBuilder(IQuery<DeliveryCarrierServiceConnection> query) : base(query)
        {
        }

        public DeliveryCarrierServiceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierServiceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierServiceEdge>(query);
            return this;
        }

        public DeliveryCarrierServiceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public DeliveryCarrierServiceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}