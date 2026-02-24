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
    public sealed class CountryHarmonizedSystemCodeConnectionArgumentsBuilder : ArgumentsBuilderBase<CountryHarmonizedSystemCodeConnection, CountryHarmonizedSystemCodeConnectionArgumentsBuilder>
    {
        protected override CountryHarmonizedSystemCodeConnectionArgumentsBuilder Self => this;

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder(IQuery<CountryHarmonizedSystemCodeConnection> query) : base(query)
        {
        }

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}