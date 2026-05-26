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
    public sealed class PointOfSaleDeviceConnectionArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDeviceConnection, PointOfSaleDeviceConnectionArgumentsBuilder>
    {
        protected override PointOfSaleDeviceConnectionArgumentsBuilder Self => this;

        public PointOfSaleDeviceConnectionArgumentsBuilder(IQuery<PointOfSaleDeviceConnection> query) : base(query)
        {
        }

        public PointOfSaleDeviceConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PointOfSaleDeviceConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PointOfSaleDeviceConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PointOfSaleDeviceConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}