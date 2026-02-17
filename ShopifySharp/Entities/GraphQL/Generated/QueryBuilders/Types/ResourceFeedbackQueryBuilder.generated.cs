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

        public ResourceFeedbackQueryBuilder AppFeedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("appFeedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public ResourceFeedbackQueryBuilder Details(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("details");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
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