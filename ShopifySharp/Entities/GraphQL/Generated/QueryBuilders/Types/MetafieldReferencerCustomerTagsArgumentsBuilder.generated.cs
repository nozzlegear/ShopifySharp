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
    public sealed class MetafieldReferencerCustomerTagsArgumentsBuilder : ArgumentsBuilderBase<StringConnection?, MetafieldReferencerCustomerTagsArgumentsBuilder>
    {
        protected override MetafieldReferencerCustomerTagsArgumentsBuilder Self => this;

        public MetafieldReferencerCustomerTagsArgumentsBuilder(IQuery<StringConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerCustomerTagsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}