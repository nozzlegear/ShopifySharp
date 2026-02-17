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
    public sealed class TransactionVoidUserErrorQueryBuilder : FieldsQueryBuilderBase<TransactionVoidUserError, TransactionVoidUserErrorQueryBuilder>
    {
        protected override TransactionVoidUserErrorQueryBuilder Self => this;

        public TransactionVoidUserErrorQueryBuilder() : this("transactionVoidUserError")
        {
        }

        public TransactionVoidUserErrorQueryBuilder(string name) : base(new Query<TransactionVoidUserError>(name))
        {
        }

        public TransactionVoidUserErrorQueryBuilder(IQuery<TransactionVoidUserError> query) : base(query)
        {
        }

        public TransactionVoidUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public TransactionVoidUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public TransactionVoidUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}