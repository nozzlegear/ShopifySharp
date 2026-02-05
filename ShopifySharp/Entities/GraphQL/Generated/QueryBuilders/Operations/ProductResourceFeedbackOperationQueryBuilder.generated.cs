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
    public sealed class ProductResourceFeedbackOperationQueryBuilder : FieldsQueryBuilderBase<ProductResourceFeedback, ProductResourceFeedbackOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductResourceFeedback>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductResourceFeedbackArgumentsBuilder Arguments { get; }
        protected override ProductResourceFeedbackOperationQueryBuilder Self => this;

        public ProductResourceFeedbackOperationQueryBuilder() : this("productResourceFeedback")
        {
        }

        public ProductResourceFeedbackOperationQueryBuilder(string name) : base(new Query<ProductResourceFeedback>(name))
        {
            Arguments = new ProductResourceFeedbackArgumentsBuilder(base.InnerQuery);
        }

        public ProductResourceFeedbackOperationQueryBuilder(IQuery<ProductResourceFeedback> query) : base(query)
        {
            Arguments = new ProductResourceFeedbackArgumentsBuilder(base.InnerQuery);
        }

        public ProductResourceFeedbackOperationQueryBuilder FeedbackGeneratedAt()
        {
            base.InnerQuery.AddField("feedbackGeneratedAt");
            return this;
        }

        public ProductResourceFeedbackOperationQueryBuilder Messages()
        {
            base.InnerQuery.AddField("messages");
            return this;
        }

        public ProductResourceFeedbackOperationQueryBuilder ProductId()
        {
            base.InnerQuery.AddField("productId");
            return this;
        }

        public ProductResourceFeedbackOperationQueryBuilder ProductUpdatedAt()
        {
            base.InnerQuery.AddField("productUpdatedAt");
            return this;
        }

        public ProductResourceFeedbackOperationQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}