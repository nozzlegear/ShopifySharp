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
    public sealed class ProductUnpublishArgumentsBuilder : ArgumentsBuilderBase<ProductUnpublishPayload, ProductUnpublishArgumentsBuilder>
    {
        protected override ProductUnpublishArgumentsBuilder Self => this;

        public ProductUnpublishArgumentsBuilder(IQuery<ProductUnpublishPayload> query) : base(query)
        {
        }

        public ProductUnpublishArgumentsBuilder Input(ProductUnpublishInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}