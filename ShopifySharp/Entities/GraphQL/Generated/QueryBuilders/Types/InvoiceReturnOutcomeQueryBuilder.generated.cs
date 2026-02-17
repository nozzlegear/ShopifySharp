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
    public sealed class InvoiceReturnOutcomeQueryBuilder : FieldsQueryBuilderBase<InvoiceReturnOutcome, InvoiceReturnOutcomeQueryBuilder>
    {
        protected override InvoiceReturnOutcomeQueryBuilder Self => this;

        public InvoiceReturnOutcomeQueryBuilder() : this("invoiceReturnOutcome")
        {
        }

        public InvoiceReturnOutcomeQueryBuilder(string name) : base(new Query<InvoiceReturnOutcome>(name))
        {
        }

        public InvoiceReturnOutcomeQueryBuilder(IQuery<InvoiceReturnOutcome> query) : base(query)
        {
        }

        public InvoiceReturnOutcomeQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}