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
    public sealed class ThemeCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ThemeCreateUserError, ThemeCreateUserErrorQueryBuilder>
    {
        protected override ThemeCreateUserErrorQueryBuilder Self => this;

        public ThemeCreateUserErrorQueryBuilder() : this("themeCreateUserError")
        {
        }

        public ThemeCreateUserErrorQueryBuilder(string name) : base(new Query<ThemeCreateUserError>(name))
        {
        }

        public ThemeCreateUserErrorQueryBuilder(IQuery<ThemeCreateUserError> query) : base(query)
        {
        }

        public ThemeCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ThemeCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ThemeCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}