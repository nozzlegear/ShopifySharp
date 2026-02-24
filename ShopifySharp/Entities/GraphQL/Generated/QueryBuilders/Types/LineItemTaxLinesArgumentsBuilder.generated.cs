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
    public sealed class LineItemTaxLinesArgumentsBuilder : ArgumentsBuilderBase<TaxLine?, LineItemTaxLinesArgumentsBuilder>
    {
        protected override LineItemTaxLinesArgumentsBuilder Self => this;

        public LineItemTaxLinesArgumentsBuilder(IQuery<TaxLine?> query) : base(query)
        {
        }

        public LineItemTaxLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}