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
    public sealed class ShopProductVendorsArgumentsBuilder : ArgumentsBuilderBase<StringConnection?, ShopProductVendorsArgumentsBuilder>
    {
        protected override ShopProductVendorsArgumentsBuilder Self => this;

        public ShopProductVendorsArgumentsBuilder(IQuery<StringConnection?> query) : base(query)
        {
        }

        public ShopProductVendorsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}