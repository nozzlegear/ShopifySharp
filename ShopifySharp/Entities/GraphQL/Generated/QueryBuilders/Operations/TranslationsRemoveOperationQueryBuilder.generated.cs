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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class TranslationsRemoveOperationQueryBuilder : FieldsQueryBuilderBase<TranslationsRemovePayload, TranslationsRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<TranslationsRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TranslationsRemoveArgumentsBuilder Arguments { get; }
        protected override TranslationsRemoveOperationQueryBuilder Self => this;

        public TranslationsRemoveOperationQueryBuilder() : this("translationsRemove")
        {
        }

        public TranslationsRemoveOperationQueryBuilder(string name) : base(new Query<TranslationsRemovePayload>(name))
        {
            Arguments = new TranslationsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public TranslationsRemoveOperationQueryBuilder(IQuery<TranslationsRemovePayload> query) : base(query)
        {
            Arguments = new TranslationsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public TranslationsRemoveOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public TranslationsRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder> build)
        {
            var query = new Query<TranslationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslationUserError>(query);
            return this;
        }
    }
}