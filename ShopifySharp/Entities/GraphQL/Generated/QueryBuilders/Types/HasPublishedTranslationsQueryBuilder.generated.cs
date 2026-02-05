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
    public sealed class HasPublishedTranslationsQueryBuilder : FieldsQueryBuilderBase<IHasPublishedTranslations, HasPublishedTranslationsQueryBuilder>
    {
        protected override HasPublishedTranslationsQueryBuilder Self => this;

        public HasPublishedTranslationsQueryBuilder() : this("hasPublishedTranslations")
        {
        }

        public HasPublishedTranslationsQueryBuilder(string name) : base(new Query<IHasPublishedTranslations>(name))
        {
        }

        public HasPublishedTranslationsQueryBuilder(IQuery<IHasPublishedTranslations> query) : base(query)
        {
        }

        public HasPublishedTranslationsQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}