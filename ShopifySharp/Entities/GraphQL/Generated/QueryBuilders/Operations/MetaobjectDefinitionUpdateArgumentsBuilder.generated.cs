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
    public sealed class MetaobjectDefinitionUpdateArgumentsBuilder : ArgumentsBuilderBase<MetaobjectDefinitionUpdatePayload, MetaobjectDefinitionUpdateArgumentsBuilder>
    {
        protected override MetaobjectDefinitionUpdateArgumentsBuilder Self => this;

        public MetaobjectDefinitionUpdateArgumentsBuilder(IQuery<MetaobjectDefinitionUpdatePayload> query) : base(query)
        {
        }

        public MetaobjectDefinitionUpdateArgumentsBuilder Definition(MetaobjectDefinitionUpdateInput? definition)
        {
            base.InnerQuery.AddArgument("definition", definition);
            return this;
        }

        public MetaobjectDefinitionUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}