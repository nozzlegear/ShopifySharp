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
    public sealed class CashManagementReasonCodeUnionCasesBuilder : UnionCasesBuilderBase<CashManagementReasonCode, CashManagementReasonCodeUnionCasesBuilder>
    {
        protected override CashManagementReasonCodeUnionCasesBuilder Self => this;

        public CashManagementReasonCodeUnionCasesBuilder(string fieldName = "nodes") : this(new Query<CashManagementReasonCode>(fieldName))
        {
        }

        public CashManagementReasonCodeUnionCasesBuilder(IQuery<CashManagementReasonCode> query) : base(query)
        {
        }

        public CashManagementReasonCodeUnionCasesBuilder OnCashManagementCustomReasonCode(Action<CashManagementCustomReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementCustomReasonCode>("... on CashManagementCustomReasonCode");
            var queryBuilder = new CashManagementCustomReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CashManagementReasonCodeUnionCasesBuilder OnCashManagementDefaultReasonCode(Action<CashManagementDefaultReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementDefaultReasonCode>("... on CashManagementDefaultReasonCode");
            var queryBuilder = new CashManagementDefaultReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CashManagementReasonCodeUnionCasesBuilder OnCashManagementSystemReasonCode(Action<CashManagementSystemReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementSystemReasonCode>("... on CashManagementSystemReasonCode");
            var queryBuilder = new CashManagementSystemReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}