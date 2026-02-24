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
    public sealed class LineItemConnectionQueryBuilder : FieldsQueryBuilderBase<LineItemConnection, LineItemConnectionQueryBuilder>, IHasArguments<LineItemConnectionArgumentsBuilder>
    {
        public LineItemConnectionArgumentsBuilder Arguments { get; }
        protected override LineItemConnectionQueryBuilder Self => this;

        public LineItemConnectionQueryBuilder() : this("lineItemConnection")
        {
        }

        public LineItemConnectionQueryBuilder(string name) : base(new Query<LineItemConnection>(name))
        {
            Arguments = new LineItemConnectionArgumentsBuilder(base.InnerQuery);
        }

        public LineItemConnectionQueryBuilder(IQuery<LineItemConnection> query) : base(query)
        {
            Arguments = new LineItemConnectionArgumentsBuilder(base.InnerQuery);
        }

        public LineItemConnectionQueryBuilder SetArguments(Action<LineItemConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public LineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder> build)
        {
            var query = new Query<LineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemEdge>(query);
            return this;
        }

        public LineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public LineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}