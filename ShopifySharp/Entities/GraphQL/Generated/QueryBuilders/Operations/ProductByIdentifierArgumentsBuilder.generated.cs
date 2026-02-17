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
    public sealed class ProductByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Product, ProductByIdentifierArgumentsBuilder>
    {
        protected override ProductByIdentifierArgumentsBuilder Self => this;

        public ProductByIdentifierArgumentsBuilder(IQuery<Product> query) : base(query)
        {
        }

        public ProductByIdentifierArgumentsBuilder Identifier(ProductIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}