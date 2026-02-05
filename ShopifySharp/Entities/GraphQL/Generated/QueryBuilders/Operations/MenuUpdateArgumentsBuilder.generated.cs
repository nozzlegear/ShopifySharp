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
    public sealed class MenuUpdateArgumentsBuilder : ArgumentsBuilderBase<MenuUpdatePayload, MenuUpdateArgumentsBuilder>
    {
        protected override MenuUpdateArgumentsBuilder Self => this;

        public MenuUpdateArgumentsBuilder(IQuery<MenuUpdatePayload> query) : base(query)
        {
        }

        public MenuUpdateArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }

        public MenuUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MenuUpdateArgumentsBuilder Items(ICollection<MenuItemUpdateInput>? items)
        {
            base.InnerQuery.AddArgument("items", items);
            return this;
        }

        public MenuUpdateArgumentsBuilder Title(string? title)
        {
            base.InnerQuery.AddArgument("title", title);
            return this;
        }
    }
}