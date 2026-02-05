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
    public sealed class StagedUploadTargetsGeneratePayloadQueryBuilder : FieldsQueryBuilderBase<StagedUploadTargetsGeneratePayload, StagedUploadTargetsGeneratePayloadQueryBuilder>
    {
        protected override StagedUploadTargetsGeneratePayloadQueryBuilder Self => this;

        public StagedUploadTargetsGeneratePayloadQueryBuilder() : this("stagedUploadTargetsGeneratePayload")
        {
        }

        public StagedUploadTargetsGeneratePayloadQueryBuilder(string name) : base(new Query<StagedUploadTargetsGeneratePayload>(name))
        {
        }

        public StagedUploadTargetsGeneratePayloadQueryBuilder(IQuery<StagedUploadTargetsGeneratePayload> query) : base(query)
        {
        }

        public StagedUploadTargetsGeneratePayloadQueryBuilder Urls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedUploadTargetQueryBuilder> build)
        {
            var query = new Query<StagedUploadTarget>("urls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedUploadTargetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StagedUploadTarget>(query);
            return this;
        }

        public StagedUploadTargetsGeneratePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}