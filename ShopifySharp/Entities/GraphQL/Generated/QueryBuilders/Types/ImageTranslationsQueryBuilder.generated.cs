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
    public sealed class ImageTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ImageTranslationsQueryBuilder>, IHasArguments<ImageTranslationsArgumentsBuilder>
    {
        public ImageTranslationsArgumentsBuilder Arguments { get; }
        protected override ImageTranslationsQueryBuilder Self => this;

        public ImageTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ImageTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ImageTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ImageTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ImageTranslationsQueryBuilder SetArguments(Action<ImageTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ImageTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ImageTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ImageTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ImageTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ImageTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ImageTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}