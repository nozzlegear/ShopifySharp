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
    public sealed class QueryRootFilesQueryBuilder : FieldsQueryBuilderBase<FileConnection, QueryRootFilesQueryBuilder>, IHasArguments<QueryRootFilesArgumentsBuilder>
    {
        public QueryRootFilesArgumentsBuilder Arguments { get; }
        protected override QueryRootFilesQueryBuilder Self => this;

        public QueryRootFilesQueryBuilder(string name) : base(new Query<FileConnection>(name))
        {
            Arguments = new QueryRootFilesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFilesQueryBuilder(IQuery<FileConnection> query) : base(query)
        {
            Arguments = new QueryRootFilesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFilesQueryBuilder SetArguments(Action<QueryRootFilesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootFilesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileEdgeQueryBuilder> build)
        {
            var query = new Query<FileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileEdge>(query);
            return this;
        }

        public QueryRootFilesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public QueryRootFilesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}