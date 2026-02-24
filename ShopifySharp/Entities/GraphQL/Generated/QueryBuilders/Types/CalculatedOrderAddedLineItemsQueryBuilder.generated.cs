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
    public sealed class CalculatedOrderAddedLineItemsQueryBuilder : FieldsQueryBuilderBase<CalculatedLineItemConnection, CalculatedOrderAddedLineItemsQueryBuilder>, IHasArguments<CalculatedOrderAddedLineItemsArgumentsBuilder>
    {
        public CalculatedOrderAddedLineItemsArgumentsBuilder Arguments { get; }
        protected override CalculatedOrderAddedLineItemsQueryBuilder Self => this;

        public CalculatedOrderAddedLineItemsQueryBuilder(string name) : base(new Query<CalculatedLineItemConnection>(name))
        {
            Arguments = new CalculatedOrderAddedLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderAddedLineItemsQueryBuilder(IQuery<CalculatedLineItemConnection> query) : base(query)
        {
            Arguments = new CalculatedOrderAddedLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderAddedLineItemsQueryBuilder SetArguments(Action<CalculatedOrderAddedLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CalculatedOrderAddedLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItemEdge>(query);
            return this;
        }

        public CalculatedOrderAddedLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public CalculatedOrderAddedLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}