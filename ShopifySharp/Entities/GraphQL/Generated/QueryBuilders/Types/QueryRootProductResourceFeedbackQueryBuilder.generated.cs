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
    public sealed class QueryRootProductResourceFeedbackQueryBuilder : FieldsQueryBuilderBase<ProductResourceFeedback, QueryRootProductResourceFeedbackQueryBuilder>, IHasArguments<QueryRootProductResourceFeedbackArgumentsBuilder>
    {
        public QueryRootProductResourceFeedbackArgumentsBuilder Arguments { get; }
        protected override QueryRootProductResourceFeedbackQueryBuilder Self => this;

        public QueryRootProductResourceFeedbackQueryBuilder(string name) : base(new Query<ProductResourceFeedback>(name))
        {
            Arguments = new QueryRootProductResourceFeedbackArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductResourceFeedbackQueryBuilder(IQuery<ProductResourceFeedback> query) : base(query)
        {
            Arguments = new QueryRootProductResourceFeedbackArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductResourceFeedbackQueryBuilder SetArguments(Action<QueryRootProductResourceFeedbackArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductResourceFeedbackQueryBuilder FeedbackGeneratedAt()
        {
            base.InnerQuery.AddField("feedbackGeneratedAt");
            return this;
        }

        public QueryRootProductResourceFeedbackQueryBuilder Messages()
        {
            base.InnerQuery.AddField("messages");
            return this;
        }

        public QueryRootProductResourceFeedbackQueryBuilder ProductId()
        {
            base.InnerQuery.AddField("productId");
            return this;
        }

        public QueryRootProductResourceFeedbackQueryBuilder ProductUpdatedAt()
        {
            base.InnerQuery.AddField("productUpdatedAt");
            return this;
        }

        public QueryRootProductResourceFeedbackQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}