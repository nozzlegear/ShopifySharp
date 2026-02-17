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
    public sealed class StagedUploadTargetGenerateOperationQueryBuilder : FieldsQueryBuilderBase<StagedUploadTargetGeneratePayload, StagedUploadTargetGenerateOperationQueryBuilder>, IGraphOperationQueryBuilder<StagedUploadTargetGeneratePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StagedUploadTargetGenerateArgumentsBuilder Arguments { get; }
        protected override StagedUploadTargetGenerateOperationQueryBuilder Self => this;

        public StagedUploadTargetGenerateOperationQueryBuilder() : this("stagedUploadTargetGenerate")
        {
        }

        public StagedUploadTargetGenerateOperationQueryBuilder(string name) : base(new Query<StagedUploadTargetGeneratePayload>(name))
        {
            Arguments = new StagedUploadTargetGenerateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadTargetGenerateOperationQueryBuilder(IQuery<StagedUploadTargetGeneratePayload> query) : base(query)
        {
            Arguments = new StagedUploadTargetGenerateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadTargetGenerateOperationQueryBuilder Parameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder> build)
        {
            var query = new Query<MutationsStagedUploadTargetGenerateUploadParameter>("parameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MutationsStagedUploadTargetGenerateUploadParameter>(query);
            return this;
        }

        public StagedUploadTargetGenerateOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public StagedUploadTargetGenerateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}