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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class MenuQueryBuilder : FieldsQueryBuilderBase<Menu, MenuQueryBuilder>
    {
        protected override MenuQueryBuilder Self => this;

        public MenuQueryBuilder() : this("menu")
        {
        }

        public MenuQueryBuilder(string name) : base(new Query<Menu>(name))
        {
        }

        public MenuQueryBuilder(IQuery<Menu> query) : base(query)
        {
        }

        public MenuQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public MenuQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MenuQueryBuilder IsDefault()
        {
            base.InnerQuery.AddField("isDefault");
            return this;
        }

        public MenuQueryBuilder Items(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuItemQueryBuilder> build)
        {
            var query = new Query<MenuItem>("items");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuItem>(query);
            return this;
        }

        public MenuQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MenuQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}