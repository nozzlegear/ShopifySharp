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
    public sealed class GiftCardUpdateArgumentsBuilder : ArgumentsBuilderBase<GiftCardUpdatePayload, GiftCardUpdateArgumentsBuilder>
    {
        protected override GiftCardUpdateArgumentsBuilder Self => this;

        public GiftCardUpdateArgumentsBuilder(IQuery<GiftCardUpdatePayload> query) : base(query)
        {
        }

        public GiftCardUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public GiftCardUpdateArgumentsBuilder Input(GiftCardUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}