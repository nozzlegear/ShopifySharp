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
    public sealed class ReverseDeliveryConnectionQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryConnection, ReverseDeliveryConnectionQueryBuilder>
    {
        protected override ReverseDeliveryConnectionQueryBuilder Self => this;

        public ReverseDeliveryConnectionQueryBuilder() : this("reverseDeliveryConnection")
        {
        }

        public ReverseDeliveryConnectionQueryBuilder(string name) : base(new Query<ReverseDeliveryConnection>(name))
        {
        }

        public ReverseDeliveryConnectionQueryBuilder(IQuery<ReverseDeliveryConnection> query) : base(query)
        {
        }

        public ReverseDeliveryConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryEdge>(query);
            return this;
        }

        public ReverseDeliveryConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public ReverseDeliveryConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}