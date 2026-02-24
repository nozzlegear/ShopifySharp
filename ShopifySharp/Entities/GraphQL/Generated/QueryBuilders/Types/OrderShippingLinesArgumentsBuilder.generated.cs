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
    public sealed class OrderShippingLinesArgumentsBuilder : ArgumentsBuilderBase<ShippingLineConnection?, OrderShippingLinesArgumentsBuilder>
    {
        protected override OrderShippingLinesArgumentsBuilder Self => this;

        public OrderShippingLinesArgumentsBuilder(IQuery<ShippingLineConnection?> query) : base(query)
        {
        }

        public OrderShippingLinesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public OrderShippingLinesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public OrderShippingLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public OrderShippingLinesArgumentsBuilder IncludeRemovals(bool? includeRemovals)
        {
            base.InnerQuery.AddArgument("includeRemovals", includeRemovals);
            return this;
        }

        public OrderShippingLinesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public OrderShippingLinesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}