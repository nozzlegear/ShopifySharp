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