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
    public sealed class StoreCreditAccountDebitArgumentsBuilder : ArgumentsBuilderBase<StoreCreditAccountDebitPayload, StoreCreditAccountDebitArgumentsBuilder>
    {
        protected override StoreCreditAccountDebitArgumentsBuilder Self => this;

        public StoreCreditAccountDebitArgumentsBuilder(IQuery<StoreCreditAccountDebitPayload> query) : base(query)
        {
        }

        public StoreCreditAccountDebitArgumentsBuilder DebitInput(StoreCreditAccountDebitInput? debitInput)
        {
            base.InnerQuery.AddArgument("debitInput", debitInput);
            return this;
        }

        public StoreCreditAccountDebitArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}