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
    public sealed class TranslationsRegisterOperationQueryBuilder : FieldsQueryBuilderBase<TranslationsRegisterPayload, TranslationsRegisterOperationQueryBuilder>, IGraphOperationQueryBuilder<TranslationsRegisterPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TranslationsRegisterArgumentsBuilder Arguments { get; }
        protected override TranslationsRegisterOperationQueryBuilder Self => this;

        public TranslationsRegisterOperationQueryBuilder() : this("translationsRegister")
        {
        }

        public TranslationsRegisterOperationQueryBuilder(string name) : base(new Query<TranslationsRegisterPayload>(name))
        {
            Arguments = new TranslationsRegisterArgumentsBuilder(base.InnerQuery);
        }

        public TranslationsRegisterOperationQueryBuilder(IQuery<TranslationsRegisterPayload> query) : base(query)
        {
            Arguments = new TranslationsRegisterArgumentsBuilder(base.InnerQuery);
        }

        public TranslationsRegisterOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public TranslationsRegisterOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationUserErrorQueryBuilder> build)
        {
            var query = new Query<TranslationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslationUserError>(query);
            return this;
        }
    }
}