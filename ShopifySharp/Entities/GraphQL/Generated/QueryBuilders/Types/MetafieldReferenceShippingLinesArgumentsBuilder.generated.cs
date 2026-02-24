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
    public sealed class MetafieldReferenceShippingLinesArgumentsBuilder : ArgumentsBuilderBase<ShippingLineConnection?, MetafieldReferenceShippingLinesArgumentsBuilder>
    {
        protected override MetafieldReferenceShippingLinesArgumentsBuilder Self => this;

        public MetafieldReferenceShippingLinesArgumentsBuilder(IQuery<ShippingLineConnection?> query) : base(query)
        {
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder IncludeRemovals(bool? includeRemovals)
        {
            base.InnerQuery.AddArgument("includeRemovals", includeRemovals);
            return this;
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferenceShippingLinesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}