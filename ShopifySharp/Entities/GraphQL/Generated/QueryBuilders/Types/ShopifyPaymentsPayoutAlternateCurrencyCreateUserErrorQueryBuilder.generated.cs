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
    public sealed class ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError, ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder Self => this;

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder() : this("shopifyPaymentsPayoutAlternateCurrencyCreateUserError")
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>(name))
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder(IQuery<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}