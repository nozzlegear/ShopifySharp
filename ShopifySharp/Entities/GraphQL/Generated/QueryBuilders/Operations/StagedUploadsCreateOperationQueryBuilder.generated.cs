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
    public sealed class StagedUploadsCreateOperationQueryBuilder : FieldsQueryBuilderBase<StagedUploadsCreatePayload, StagedUploadsCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<StagedUploadsCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StagedUploadsCreateArgumentsBuilder Arguments { get; }
        protected override StagedUploadsCreateOperationQueryBuilder Self => this;

        public StagedUploadsCreateOperationQueryBuilder() : this("stagedUploadsCreate")
        {
        }

        public StagedUploadsCreateOperationQueryBuilder(string name) : base(new Query<StagedUploadsCreatePayload>(name))
        {
            Arguments = new StagedUploadsCreateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadsCreateOperationQueryBuilder(IQuery<StagedUploadsCreatePayload> query) : base(query)
        {
            Arguments = new StagedUploadsCreateArgumentsBuilder(base.InnerQuery);
        }

        public StagedUploadsCreateOperationQueryBuilder StagedTargets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedMediaUploadTargetQueryBuilder> build)
        {
            var query = new Query<StagedMediaUploadTarget>("stagedTargets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StagedMediaUploadTargetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StagedMediaUploadTarget>(query);
            return this;
        }

        public StagedUploadsCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}