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
    public sealed class StagedUploadsCreatePayloadQueryBuilder : FieldsQueryBuilderBase<StagedUploadsCreatePayload, StagedUploadsCreatePayloadQueryBuilder>
    {
        protected override StagedUploadsCreatePayloadQueryBuilder Self => this;

        public StagedUploadsCreatePayloadQueryBuilder() : this("stagedUploadsCreatePayload")
        {
        }

        public StagedUploadsCreatePayloadQueryBuilder(string name) : base(new Query<StagedUploadsCreatePayload>(name))
        {
        }

        public StagedUploadsCreatePayloadQueryBuilder(IQuery<StagedUploadsCreatePayload> query) : base(query)
        {
        }

        public StagedUploadsCreatePayloadQueryBuilder StagedTargets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedMediaUploadTargetQueryBuilder> build)
        {
            var query = new Query<StagedMediaUploadTarget>("stagedTargets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedMediaUploadTargetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StagedMediaUploadTarget>(query);
            return this;
        }

        public StagedUploadsCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}