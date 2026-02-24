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
    public sealed class CalculatedOrderLineItemsQueryBuilder : FieldsQueryBuilderBase<CalculatedLineItemConnection, CalculatedOrderLineItemsQueryBuilder>, IHasArguments<CalculatedOrderLineItemsArgumentsBuilder>
    {
        public CalculatedOrderLineItemsArgumentsBuilder Arguments { get; }
        protected override CalculatedOrderLineItemsQueryBuilder Self => this;

        public CalculatedOrderLineItemsQueryBuilder(string name) : base(new Query<CalculatedLineItemConnection>(name))
        {
            Arguments = new CalculatedOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderLineItemsQueryBuilder(IQuery<CalculatedLineItemConnection> query) : base(query)
        {
            Arguments = new CalculatedOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderLineItemsQueryBuilder SetArguments(Action<CalculatedOrderLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CalculatedOrderLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItemEdge>(query);
            return this;
        }

        public CalculatedOrderLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public CalculatedOrderLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}