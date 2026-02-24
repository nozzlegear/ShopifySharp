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
    public sealed class ShippingLineConnectionArgumentsBuilder : ArgumentsBuilderBase<ShippingLineConnection, ShippingLineConnectionArgumentsBuilder>
    {
        protected override ShippingLineConnectionArgumentsBuilder Self => this;

        public ShippingLineConnectionArgumentsBuilder(IQuery<ShippingLineConnection> query) : base(query)
        {
        }

        public ShippingLineConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShippingLineConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShippingLineConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShippingLineConnectionArgumentsBuilder IncludeRemovals(bool? includeRemovals)
        {
            base.InnerQuery.AddArgument("includeRemovals", includeRemovals);
            return this;
        }

        public ShippingLineConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShippingLineConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}