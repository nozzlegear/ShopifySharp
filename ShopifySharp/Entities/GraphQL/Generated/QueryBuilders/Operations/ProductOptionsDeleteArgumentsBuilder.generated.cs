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
    public sealed class ProductOptionsDeleteArgumentsBuilder : ArgumentsBuilderBase<ProductOptionsDeletePayload, ProductOptionsDeleteArgumentsBuilder>
    {
        protected override ProductOptionsDeleteArgumentsBuilder Self => this;

        public ProductOptionsDeleteArgumentsBuilder(IQuery<ProductOptionsDeletePayload> query) : base(query)
        {
        }

        public ProductOptionsDeleteArgumentsBuilder Options(ICollection<string>? options)
        {
            base.InnerQuery.AddArgument("options", options);
            return this;
        }

        public ProductOptionsDeleteArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductOptionsDeleteArgumentsBuilder Strategy(ProductOptionDeleteStrategy? strategy)
        {
            base.InnerQuery.AddArgument("strategy", strategy);
            return this;
        }
    }
}