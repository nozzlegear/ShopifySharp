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
    public sealed class ReturnOutcomeFinancialTransferQueryBuilder : FieldsQueryBuilderBase<ReturnOutcomeFinancialTransfer, ReturnOutcomeFinancialTransferQueryBuilder>
    {
        protected override ReturnOutcomeFinancialTransferQueryBuilder Self => this;

        public ReturnOutcomeFinancialTransferQueryBuilder() : this("returnOutcomeFinancialTransfer")
        {
        }

        public ReturnOutcomeFinancialTransferQueryBuilder(string name) : base(new Query<ReturnOutcomeFinancialTransfer>(name))
        {
        }

        public ReturnOutcomeFinancialTransferQueryBuilder(IQuery<ReturnOutcomeFinancialTransfer> query) : base(query)
        {
        }

        public ReturnOutcomeFinancialTransferQueryBuilder ReturnOutcomeFinancialTransfer(Action<ReturnOutcomeFinancialTransferUnionCasesBuilder> build)
        {
            var query = new Query<ReturnOutcomeFinancialTransfer>("returnOutcomeFinancialTransfer");
            var unionBuilder = new ReturnOutcomeFinancialTransferUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}