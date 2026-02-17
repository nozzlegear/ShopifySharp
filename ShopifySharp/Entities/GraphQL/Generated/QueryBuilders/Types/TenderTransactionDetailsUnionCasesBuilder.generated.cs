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
    public sealed class TenderTransactionDetailsUnionCasesBuilder : UnionCasesBuilderBase<TenderTransactionDetails, TenderTransactionDetailsUnionCasesBuilder>
    {
        protected override TenderTransactionDetailsUnionCasesBuilder Self => this;

        public TenderTransactionDetailsUnionCasesBuilder(string fieldName = "tenderTransactionDetails") : this(new Query<TenderTransactionDetails>(fieldName))
        {
        }

        public TenderTransactionDetailsUnionCasesBuilder(IQuery<TenderTransactionDetails> query) : base(query)
        {
        }

        public TenderTransactionDetailsUnionCasesBuilder OnTenderTransactionCreditCardDetails(Action<TenderTransactionCreditCardDetailsQueryBuilder> build)
        {
            var query = new Query<TenderTransactionCreditCardDetails>("... on TenderTransactionCreditCardDetails");
            var queryBuilder = new TenderTransactionCreditCardDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}