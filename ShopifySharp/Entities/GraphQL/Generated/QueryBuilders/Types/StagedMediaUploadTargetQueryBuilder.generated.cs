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
    public sealed class StagedMediaUploadTargetQueryBuilder : FieldsQueryBuilderBase<StagedMediaUploadTarget, StagedMediaUploadTargetQueryBuilder>
    {
        protected override StagedMediaUploadTargetQueryBuilder Self => this;

        public StagedMediaUploadTargetQueryBuilder() : this("stagedMediaUploadTarget")
        {
        }

        public StagedMediaUploadTargetQueryBuilder(string name) : base(new Query<StagedMediaUploadTarget>(name))
        {
        }

        public StagedMediaUploadTargetQueryBuilder(IQuery<StagedMediaUploadTarget> query) : base(query)
        {
        }

        public StagedMediaUploadTargetQueryBuilder Parameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StagedUploadParameterQueryBuilder> build)
        {
            var query = new Query<StagedUploadParameter>("parameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StagedUploadParameterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StagedUploadParameter>(query);
            return this;
        }

        public StagedMediaUploadTargetQueryBuilder ResourceUrl()
        {
            base.InnerQuery.AddField("resourceUrl");
            return this;
        }

        public StagedMediaUploadTargetQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}