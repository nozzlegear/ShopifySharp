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
    public sealed class FinanceAppAccessPolicyQueryBuilder : FieldsQueryBuilderBase<FinanceAppAccessPolicy, FinanceAppAccessPolicyQueryBuilder>
    {
        protected override FinanceAppAccessPolicyQueryBuilder Self => this;

        public FinanceAppAccessPolicyQueryBuilder() : this("financeAppAccessPolicy")
        {
        }

        public FinanceAppAccessPolicyQueryBuilder(string name) : base(new Query<FinanceAppAccessPolicy>(name))
        {
        }

        public FinanceAppAccessPolicyQueryBuilder(IQuery<FinanceAppAccessPolicy> query) : base(query)
        {
        }

        public FinanceAppAccessPolicyQueryBuilder Access()
        {
            base.InnerQuery.AddField("access");
            return this;
        }
    }
}