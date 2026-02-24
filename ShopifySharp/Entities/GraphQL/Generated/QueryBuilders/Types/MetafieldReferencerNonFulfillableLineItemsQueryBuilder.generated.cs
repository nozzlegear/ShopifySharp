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
    public sealed class MetafieldReferencerNonFulfillableLineItemsQueryBuilder : FieldsQueryBuilderBase<LineItemConnection, MetafieldReferencerNonFulfillableLineItemsQueryBuilder>, IHasArguments<MetafieldReferencerNonFulfillableLineItemsArgumentsBuilder>
    {
        public MetafieldReferencerNonFulfillableLineItemsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerNonFulfillableLineItemsQueryBuilder Self => this;

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder(string name) : base(new Query<LineItemConnection>(name))
        {
            Arguments = new MetafieldReferencerNonFulfillableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder(IQuery<LineItemConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerNonFulfillableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder SetArguments(Action<MetafieldReferencerNonFulfillableLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder> build)
        {
            var query = new Query<LineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemEdge>(query);
            return this;
        }

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public MetafieldReferencerNonFulfillableLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}