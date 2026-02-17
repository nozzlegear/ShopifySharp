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
    public sealed class MenuItemQueryBuilder : FieldsQueryBuilderBase<MenuItem, MenuItemQueryBuilder>
    {
        protected override MenuItemQueryBuilder Self => this;

        public MenuItemQueryBuilder() : this("menuItem")
        {
        }

        public MenuItemQueryBuilder(string name) : base(new Query<MenuItem>(name))
        {
        }

        public MenuItemQueryBuilder(IQuery<MenuItem> query) : base(query)
        {
        }

        public MenuItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MenuItemQueryBuilder Items(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder> build)
        {
            var query = new Query<MenuItem>("items");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuItem>(query);
            return this;
        }

        public MenuItemQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public MenuItemQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public MenuItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MenuItemQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MenuItemQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}