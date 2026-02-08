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
    public sealed class AppFeedbackQueryBuilder : FieldsQueryBuilderBase<AppFeedback, AppFeedbackQueryBuilder>
    {
        protected override AppFeedbackQueryBuilder Self => this;

        public AppFeedbackQueryBuilder() : this("appFeedback")
        {
        }

        public AppFeedbackQueryBuilder(string name) : base(new Query<AppFeedback>(name))
        {
        }

        public AppFeedbackQueryBuilder(IQuery<AppFeedback> query) : base(query)
        {
        }

        public AppFeedbackQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppFeedbackQueryBuilder FeedbackGeneratedAt()
        {
            base.InnerQuery.AddField("feedbackGeneratedAt");
            return this;
        }

        public AppFeedbackQueryBuilder Link(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LinkQueryBuilder> build)
        {
            var query = new Query<Link>("link");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LinkQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Link>(query);
            return this;
        }

        public AppFeedbackQueryBuilder Messages(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("messages");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public AppFeedbackQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}