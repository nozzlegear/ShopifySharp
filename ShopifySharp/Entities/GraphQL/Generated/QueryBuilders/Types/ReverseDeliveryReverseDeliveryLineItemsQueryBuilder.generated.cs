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
    public sealed class ReverseDeliveryReverseDeliveryLineItemsQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryLineItemConnection, ReverseDeliveryReverseDeliveryLineItemsQueryBuilder>, IHasArguments<ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder>
    {
        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder Arguments { get; }
        protected override ReverseDeliveryReverseDeliveryLineItemsQueryBuilder Self => this;

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder(string name) : base(new Query<ReverseDeliveryLineItemConnection>(name))
        {
            Arguments = new ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder(IQuery<ReverseDeliveryLineItemConnection> query) : base(query)
        {
            Arguments = new ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder SetArguments(Action<ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItemEdge>(query);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItem>(query);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}