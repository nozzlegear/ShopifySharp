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
    public sealed class MetafieldDefinitionCreateArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionCreatePayload, MetafieldDefinitionCreateArgumentsBuilder>
    {
        protected override MetafieldDefinitionCreateArgumentsBuilder Self => this;

        public MetafieldDefinitionCreateArgumentsBuilder(IQuery<MetafieldDefinitionCreatePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionCreateArgumentsBuilder Definition(MetafieldDefinitionInput? definition)
        {
            base.InnerQuery.AddArgument("definition", definition);
            return this;
        }
    }
}