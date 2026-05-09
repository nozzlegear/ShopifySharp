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
    public sealed class CashDrawerFindOrCreateArgumentsBuilder : ArgumentsBuilderBase<CashDrawerFindOrCreatePayload, CashDrawerFindOrCreateArgumentsBuilder>
    {
        protected override CashDrawerFindOrCreateArgumentsBuilder Self => this;

        public CashDrawerFindOrCreateArgumentsBuilder(IQuery<CashDrawerFindOrCreatePayload> query) : base(query)
        {
        }

        public CashDrawerFindOrCreateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public CashDrawerFindOrCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public CashDrawerFindOrCreateArgumentsBuilder PointOfSaleDeviceId(string? pointOfSaleDeviceId)
        {
            base.InnerQuery.AddArgument("pointOfSaleDeviceId", pointOfSaleDeviceId);
            return this;
        }
    }
}