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
    public sealed class CheckoutAndAccountsConfigurationUserErrorQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationUserError, CheckoutAndAccountsConfigurationUserErrorQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationUserErrorQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder() : this("checkoutAndAccountsConfigurationUserError")
        {
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationUserError>(name))
        {
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder(IQuery<CheckoutAndAccountsConfigurationUserError> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public CheckoutAndAccountsConfigurationUserErrorQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }
    }
}