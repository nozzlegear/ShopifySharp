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
    public sealed class StandardMetafieldDefinitionEnableArgumentsBuilder : ArgumentsBuilderBase<StandardMetafieldDefinitionEnablePayload, StandardMetafieldDefinitionEnableArgumentsBuilder>
    {
        protected override StandardMetafieldDefinitionEnableArgumentsBuilder Self => this;

        public StandardMetafieldDefinitionEnableArgumentsBuilder(IQuery<StandardMetafieldDefinitionEnablePayload> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Access(StandardMetafieldDefinitionAccessInput? access)
        {
            base.InnerQuery.AddArgument("access", access);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Capabilities(MetafieldCapabilityCreateInput? capabilities)
        {
            base.InnerQuery.AddArgument("capabilities", capabilities);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder OwnerType(MetafieldOwnerType? ownerType)
        {
            base.InnerQuery.AddArgument("ownerType", ownerType);
            return this;
        }

        public StandardMetafieldDefinitionEnableArgumentsBuilder Pin(bool? pin)
        {
            base.InnerQuery.AddArgument("pin", pin);
            return this;
        }
    }
}