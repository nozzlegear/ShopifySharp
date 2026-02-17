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