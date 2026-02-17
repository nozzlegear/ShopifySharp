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
    public sealed class ReverseDeliveryLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryLineItemConnection, ReverseDeliveryLineItemConnectionQueryBuilder>
    {
        protected override ReverseDeliveryLineItemConnectionQueryBuilder Self => this;

        public ReverseDeliveryLineItemConnectionQueryBuilder() : this("reverseDeliveryLineItemConnection")
        {
        }

        public ReverseDeliveryLineItemConnectionQueryBuilder(string name) : base(new Query<ReverseDeliveryLineItemConnection>(name))
        {
        }

        public ReverseDeliveryLineItemConnectionQueryBuilder(IQuery<ReverseDeliveryLineItemConnection> query) : base(query)
        {
        }

        public ReverseDeliveryLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItemEdge>(query);
            return this;
        }

        public ReverseDeliveryLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItem>(query);
            return this;
        }

        public ReverseDeliveryLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}