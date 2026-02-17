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
    public sealed class ShopResourceFeedbackCreateOperationQueryBuilder : FieldsQueryBuilderBase<ShopResourceFeedbackCreatePayload, ShopResourceFeedbackCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopResourceFeedbackCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopResourceFeedbackCreateArgumentsBuilder Arguments { get; }
        protected override ShopResourceFeedbackCreateOperationQueryBuilder Self => this;

        public ShopResourceFeedbackCreateOperationQueryBuilder() : this("shopResourceFeedbackCreate")
        {
        }

        public ShopResourceFeedbackCreateOperationQueryBuilder(string name) : base(new Query<ShopResourceFeedbackCreatePayload>(name))
        {
            Arguments = new ShopResourceFeedbackCreateArgumentsBuilder(base.InnerQuery);
        }

        public ShopResourceFeedbackCreateOperationQueryBuilder(IQuery<ShopResourceFeedbackCreatePayload> query) : base(query)
        {
            Arguments = new ShopResourceFeedbackCreateArgumentsBuilder(base.InnerQuery);
        }

        public ShopResourceFeedbackCreateOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public ShopResourceFeedbackCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopResourceFeedbackCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopResourceFeedbackCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopResourceFeedbackCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopResourceFeedbackCreateUserError>(query);
            return this;
        }
    }
}