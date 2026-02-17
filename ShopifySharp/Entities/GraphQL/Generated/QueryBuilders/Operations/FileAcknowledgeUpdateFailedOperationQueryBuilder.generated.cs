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

        public FileAcknowledgeUpdateFailedOperationQueryBuilder Files(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("files");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FileAcknowledgeUpdateFailedOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}