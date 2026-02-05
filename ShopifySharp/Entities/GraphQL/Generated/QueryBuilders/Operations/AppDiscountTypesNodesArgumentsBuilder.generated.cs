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
    public sealed class AppDiscountTypesNodesArgumentsBuilder : ArgumentsBuilderBase<AppDiscountTypeConnection, AppDiscountTypesNodesArgumentsBuilder>
    {
        protected override AppDiscountTypesNodesArgumentsBuilder Self => this;

        public AppDiscountTypesNodesArgumentsBuilder(IQuery<AppDiscountTypeConnection> query) : base(query)
        {
        }

        public AppDiscountTypesNodesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppDiscountTypesNodesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppDiscountTypesNodesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppDiscountTypesNodesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppDiscountTypesNodesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}