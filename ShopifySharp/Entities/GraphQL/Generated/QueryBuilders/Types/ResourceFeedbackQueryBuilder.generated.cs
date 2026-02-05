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
    public sealed class ResourceFeedbackQueryBuilder : FieldsQueryBuilderBase<ResourceFeedback, ResourceFeedbackQueryBuilder>
    {
        protected override ResourceFeedbackQueryBuilder Self => this;

        public ResourceFeedbackQueryBuilder() : this("resourceFeedback")
        {
        }

        public ResourceFeedbackQueryBuilder(string name) : base(new Query<ResourceFeedback>(name))
        {
        }

        public ResourceFeedbackQueryBuilder(IQuery<ResourceFeedback> query) : base(query)
        {
        }

        public ResourceFeedbackQueryBuilder AppFeedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("appFeedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public ResourceFeedbackQueryBuilder Details(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("details");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public ResourceFeedbackQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }
    }
}