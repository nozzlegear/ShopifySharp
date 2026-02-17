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
    public sealed class CustomerAccountsV2QueryBuilder : FieldsQueryBuilderBase<CustomerAccountsV2, CustomerAccountsV2QueryBuilder>
    {
        protected override CustomerAccountsV2QueryBuilder Self => this;

        public CustomerAccountsV2QueryBuilder() : this("customerAccountsV2")
        {
        }

        public CustomerAccountsV2QueryBuilder(string name) : base(new Query<CustomerAccountsV2>(name))
        {
        }

        public CustomerAccountsV2QueryBuilder(IQuery<CustomerAccountsV2> query) : base(query)
        {
        }

        public CustomerAccountsV2QueryBuilder CustomerAccountsVersion()
        {
            base.InnerQuery.AddField("customerAccountsVersion");
            return this;
        }

        public CustomerAccountsV2QueryBuilder LoginLinksVisibleOnStorefrontAndCheckout()
        {
            base.InnerQuery.AddField("loginLinksVisibleOnStorefrontAndCheckout");
            return this;
        }

        public CustomerAccountsV2QueryBuilder LoginRequiredAtCheckout()
        {
            base.InnerQuery.AddField("loginRequiredAtCheckout");
            return this;
        }

        public CustomerAccountsV2QueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}