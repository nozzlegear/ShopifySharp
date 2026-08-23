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
    public sealed class MetafieldReferencerDiscountsArgumentsBuilder : ArgumentsBuilderBase<DiscountNodeConnection?, MetafieldReferencerDiscountsArgumentsBuilder>
    {
        protected override MetafieldReferencerDiscountsArgumentsBuilder Self => this;

        public MetafieldReferencerDiscountsArgumentsBuilder(IQuery<DiscountNodeConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerDiscountsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerDiscountsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerDiscountsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerDiscountsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerDiscountsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}