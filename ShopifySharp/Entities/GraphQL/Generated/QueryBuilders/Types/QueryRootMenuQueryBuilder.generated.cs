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
    public sealed class QueryRootMenuQueryBuilder : FieldsQueryBuilderBase<Menu, QueryRootMenuQueryBuilder>, IHasArguments<QueryRootMenuArgumentsBuilder>
    {
        public QueryRootMenuArgumentsBuilder Arguments { get; }
        protected override QueryRootMenuQueryBuilder Self => this;

        public QueryRootMenuQueryBuilder(string name) : base(new Query<Menu>(name))
        {
            Arguments = new QueryRootMenuArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMenuQueryBuilder(IQuery<Menu> query) : base(query)
        {
            Arguments = new QueryRootMenuArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMenuQueryBuilder SetArguments(Action<QueryRootMenuArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMenuQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootMenuQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootMenuQueryBuilder IsDefault()
        {
            base.InnerQuery.AddField("isDefault");
            return this;
        }

        public QueryRootMenuQueryBuilder Items(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder> build)
        {
            var query = new Query<MenuItem>("items");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuItem>(query);
            return this;
        }

        public QueryRootMenuQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootMenuQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}