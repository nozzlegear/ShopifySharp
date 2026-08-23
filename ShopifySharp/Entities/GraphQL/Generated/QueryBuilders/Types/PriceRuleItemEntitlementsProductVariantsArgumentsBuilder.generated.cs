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
    public sealed class PriceRuleItemEntitlementsProductVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, PriceRuleItemEntitlementsProductVariantsArgumentsBuilder>
    {
        protected override PriceRuleItemEntitlementsProductVariantsArgumentsBuilder Self => this;

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceRuleItemEntitlementsProductVariantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}