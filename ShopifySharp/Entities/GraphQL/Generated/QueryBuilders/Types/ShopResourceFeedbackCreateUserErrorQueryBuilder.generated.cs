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
    public sealed class ShopResourceFeedbackCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ShopResourceFeedbackCreateUserError, ShopResourceFeedbackCreateUserErrorQueryBuilder>
    {
        protected override ShopResourceFeedbackCreateUserErrorQueryBuilder Self => this;

        public ShopResourceFeedbackCreateUserErrorQueryBuilder() : this("shopResourceFeedbackCreateUserError")
        {
        }

        public ShopResourceFeedbackCreateUserErrorQueryBuilder(string name) : base(new Query<ShopResourceFeedbackCreateUserError>(name))
        {
        }

        public ShopResourceFeedbackCreateUserErrorQueryBuilder(IQuery<ShopResourceFeedbackCreateUserError> query) : base(query)
        {
        }

        public ShopResourceFeedbackCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShopResourceFeedbackCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ShopResourceFeedbackCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}