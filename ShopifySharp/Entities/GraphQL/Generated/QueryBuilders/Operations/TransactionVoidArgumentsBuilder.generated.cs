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
    public sealed class TransactionVoidArgumentsBuilder : ArgumentsBuilderBase<TransactionVoidPayload, TransactionVoidArgumentsBuilder>
    {
        protected override TransactionVoidArgumentsBuilder Self => this;

        public TransactionVoidArgumentsBuilder(IQuery<TransactionVoidPayload> query) : base(query)
        {
        }

        public TransactionVoidArgumentsBuilder ParentTransactionId(string? parentTransactionId)
        {
            base.InnerQuery.AddArgument("parentTransactionId", parentTransactionId);
            return this;
        }
    }
}