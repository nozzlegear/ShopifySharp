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
    public sealed class ProductOptionsReorderArgumentsBuilder : ArgumentsBuilderBase<ProductOptionsReorderPayload, ProductOptionsReorderArgumentsBuilder>
    {
        protected override ProductOptionsReorderArgumentsBuilder Self => this;

        public ProductOptionsReorderArgumentsBuilder(IQuery<ProductOptionsReorderPayload> query) : base(query)
        {
        }

        public ProductOptionsReorderArgumentsBuilder Options(ICollection<OptionReorderInput>? options)
        {
            base.InnerQuery.AddArgument("options", options);
            return this;
        }

        public ProductOptionsReorderArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }
    }
}