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
    public sealed class ThemePublishUserErrorQueryBuilder : FieldsQueryBuilderBase<ThemePublishUserError, ThemePublishUserErrorQueryBuilder>
    {
        protected override ThemePublishUserErrorQueryBuilder Self => this;

        public ThemePublishUserErrorQueryBuilder() : this("themePublishUserError")
        {
        }

        public ThemePublishUserErrorQueryBuilder(string name) : base(new Query<ThemePublishUserError>(name))
        {
        }

        public ThemePublishUserErrorQueryBuilder(IQuery<ThemePublishUserError> query) : base(query)
        {
        }

        public ThemePublishUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ThemePublishUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ThemePublishUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}