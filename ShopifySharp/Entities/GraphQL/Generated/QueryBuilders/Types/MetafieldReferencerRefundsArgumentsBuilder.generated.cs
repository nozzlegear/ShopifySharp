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
    public sealed class MetafieldReferencerRefundsArgumentsBuilder : ArgumentsBuilderBase<Refund?, MetafieldReferencerRefundsArgumentsBuilder>
    {
        protected override MetafieldReferencerRefundsArgumentsBuilder Self => this;

        public MetafieldReferencerRefundsArgumentsBuilder(IQuery<Refund?> query) : base(query)
        {
        }

        public MetafieldReferencerRefundsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}