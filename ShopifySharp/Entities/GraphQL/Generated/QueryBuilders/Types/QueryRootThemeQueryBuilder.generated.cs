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
    public sealed class QueryRootThemeQueryBuilder : FieldsQueryBuilderBase<OnlineStoreTheme, QueryRootThemeQueryBuilder>, IHasArguments<QueryRootThemeArgumentsBuilder>
    {
        public QueryRootThemeArgumentsBuilder Arguments { get; }
        protected override QueryRootThemeQueryBuilder Self => this;

        public QueryRootThemeQueryBuilder(string name) : base(new Query<OnlineStoreTheme>(name))
        {
            Arguments = new QueryRootThemeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootThemeQueryBuilder(IQuery<OnlineStoreTheme> query) : base(query)
        {
            Arguments = new QueryRootThemeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootThemeQueryBuilder SetArguments(Action<QueryRootThemeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootThemeQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootThemeQueryBuilder Files(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileConnection>("files");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileConnection>(query);
            return this;
        }

        public QueryRootThemeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootThemeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootThemeQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }

        public QueryRootThemeQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public QueryRootThemeQueryBuilder ProcessingFailed()
        {
            base.InnerQuery.AddField("processingFailed");
            return this;
        }

        public QueryRootThemeQueryBuilder Role()
        {
            base.InnerQuery.AddField("role");
            return this;
        }

        public QueryRootThemeQueryBuilder ThemeStoreId()
        {
            base.InnerQuery.AddField("themeStoreId");
            return this;
        }

        public QueryRootThemeQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public QueryRootThemeQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}