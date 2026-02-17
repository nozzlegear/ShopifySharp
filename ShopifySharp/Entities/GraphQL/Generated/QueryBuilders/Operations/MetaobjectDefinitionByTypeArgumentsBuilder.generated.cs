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