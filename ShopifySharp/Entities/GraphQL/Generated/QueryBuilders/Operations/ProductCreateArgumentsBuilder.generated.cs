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
    public sealed class ProductCreateArgumentsBuilder : ArgumentsBuilderBase<ProductCreatePayload, ProductCreateArgumentsBuilder>
    {
        protected override ProductCreateArgumentsBuilder Self => this;

        public ProductCreateArgumentsBuilder(IQuery<ProductCreatePayload> query) : base(query)
        {
        }

        public ProductCreateArgumentsBuilder Media(ICollection<CreateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductCreateArgumentsBuilder Product(ProductCreateInput? product)
        {
            base.InnerQuery.AddArgument("product", product);
            return this;
        }
    }
}