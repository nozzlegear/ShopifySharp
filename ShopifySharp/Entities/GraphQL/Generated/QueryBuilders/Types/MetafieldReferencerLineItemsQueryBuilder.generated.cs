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
    public sealed class MetafieldReferencerLineItemsQueryBuilder : FieldsQueryBuilderBase<LineItemConnection, MetafieldReferencerLineItemsQueryBuilder>, IHasArguments<MetafieldReferencerLineItemsArgumentsBuilder>
    {
        public MetafieldReferencerLineItemsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerLineItemsQueryBuilder Self => this;

        public MetafieldReferencerLineItemsQueryBuilder(string name) : base(new Query<LineItemConnection>(name))
        {
            Arguments = new MetafieldReferencerLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLineItemsQueryBuilder(IQuery<LineItemConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLineItemsQueryBuilder SetArguments(Action<MetafieldReferencerLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder> build)
        {
            var query = new Query<LineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemEdge>(query);
            return this;
        }

        public MetafieldReferencerLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public MetafieldReferencerLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}