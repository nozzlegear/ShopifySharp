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
    public sealed class StoreCreditAccountCreditArgumentsBuilder : ArgumentsBuilderBase<StoreCreditAccountCreditPayload, StoreCreditAccountCreditArgumentsBuilder>
    {
        protected override StoreCreditAccountCreditArgumentsBuilder Self => this;

        public StoreCreditAccountCreditArgumentsBuilder(IQuery<StoreCreditAccountCreditPayload> query) : base(query)
        {
        }

        public StoreCreditAccountCreditArgumentsBuilder CreditInput(StoreCreditAccountCreditInput? creditInput)
        {
            base.InnerQuery.AddArgument("creditInput", creditInput);
            return this;
        }

        public StoreCreditAccountCreditArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}