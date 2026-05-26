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
    public sealed class CashDrawerUpdateArgumentsBuilder : ArgumentsBuilderBase<CashDrawerUpdatePayload, CashDrawerUpdateArgumentsBuilder>
    {
        protected override CashDrawerUpdateArgumentsBuilder Self => this;

        public CashDrawerUpdateArgumentsBuilder(IQuery<CashDrawerUpdatePayload> query) : base(query)
        {
        }

        public CashDrawerUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CashDrawerUpdateArgumentsBuilder Input(CashDrawerUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}