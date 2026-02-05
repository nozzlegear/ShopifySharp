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
    public sealed class CookieBannerQueryBuilder : FieldsQueryBuilderBase<CookieBanner, CookieBannerQueryBuilder>
    {
        protected override CookieBannerQueryBuilder Self => this;

        public CookieBannerQueryBuilder() : this("cookieBanner")
        {
        }

        public CookieBannerQueryBuilder(string name) : base(new Query<CookieBanner>(name))
        {
        }

        public CookieBannerQueryBuilder(IQuery<CookieBanner> query) : base(query)
        {
        }

        public CookieBannerQueryBuilder AutoManaged()
        {
            base.InnerQuery.AddField("autoManaged");
            return this;
        }

        public CookieBannerQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public CookieBannerQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}