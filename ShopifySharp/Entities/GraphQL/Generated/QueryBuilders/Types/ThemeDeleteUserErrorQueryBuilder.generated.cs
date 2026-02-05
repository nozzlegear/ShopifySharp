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
    public sealed class ThemeDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ThemeDeleteUserError, ThemeDeleteUserErrorQueryBuilder>
    {
        protected override ThemeDeleteUserErrorQueryBuilder Self => this;

        public ThemeDeleteUserErrorQueryBuilder() : this("themeDeleteUserError")
        {
        }

        public ThemeDeleteUserErrorQueryBuilder(string name) : base(new Query<ThemeDeleteUserError>(name))
        {
        }

        public ThemeDeleteUserErrorQueryBuilder(IQuery<ThemeDeleteUserError> query) : base(query)
        {
        }

        public ThemeDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ThemeDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ThemeDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}