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
    public sealed class ShopResourceFeedbackCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ShopResourceFeedbackCreatePayload, ShopResourceFeedbackCreatePayloadQueryBuilder>
    {
        protected override ShopResourceFeedbackCreatePayloadQueryBuilder Self => this;

        public ShopResourceFeedbackCreatePayloadQueryBuilder() : this("shopResourceFeedbackCreatePayload")
        {
        }

        public ShopResourceFeedbackCreatePayloadQueryBuilder(string name) : base(new Query<ShopResourceFeedbackCreatePayload>(name))
        {
        }

        public ShopResourceFeedbackCreatePayloadQueryBuilder(IQuery<ShopResourceFeedbackCreatePayload> query) : base(query)
        {
        }

        public ShopResourceFeedbackCreatePayloadQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public ShopResourceFeedbackCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopResourceFeedbackCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopResourceFeedbackCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopResourceFeedbackCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopResourceFeedbackCreateUserError>(query);
            return this;
        }
    }
}