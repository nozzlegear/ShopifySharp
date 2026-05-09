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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ProductResourceFeedbackOperationQueryBuilder : FieldsQueryBuilderBase<ProductResourceFeedback, ProductResourceFeedbackOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductResourceFeedback>, IHasArguments<ProductResourceFeedbackArgumentsBuilder>
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

        public ProductResourceFeedbackOperationQueryBuilder SetArguments(Action<ProductResourceFeedbackArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductResourceFeedbackOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
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