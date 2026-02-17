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