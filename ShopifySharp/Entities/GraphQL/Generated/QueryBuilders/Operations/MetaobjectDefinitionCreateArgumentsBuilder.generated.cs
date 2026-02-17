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