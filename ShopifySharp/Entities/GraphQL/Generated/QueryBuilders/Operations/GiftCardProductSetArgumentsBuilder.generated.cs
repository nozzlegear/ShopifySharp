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
    public sealed class GiftCardProductSetArgumentsBuilder : ArgumentsBuilderBase<GiftCardProductSetPayload, GiftCardProductSetArgumentsBuilder>
    {
        protected override GiftCardProductSetArgumentsBuilder Self => this;

        public GiftCardProductSetArgumentsBuilder(IQuery<GiftCardProductSetPayload> query) : base(query)
        {
        }

        public GiftCardProductSetArgumentsBuilder Identifier(ProductSetIdentifiers? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }

        public GiftCardProductSetArgumentsBuilder Input(GiftCardProductSetInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public GiftCardProductSetArgumentsBuilder Synchronous(bool? synchronous)
        {
            base.InnerQuery.AddArgument("synchronous", synchronous);
            return this;
        }
    }
}