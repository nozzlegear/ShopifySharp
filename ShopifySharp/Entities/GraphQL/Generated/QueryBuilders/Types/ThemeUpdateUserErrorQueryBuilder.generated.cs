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
    public sealed class ThemeUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ThemeUpdateUserError, ThemeUpdateUserErrorQueryBuilder>
    {
        protected override ThemeUpdateUserErrorQueryBuilder Self => this;

        public ThemeUpdateUserErrorQueryBuilder() : this("themeUpdateUserError")
        {
        }

        public ThemeUpdateUserErrorQueryBuilder(string name) : base(new Query<ThemeUpdateUserError>(name))
        {
        }

        public ThemeUpdateUserErrorQueryBuilder(IQuery<ThemeUpdateUserError> query) : base(query)
        {
        }

        public ThemeUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ThemeUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ThemeUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}