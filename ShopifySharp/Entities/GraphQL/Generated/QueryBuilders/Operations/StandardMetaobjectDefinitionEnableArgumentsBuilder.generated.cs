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
    public sealed class StandardMetaobjectDefinitionEnableArgumentsBuilder : ArgumentsBuilderBase<StandardMetaobjectDefinitionEnablePayload, StandardMetaobjectDefinitionEnableArgumentsBuilder>
    {
        protected override StandardMetaobjectDefinitionEnableArgumentsBuilder Self => this;

        public StandardMetaobjectDefinitionEnableArgumentsBuilder(IQuery<StandardMetaobjectDefinitionEnablePayload> query) : base(query)
        {
        }

        public StandardMetaobjectDefinitionEnableArgumentsBuilder Type(string? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}