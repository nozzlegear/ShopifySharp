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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class StagedUploadTargetQueryBuilder : FieldsQueryBuilderBase<StagedUploadTarget, StagedUploadTargetQueryBuilder>
    {
        protected override StagedUploadTargetQueryBuilder Self => this;

        public StagedUploadTargetQueryBuilder() : this("stagedUploadTarget")
        {
        }

        public StagedUploadTargetQueryBuilder(string name) : base(new Query<StagedUploadTarget>(name))
        {
        }

        public StagedUploadTargetQueryBuilder(IQuery<StagedUploadTarget> query) : base(query)
        {
        }

        public StagedUploadTargetQueryBuilder Parameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageUploadParameterQueryBuilder> build)
        {
            var query = new Query<ImageUploadParameter>("parameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageUploadParameterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageUploadParameter>(query);
            return this;
        }

        public StagedUploadTargetQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}