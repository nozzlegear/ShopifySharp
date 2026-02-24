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
    public sealed class MetafieldReferencerShippingLinesArgumentsBuilder : ArgumentsBuilderBase<ShippingLineConnection?, MetafieldReferencerShippingLinesArgumentsBuilder>
    {
        protected override MetafieldReferencerShippingLinesArgumentsBuilder Self => this;

        public MetafieldReferencerShippingLinesArgumentsBuilder(IQuery<ShippingLineConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder IncludeRemovals(bool? includeRemovals)
        {
            base.InnerQuery.AddArgument("includeRemovals", includeRemovals);
            return this;
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerShippingLinesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}