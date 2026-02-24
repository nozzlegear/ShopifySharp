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
    public sealed class MetaobjectDefinitionArgumentsBuilder : ArgumentsBuilderBase<MetaobjectDefinition, MetaobjectDefinitionArgumentsBuilder>
    {
        protected override MetaobjectDefinitionArgumentsBuilder Self => this;

        public MetaobjectDefinitionArgumentsBuilder(IQuery<MetaobjectDefinition> query) : base(query)
        {
        }

        public MetaobjectDefinitionArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MetaobjectDefinitionArgumentsBuilder Type(string? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}