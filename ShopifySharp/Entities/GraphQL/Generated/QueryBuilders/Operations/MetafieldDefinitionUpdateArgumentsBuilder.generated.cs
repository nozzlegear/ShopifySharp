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
    public sealed class MetafieldDefinitionUpdateArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionUpdatePayload, MetafieldDefinitionUpdateArgumentsBuilder>
    {
        protected override MetafieldDefinitionUpdateArgumentsBuilder Self => this;

        public MetafieldDefinitionUpdateArgumentsBuilder(IQuery<MetafieldDefinitionUpdatePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionUpdateArgumentsBuilder Definition(MetafieldDefinitionUpdateInput? definition)
        {
            base.InnerQuery.AddArgument("definition", definition);
            return this;
        }
    }
}