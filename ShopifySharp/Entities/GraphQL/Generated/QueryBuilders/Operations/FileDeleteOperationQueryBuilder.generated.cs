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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FileDeleteOperationQueryBuilder : FieldsQueryBuilderBase<FileDeletePayload, FileDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<FileDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FileDeleteArgumentsBuilder Arguments { get; }
        protected override FileDeleteOperationQueryBuilder Self => this;

        public FileDeleteOperationQueryBuilder() : this("fileDelete")
        {
        }

        public FileDeleteOperationQueryBuilder(string name) : base(new Query<FileDeletePayload>(name))
        {
            Arguments = new FileDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FileDeleteOperationQueryBuilder(IQuery<FileDeletePayload> query) : base(query)
        {
            Arguments = new FileDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FileDeleteOperationQueryBuilder DeletedFileIds()
        {
            base.InnerQuery.AddField("deletedFileIds");
            return this;
        }

        public FileDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}