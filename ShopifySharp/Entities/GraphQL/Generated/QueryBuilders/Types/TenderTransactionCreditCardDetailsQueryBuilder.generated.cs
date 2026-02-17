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
    public sealed class TenderTransactionCreditCardDetailsQueryBuilder : FieldsQueryBuilderBase<TenderTransactionCreditCardDetails, TenderTransactionCreditCardDetailsQueryBuilder>
    {
        protected override TenderTransactionCreditCardDetailsQueryBuilder Self => this;

        public TenderTransactionCreditCardDetailsQueryBuilder() : this("tenderTransactionCreditCardDetails")
        {
        }

        public TenderTransactionCreditCardDetailsQueryBuilder(string name) : base(new Query<TenderTransactionCreditCardDetails>(name))
        {
        }

        public TenderTransactionCreditCardDetailsQueryBuilder(IQuery<TenderTransactionCreditCardDetails> query) : base(query)
        {
        }

        public TenderTransactionCreditCardDetailsQueryBuilder CreditCardCompany()
        {
            base.InnerQuery.AddField("creditCardCompany");
            return this;
        }

        public TenderTransactionCreditCardDetailsQueryBuilder CreditCardNumber()
        {
            base.InnerQuery.AddField("creditCardNumber");
            return this;
        }
    }
}