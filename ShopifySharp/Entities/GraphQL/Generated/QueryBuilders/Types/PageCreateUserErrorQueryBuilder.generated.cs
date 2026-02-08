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
    public sealed class PageCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<PageCreateUserError, PageCreateUserErrorQueryBuilder>
    {
        protected override PageCreateUserErrorQueryBuilder Self => this;

        public PageCreateUserErrorQueryBuilder() : this("pageCreateUserError")
        {
        }

        public PageCreateUserErrorQueryBuilder(string name) : base(new Query<PageCreateUserError>(name))
        {
        }

        public PageCreateUserErrorQueryBuilder(IQuery<PageCreateUserError> query) : base(query)
        {
        }

        public PageCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PageCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PageCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}