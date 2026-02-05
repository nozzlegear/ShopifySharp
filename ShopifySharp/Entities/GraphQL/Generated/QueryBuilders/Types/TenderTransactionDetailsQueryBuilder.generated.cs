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
    public sealed class TenderTransactionDetailsQueryBuilder : FieldsQueryBuilderBase<TenderTransactionDetails, TenderTransactionDetailsQueryBuilder>
    {
        protected override TenderTransactionDetailsQueryBuilder Self => this;

        public TenderTransactionDetailsQueryBuilder() : this("tenderTransactionDetails")
        {
        }

        public TenderTransactionDetailsQueryBuilder(string name) : base(new Query<TenderTransactionDetails>(name))
        {
        }

        public TenderTransactionDetailsQueryBuilder(IQuery<TenderTransactionDetails> query) : base(query)
        {
        }

        public TenderTransactionDetailsQueryBuilder TenderTransactionDetails(Action<TenderTransactionDetailsUnionCasesBuilder> build)
        {
            var query = new Query<TenderTransactionDetails>("tenderTransactionDetails");
            var unionBuilder = new TenderTransactionDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}