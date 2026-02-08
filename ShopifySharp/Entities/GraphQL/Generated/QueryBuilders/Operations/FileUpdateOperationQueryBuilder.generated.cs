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
    public sealed class FileUpdateOperationQueryBuilder : FieldsQueryBuilderBase<FileUpdatePayload, FileUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<FileUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FileUpdateArgumentsBuilder Arguments { get; }
        protected override FileUpdateOperationQueryBuilder Self => this;

        public FileUpdateOperationQueryBuilder() : this("fileUpdate")
        {
        }

        public FileUpdateOperationQueryBuilder(string name) : base(new Query<FileUpdatePayload>(name))
        {
            Arguments = new FileUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FileUpdateOperationQueryBuilder(IQuery<FileUpdatePayload> query) : base(query)
        {
            Arguments = new FileUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FileUpdateOperationQueryBuilder Files(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("files");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FileUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}