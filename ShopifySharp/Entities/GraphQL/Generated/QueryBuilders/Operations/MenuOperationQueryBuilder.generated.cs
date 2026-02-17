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
    public sealed class MenuOperationQueryBuilder : FieldsQueryBuilderBase<Menu, MenuOperationQueryBuilder>, IGraphOperationQueryBuilder<Menu>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MenuArgumentsBuilder Arguments { get; }
        protected override MenuOperationQueryBuilder Self => this;

        public MenuOperationQueryBuilder() : this("menu")
        {
        }

        public MenuOperationQueryBuilder(string name) : base(new Query<Menu>(name))
        {
            Arguments = new MenuArgumentsBuilder(base.InnerQuery);
        }

        public MenuOperationQueryBuilder(IQuery<Menu> query) : base(query)
        {
            Arguments = new MenuArgumentsBuilder(base.InnerQuery);
        }

        public MenuOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public MenuOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MenuOperationQueryBuilder IsDefault()
        {
            base.InnerQuery.AddField("isDefault");
            return this;
        }

        public MenuOperationQueryBuilder Items(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder> build)
        {
            var query = new Query<MenuItem>("items");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuItem>(query);
            return this;
        }

        public MenuOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MenuOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}