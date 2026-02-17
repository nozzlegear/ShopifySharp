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
    public sealed class TranslationUserErrorQueryBuilder : FieldsQueryBuilderBase<TranslationUserError, TranslationUserErrorQueryBuilder>
    {
        protected override TranslationUserErrorQueryBuilder Self => this;

        public TranslationUserErrorQueryBuilder() : this("translationUserError")
        {
        }

        public TranslationUserErrorQueryBuilder(string name) : base(new Query<TranslationUserError>(name))
        {
        }

        public TranslationUserErrorQueryBuilder(IQuery<TranslationUserError> query) : base(query)
        {
        }

        public TranslationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public TranslationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public TranslationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}