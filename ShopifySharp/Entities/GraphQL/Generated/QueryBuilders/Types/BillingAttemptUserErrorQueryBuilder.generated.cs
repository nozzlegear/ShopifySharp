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
    public sealed class BillingAttemptUserErrorQueryBuilder : FieldsQueryBuilderBase<BillingAttemptUserError, BillingAttemptUserErrorQueryBuilder>
    {
        protected override BillingAttemptUserErrorQueryBuilder Self => this;

        public BillingAttemptUserErrorQueryBuilder() : this("billingAttemptUserError")
        {
        }

        public BillingAttemptUserErrorQueryBuilder(string name) : base(new Query<BillingAttemptUserError>(name))
        {
        }

        public BillingAttemptUserErrorQueryBuilder(IQuery<BillingAttemptUserError> query) : base(query)
        {
        }

        public BillingAttemptUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BillingAttemptUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BillingAttemptUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}