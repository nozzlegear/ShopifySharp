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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootProductDuplicateJobArgumentsBuilder : ArgumentsBuilderBase<ProductDuplicateJob?, QueryRootProductDuplicateJobArgumentsBuilder>
    {
        protected override QueryRootProductDuplicateJobArgumentsBuilder Self => this;

        public QueryRootProductDuplicateJobArgumentsBuilder(IQuery<ProductDuplicateJob?> query) : base(query)
        {
        }

        public QueryRootProductDuplicateJobArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}