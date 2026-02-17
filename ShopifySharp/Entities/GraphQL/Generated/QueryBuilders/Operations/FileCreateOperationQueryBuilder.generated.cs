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
    public sealed class FileCreateOperationQueryBuilder : FieldsQueryBuilderBase<FileCreatePayload, FileCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<FileCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FileCreateArgumentsBuilder Arguments { get; }
        protected override FileCreateOperationQueryBuilder Self => this;

        public FileCreateOperationQueryBuilder() : this("fileCreate")
        {
        }

        public FileCreateOperationQueryBuilder(string name) : base(new Query<FileCreatePayload>(name))
        {
            Arguments = new FileCreateArgumentsBuilder(base.InnerQuery);
        }

        public FileCreateOperationQueryBuilder(IQuery<FileCreatePayload> query) : base(query)
        {
            Arguments = new FileCreateArgumentsBuilder(base.InnerQuery);
        }

        public FileCreateOperationQueryBuilder Files(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("files");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FileCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}