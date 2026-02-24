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
    public sealed class QueryRootDiscountNodeArgumentsBuilder : ArgumentsBuilderBase<DiscountNode?, QueryRootDiscountNodeArgumentsBuilder>
    {
        protected override QueryRootDiscountNodeArgumentsBuilder Self => this;

        public QueryRootDiscountNodeArgumentsBuilder(IQuery<DiscountNode?> query) : base(query)
        {
        }

        public QueryRootDiscountNodeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}