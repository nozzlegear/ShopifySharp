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
    public sealed class FileAcknowledgeUpdateFailedOperationQueryBuilder : FieldsQueryBuilderBase<FileAcknowledgeUpdateFailedPayload, FileAcknowledgeUpdateFailedOperationQueryBuilder>, IGraphOperationQueryBuilder<FileAcknowledgeUpdateFailedPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FileAcknowledgeUpdateFailedArgumentsBuilder Arguments { get; }
        protected override FileAcknowledgeUpdateFailedOperationQueryBuilder Self => this;

        public FileAcknowledgeUpdateFailedOperationQueryBuilder() : this("fileAcknowledgeUpdateFailed")
        {
        }

        public FileAcknowledgeUpdateFailedOperationQueryBuilder(string name) : base(new Query<FileAcknowledgeUpdateFailedPayload>(name))
        {
            Arguments = new FileAcknowledgeUpdateFailedArgumentsBuilder(base.InnerQuery);
        }

        public FileAcknowledgeUpdateFailedOperationQueryBuilder(IQuery<FileAcknowledgeUpdateFailedPayload> query) : base(query)
        {
            Arguments = new FileAcknowledgeUpdateFailedArgumentsBuilder(base.InnerQuery);
        }

        public FileAcknowledgeUpdateFailedOperationQueryBuilder Files(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("files");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FileAcknowledgeUpdateFailedOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}