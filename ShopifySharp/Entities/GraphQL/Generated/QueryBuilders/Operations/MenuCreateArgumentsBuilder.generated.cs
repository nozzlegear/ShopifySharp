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
    public sealed class MenuCreateArgumentsBuilder : ArgumentsBuilderBase<MenuCreatePayload, MenuCreateArgumentsBuilder>
    {
        protected override MenuCreateArgumentsBuilder Self => this;

        public MenuCreateArgumentsBuilder(IQuery<MenuCreatePayload> query) : base(query)
        {
        }

        public MenuCreateArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }

        public MenuCreateArgumentsBuilder Items(ICollection<MenuItemCreateInput>? items)
        {
            base.InnerQuery.AddArgument("items", items);
            return this;
        }

        public MenuCreateArgumentsBuilder Title(string? title)
        {
            base.InnerQuery.AddArgument("title", title);
            return this;
        }
    }
}