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
    public sealed class PriceRuleLineItemPrerequisitesProductsArgumentsBuilder : ArgumentsBuilderBase<ProductConnection?, PriceRuleLineItemPrerequisitesProductsArgumentsBuilder>
    {
        protected override PriceRuleLineItemPrerequisitesProductsArgumentsBuilder Self => this;

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder(IQuery<ProductConnection?> query) : base(query)
        {
        }

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}