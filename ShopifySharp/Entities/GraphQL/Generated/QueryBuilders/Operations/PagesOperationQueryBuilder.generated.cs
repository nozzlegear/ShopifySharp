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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PagesOperationQueryBuilder : FieldsQueryBuilderBase<PageConnection, PagesOperationQueryBuilder>, IGraphOperationQueryBuilder<PageConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PagesArgumentsBuilder Arguments { get; }
        protected override PagesOperationQueryBuilder Self => this;

        public PagesOperationQueryBuilder() : this("pages")
        {
        }

        public PagesOperationQueryBuilder(string name) : base(new Query<PageConnection>(name))
        {
            Arguments = new PagesArgumentsBuilder(base.InnerQuery);
        }

        public PagesOperationQueryBuilder(IQuery<PageConnection> query) : base(query)
        {
            Arguments = new PagesArgumentsBuilder(base.InnerQuery);
        }

        public PagesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageEdgeQueryBuilder> build)
        {
            var query = new Query<PageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageEdge>(query);
            return this;
        }

        public PagesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public PagesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}