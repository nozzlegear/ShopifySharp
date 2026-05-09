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
    public sealed class CashDrawerCreateArgumentsBuilder : ArgumentsBuilderBase<CashDrawerCreatePayload, CashDrawerCreateArgumentsBuilder>
    {
        protected override CashDrawerCreateArgumentsBuilder Self => this;

        public CashDrawerCreateArgumentsBuilder(IQuery<CashDrawerCreatePayload> query) : base(query)
        {
        }

        public CashDrawerCreateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public CashDrawerCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }
    }
}