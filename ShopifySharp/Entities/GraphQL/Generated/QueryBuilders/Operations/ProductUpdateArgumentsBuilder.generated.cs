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
    public sealed class ProductUpdateArgumentsBuilder : ArgumentsBuilderBase<ProductUpdatePayload, ProductUpdateArgumentsBuilder>
    {
        protected override ProductUpdateArgumentsBuilder Self => this;

        public ProductUpdateArgumentsBuilder(IQuery<ProductUpdatePayload> query) : base(query)
        {
        }

        public ProductUpdateArgumentsBuilder Media(ICollection<CreateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductUpdateArgumentsBuilder Product(ProductUpdateInput? product)
        {
            base.InnerQuery.AddArgument("product", product);
            return this;
        }
    }
}