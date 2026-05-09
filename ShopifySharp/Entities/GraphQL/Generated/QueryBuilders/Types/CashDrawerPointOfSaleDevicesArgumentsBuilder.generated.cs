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
    public sealed class CashDrawerPointOfSaleDevicesArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDeviceConnection?, CashDrawerPointOfSaleDevicesArgumentsBuilder>
    {
        protected override CashDrawerPointOfSaleDevicesArgumentsBuilder Self => this;

        public CashDrawerPointOfSaleDevicesArgumentsBuilder(IQuery<PointOfSaleDeviceConnection?> query) : base(query)
        {
        }

        public CashDrawerPointOfSaleDevicesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CashDrawerPointOfSaleDevicesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CashDrawerPointOfSaleDevicesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CashDrawerPointOfSaleDevicesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}