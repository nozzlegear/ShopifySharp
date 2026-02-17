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
    [Obsolete("Use `stagedUploadsCreate` instead.")]
    public sealed class StagedUploadTargetsGenerateOperationQueryBuilder : FieldsQueryBuilderBase<StagedUploadTargetsGeneratePayload, StagedUploadTargetsGenerateOperationQueryBuilder>, IGraphOperationQueryBuilder<StagedUploadTargetsGeneratePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StagedUploadTargetsGenerateArgumentsBuilder Arguments { get; }
        protected override StagedUploadTargetsGenerateOperationQueryBuilder Self => this;

        public StagedUploadTargetsGenerateOperationQueryBuilder() : this("stagedUploadTargetsGenerate")
        {
        }

        public StagedUploadTargetsGenerateOperationQueryBuilder(string name) : base(new Query<StagedUploadTargetsGeneratePayload>(name))
        {
            Arguments = new StagedUploadTargetsGenerateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadTargetsGenerateOperationQueryBuilder(IQuery<StagedUploadTargetsGeneratePayload> query) : base(query)
        {
            Arguments = new StagedUploadTargetsGenerateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadTargetsGenerateOperationQueryBuilder Urls(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StagedUploadTargetQueryBuilder> build)
        {
            var query = new Query<StagedUploadTarget>("urls");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StagedUploadTargetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StagedUploadTarget>(query);
            return this;
        }

        public StagedUploadTargetsGenerateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}