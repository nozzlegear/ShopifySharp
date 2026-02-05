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
    public sealed class ThemePublishArgumentsBuilder : ArgumentsBuilderBase<ThemePublishPayload, ThemePublishArgumentsBuilder>
    {
        protected override ThemePublishArgumentsBuilder Self => this;

        public ThemePublishArgumentsBuilder(IQuery<ThemePublishPayload> query) : base(query)
        {
        }

        public ThemePublishArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}