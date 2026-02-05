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
    public sealed class GiftCardCreateArgumentsBuilder : ArgumentsBuilderBase<GiftCardCreatePayload, GiftCardCreateArgumentsBuilder>
    {
        protected override GiftCardCreateArgumentsBuilder Self => this;

        public GiftCardCreateArgumentsBuilder(IQuery<GiftCardCreatePayload> query) : base(query)
        {
        }

        public GiftCardCreateArgumentsBuilder Input(GiftCardCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}