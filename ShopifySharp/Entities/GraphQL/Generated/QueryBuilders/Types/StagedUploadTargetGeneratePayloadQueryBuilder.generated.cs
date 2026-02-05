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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class StagedUploadTargetGeneratePayloadQueryBuilder : FieldsQueryBuilderBase<StagedUploadTargetGeneratePayload, StagedUploadTargetGeneratePayloadQueryBuilder>
    {
        protected override StagedUploadTargetGeneratePayloadQueryBuilder Self => this;

        public StagedUploadTargetGeneratePayloadQueryBuilder() : this("stagedUploadTargetGeneratePayload")
        {
        }

        public StagedUploadTargetGeneratePayloadQueryBuilder(string name) : base(new Query<StagedUploadTargetGeneratePayload>(name))
        {
        }

        public StagedUploadTargetGeneratePayloadQueryBuilder(IQuery<StagedUploadTargetGeneratePayload> query) : base(query)
        {
        }

        public StagedUploadTargetGeneratePayloadQueryBuilder Parameters(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder> build)
        {
            var query = new Query<MutationsStagedUploadTargetGenerateUploadParameter>("parameters");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MutationsStagedUploadTargetGenerateUploadParameter>(query);
            return this;
        }

        public StagedUploadTargetGeneratePayloadQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public StagedUploadTargetGeneratePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}