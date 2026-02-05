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
    public sealed class MetaobjectDefinitionByTypeArgumentsBuilder : ArgumentsBuilderBase<MetaobjectDefinition, MetaobjectDefinitionByTypeArgumentsBuilder>
    {
        protected override MetaobjectDefinitionByTypeArgumentsBuilder Self => this;

        public MetaobjectDefinitionByTypeArgumentsBuilder(IQuery<MetaobjectDefinition> query) : base(query)
        {
        }

        public MetaobjectDefinitionByTypeArgumentsBuilder Type(string? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}