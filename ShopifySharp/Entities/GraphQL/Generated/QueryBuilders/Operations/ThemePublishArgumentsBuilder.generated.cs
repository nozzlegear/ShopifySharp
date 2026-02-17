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