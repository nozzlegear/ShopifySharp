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
    public sealed class ProductFeedCreateArgumentsBuilder : ArgumentsBuilderBase<ProductFeedCreatePayload, ProductFeedCreateArgumentsBuilder>
    {
        protected override ProductFeedCreateArgumentsBuilder Self => this;

        public ProductFeedCreateArgumentsBuilder(IQuery<ProductFeedCreatePayload> query) : base(query)
        {
        }

        public ProductFeedCreateArgumentsBuilder Input(ProductFeedInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}