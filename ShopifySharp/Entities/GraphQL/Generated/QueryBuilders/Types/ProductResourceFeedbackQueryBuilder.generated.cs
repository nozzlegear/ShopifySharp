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
    public sealed class ProductResourceFeedbackQueryBuilder : FieldsQueryBuilderBase<ProductResourceFeedback, ProductResourceFeedbackQueryBuilder>
    {
        protected override ProductResourceFeedbackQueryBuilder Self => this;

        public ProductResourceFeedbackQueryBuilder() : this("productResourceFeedback")
        {
        }

        public ProductResourceFeedbackQueryBuilder(string name) : base(new Query<ProductResourceFeedback>(name))
        {
        }

        public ProductResourceFeedbackQueryBuilder(IQuery<ProductResourceFeedback> query) : base(query)
        {
        }

        public ProductResourceFeedbackQueryBuilder FeedbackGeneratedAt()
        {
            base.InnerQuery.AddField("feedbackGeneratedAt");
            return this;
        }

        public ProductResourceFeedbackQueryBuilder Messages()
        {
            base.InnerQuery.AddField("messages");
            return this;
        }

        public ProductResourceFeedbackQueryBuilder ProductId()
        {
            base.InnerQuery.AddField("productId");
            return this;
        }

        public ProductResourceFeedbackQueryBuilder ProductUpdatedAt()
        {
            base.InnerQuery.AddField("productUpdatedAt");
            return this;
        }

        public ProductResourceFeedbackQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}