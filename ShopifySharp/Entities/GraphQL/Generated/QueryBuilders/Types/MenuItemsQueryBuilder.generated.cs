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
    public sealed class MenuItemsQueryBuilder : FieldsQueryBuilderBase<MenuItem, MenuItemsQueryBuilder>, IHasArguments<MenuItemsArgumentsBuilder>
    {
        public MenuItemsArgumentsBuilder Arguments { get; }
        protected override MenuItemsQueryBuilder Self => this;

        public MenuItemsQueryBuilder(string name) : base(new Query<MenuItem>(name))
        {
            Arguments = new MenuItemsArgumentsBuilder(base.InnerQuery);
        }

        public MenuItemsQueryBuilder(IQuery<MenuItem> query) : base(query)
        {
            Arguments = new MenuItemsArgumentsBuilder(base.InnerQuery);
        }

        public MenuItemsQueryBuilder SetArguments(Action<MenuItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MenuItemsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MenuItemsQueryBuilder Items(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder> build)
        {
            var query = new Query<MenuItem>("items");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuItem>(query);
            return this;
        }

        public MenuItemsQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public MenuItemsQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public MenuItemsQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MenuItemsQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MenuItemsQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}