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
    public sealed class InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder : ArgumentsBuilderBase<CountryHarmonizedSystemCodeConnection?, InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder>
    {
        protected override InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder Self => this;

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder(IQuery<CountryHarmonizedSystemCodeConnection?> query) : base(query)
        {
        }

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}