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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class PointOfSaleDeviceArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevice, PointOfSaleDeviceArgumentsBuilder>
    {
        protected override PointOfSaleDeviceArgumentsBuilder Self => this;

        public PointOfSaleDeviceArgumentsBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
        }

        public PointOfSaleDeviceArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}