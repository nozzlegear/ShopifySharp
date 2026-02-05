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
    public sealed class ProductDuplicateJobArgumentsBuilder : ArgumentsBuilderBase<ProductDuplicateJob, ProductDuplicateJobArgumentsBuilder>
    {
        protected override ProductDuplicateJobArgumentsBuilder Self => this;

        public ProductDuplicateJobArgumentsBuilder(IQuery<ProductDuplicateJob> query) : base(query)
        {
        }

        public ProductDuplicateJobArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}