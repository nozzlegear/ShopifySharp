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
    public sealed class ReturnOutcomeFinancialTransferUnionCasesBuilder : UnionCasesBuilderBase<ReturnOutcomeFinancialTransfer, ReturnOutcomeFinancialTransferUnionCasesBuilder>
    {
        protected override ReturnOutcomeFinancialTransferUnionCasesBuilder Self => this;

        public ReturnOutcomeFinancialTransferUnionCasesBuilder(string fieldName = "financialTransfer") : this(new Query<ReturnOutcomeFinancialTransfer>(fieldName))
        {
        }

        public ReturnOutcomeFinancialTransferUnionCasesBuilder(IQuery<ReturnOutcomeFinancialTransfer> query) : base(query)
        {
        }

        public ReturnOutcomeFinancialTransferUnionCasesBuilder OnInvoiceReturnOutcome(Action<InvoiceReturnOutcomeQueryBuilder> build)
        {
            var query = new Query<InvoiceReturnOutcome>("... on InvoiceReturnOutcome");
            var queryBuilder = new InvoiceReturnOutcomeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ReturnOutcomeFinancialTransferUnionCasesBuilder OnRefundReturnOutcome(Action<RefundReturnOutcomeQueryBuilder> build)
        {
            var query = new Query<RefundReturnOutcome>("... on RefundReturnOutcome");
            var queryBuilder = new RefundReturnOutcomeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}