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
    public sealed class ProductSetArgumentsBuilder : ArgumentsBuilderBase<ProductSetPayload, ProductSetArgumentsBuilder>
    {
        protected override ProductSetArgumentsBuilder Self => this;

        public ProductSetArgumentsBuilder(IQuery<ProductSetPayload> query) : base(query)
        {
        }

        public ProductSetArgumentsBuilder Identifier(ProductSetIdentifiers? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }

        public ProductSetArgumentsBuilder Input(ProductSetInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public ProductSetArgumentsBuilder Synchronous(bool? synchronous)
        {
            base.InnerQuery.AddArgument("synchronous", synchronous);
            return this;
        }
    }
}