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
    public sealed class AppDiscountTypeArgumentsBuilder : ArgumentsBuilderBase<AppDiscountType, AppDiscountTypeArgumentsBuilder>
    {
        protected override AppDiscountTypeArgumentsBuilder Self => this;

        public AppDiscountTypeArgumentsBuilder(IQuery<AppDiscountType> query) : base(query)
        {
        }

        public AppDiscountTypeArgumentsBuilder FunctionId(string? functionId)
        {
            base.InnerQuery.AddArgument("functionId", functionId);
            return this;
        }
    }
}