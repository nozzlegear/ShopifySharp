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
    public sealed class ProductBundleUpdateArgumentsBuilder : ArgumentsBuilderBase<ProductBundleUpdatePayload, ProductBundleUpdateArgumentsBuilder>
    {
        protected override ProductBundleUpdateArgumentsBuilder Self => this;

        public ProductBundleUpdateArgumentsBuilder(IQuery<ProductBundleUpdatePayload> query) : base(query)
        {
        }

        public ProductBundleUpdateArgumentsBuilder Input(ProductBundleUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}