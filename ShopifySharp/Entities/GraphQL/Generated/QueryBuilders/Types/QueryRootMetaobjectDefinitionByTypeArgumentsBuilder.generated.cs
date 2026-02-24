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
    public sealed class QueryRootMetaobjectDefinitionByTypeArgumentsBuilder : ArgumentsBuilderBase<MetaobjectDefinition?, QueryRootMetaobjectDefinitionByTypeArgumentsBuilder>
    {
        protected override QueryRootMetaobjectDefinitionByTypeArgumentsBuilder Self => this;

        public QueryRootMetaobjectDefinitionByTypeArgumentsBuilder(IQuery<MetaobjectDefinition?> query) : base(query)
        {
        }

        public QueryRootMetaobjectDefinitionByTypeArgumentsBuilder Type(string? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}