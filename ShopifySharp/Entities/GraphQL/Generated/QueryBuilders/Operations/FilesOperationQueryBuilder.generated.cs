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
    public sealed class FilesOperationQueryBuilder : FieldsQueryBuilderBase<FileConnection, FilesOperationQueryBuilder>, IGraphOperationQueryBuilder<FileConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public FilesArgumentsBuilder Arguments { get; }
        protected override FilesOperationQueryBuilder Self => this;

        public FilesOperationQueryBuilder() : this("files")
        {
        }

        public FilesOperationQueryBuilder(string name) : base(new Query<FileConnection>(name))
        {
            Arguments = new FilesArgumentsBuilder(base.InnerQuery);
        }

        public FilesOperationQueryBuilder(IQuery<FileConnection> query) : base(query)
        {
            Arguments = new FilesArgumentsBuilder(base.InnerQuery);
        }

        public FilesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileEdgeQueryBuilder> build)
        {
            var query = new Query<FileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileEdge>(query);
            return this;
        }

        public FilesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FilesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}