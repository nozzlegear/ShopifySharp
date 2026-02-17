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
    public sealed class ProductBundleCreateArgumentsBuilder : ArgumentsBuilderBase<ProductBundleCreatePayload, ProductBundleCreateArgumentsBuilder>
    {
        protected override ProductBundleCreateArgumentsBuilder Self => this;

        public ProductBundleCreateArgumentsBuilder(IQuery<ProductBundleCreatePayload> query) : base(query)
        {
        }

        public ProductBundleCreateArgumentsBuilder Input(ProductBundleCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}