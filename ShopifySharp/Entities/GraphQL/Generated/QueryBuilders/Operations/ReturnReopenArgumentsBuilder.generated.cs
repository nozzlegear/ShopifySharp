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
    public sealed class ReturnReopenArgumentsBuilder : ArgumentsBuilderBase<ReturnReopenPayload, ReturnReopenArgumentsBuilder>
    {
        protected override ReturnReopenArgumentsBuilder Self => this;

        public ReturnReopenArgumentsBuilder(IQuery<ReturnReopenPayload> query) : base(query)
        {
        }

        public ReturnReopenArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}