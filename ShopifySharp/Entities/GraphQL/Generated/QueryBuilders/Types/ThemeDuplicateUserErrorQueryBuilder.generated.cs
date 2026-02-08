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
    public sealed class ThemeDuplicateUserErrorQueryBuilder : FieldsQueryBuilderBase<ThemeDuplicateUserError, ThemeDuplicateUserErrorQueryBuilder>
    {
        protected override ThemeDuplicateUserErrorQueryBuilder Self => this;

        public ThemeDuplicateUserErrorQueryBuilder() : this("themeDuplicateUserError")
        {
        }

        public ThemeDuplicateUserErrorQueryBuilder(string name) : base(new Query<ThemeDuplicateUserError>(name))
        {
        }

        public ThemeDuplicateUserErrorQueryBuilder(IQuery<ThemeDuplicateUserError> query) : base(query)
        {
        }

        public ThemeDuplicateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ThemeDuplicateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ThemeDuplicateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}