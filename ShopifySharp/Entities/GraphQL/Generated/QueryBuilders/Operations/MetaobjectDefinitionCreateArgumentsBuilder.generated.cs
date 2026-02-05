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
    public sealed class MetaobjectDefinitionCreateArgumentsBuilder : ArgumentsBuilderBase<MetaobjectDefinitionCreatePayload, MetaobjectDefinitionCreateArgumentsBuilder>
    {
        protected override MetaobjectDefinitionCreateArgumentsBuilder Self => this;

        public MetaobjectDefinitionCreateArgumentsBuilder(IQuery<MetaobjectDefinitionCreatePayload> query) : base(query)
        {
        }

        public MetaobjectDefinitionCreateArgumentsBuilder Definition(MetaobjectDefinitionCreateInput? definition)
        {
            base.InnerQuery.AddArgument("definition", definition);
            return this;
        }
    }
}