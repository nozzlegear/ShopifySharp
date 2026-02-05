#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class DataSaleOptOutArgumentsBuilder : ArgumentsBuilderBase<DataSaleOptOutPayload, DataSaleOptOutArgumentsBuilder>
    {
        protected override DataSaleOptOutArgumentsBuilder Self => this;

        public DataSaleOptOutArgumentsBuilder(IQuery<DataSaleOptOutPayload> query) : base(query)
        {
        }

        public DataSaleOptOutArgumentsBuilder Email(string? email)
        {
            base.InnerQuery.AddArgument("email", email);
            return this;
        }
    }
}