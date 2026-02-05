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
    public sealed class PageDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<PageDeleteUserError, PageDeleteUserErrorQueryBuilder>
    {
        protected override PageDeleteUserErrorQueryBuilder Self => this;

        public PageDeleteUserErrorQueryBuilder() : this("pageDeleteUserError")
        {
        }

        public PageDeleteUserErrorQueryBuilder(string name) : base(new Query<PageDeleteUserError>(name))
        {
        }

        public PageDeleteUserErrorQueryBuilder(IQuery<PageDeleteUserError> query) : base(query)
        {
        }

        public PageDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PageDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PageDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}