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
    public sealed class TranslationsRegisterPayloadQueryBuilder : FieldsQueryBuilderBase<TranslationsRegisterPayload, TranslationsRegisterPayloadQueryBuilder>
    {
        protected override TranslationsRegisterPayloadQueryBuilder Self => this;

        public TranslationsRegisterPayloadQueryBuilder() : this("translationsRegisterPayload")
        {
        }

        public TranslationsRegisterPayloadQueryBuilder(string name) : base(new Query<TranslationsRegisterPayload>(name))
        {
        }

        public TranslationsRegisterPayloadQueryBuilder(IQuery<TranslationsRegisterPayload> query) : base(query)
        {
        }

        public TranslationsRegisterPayloadQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public TranslationsRegisterPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder> build)
        {
            var query = new Query<TranslationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslationUserError>(query);
            return this;
        }
    }
}