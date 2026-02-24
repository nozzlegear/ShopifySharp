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
    public sealed class QueryRootAutomaticDiscountNodeArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticNode?, QueryRootAutomaticDiscountNodeArgumentsBuilder>
    {
        protected override QueryRootAutomaticDiscountNodeArgumentsBuilder Self => this;

        public QueryRootAutomaticDiscountNodeArgumentsBuilder(IQuery<DiscountAutomaticNode?> query) : base(query)
        {
        }

        public QueryRootAutomaticDiscountNodeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}