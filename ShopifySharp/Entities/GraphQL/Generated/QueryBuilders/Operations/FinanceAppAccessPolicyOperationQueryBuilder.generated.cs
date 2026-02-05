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
    public sealed class FinanceAppAccessPolicyOperationQueryBuilder : FieldsQueryBuilderBase<FinanceAppAccessPolicy, FinanceAppAccessPolicyOperationQueryBuilder>, IGraphOperationQueryBuilder<FinanceAppAccessPolicy>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override FinanceAppAccessPolicyOperationQueryBuilder Self => this;

        public FinanceAppAccessPolicyOperationQueryBuilder() : this("financeAppAccessPolicy")
        {
        }

        public FinanceAppAccessPolicyOperationQueryBuilder(string name) : base(new Query<FinanceAppAccessPolicy>(name))
        {
        }

        public FinanceAppAccessPolicyOperationQueryBuilder(IQuery<FinanceAppAccessPolicy> query) : base(query)
        {
        }

        public FinanceAppAccessPolicyOperationQueryBuilder Access()
        {
            base.InnerQuery.AddField("access");
            return this;
        }
    }
}