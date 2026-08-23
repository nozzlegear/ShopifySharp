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
    public sealed class PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder>
    {
        protected override PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder Self => this;

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceRuleLineItemPrerequisitesProductVariantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}