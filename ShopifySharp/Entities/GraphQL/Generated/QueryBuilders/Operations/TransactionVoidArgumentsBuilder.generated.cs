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