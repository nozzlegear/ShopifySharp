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
    public sealed class MetaobjectFieldArgumentsBuilder : ArgumentsBuilderBase<MetaobjectField, MetaobjectFieldArgumentsBuilder>
    {
        protected override MetaobjectFieldArgumentsBuilder Self => this;

        public MetaobjectFieldArgumentsBuilder(IQuery<MetaobjectField> query) : base(query)
        {
        }

        public MetaobjectFieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }
    }
}