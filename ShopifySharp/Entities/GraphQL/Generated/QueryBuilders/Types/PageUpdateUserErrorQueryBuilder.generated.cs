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
    public sealed class PageUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<PageUpdateUserError, PageUpdateUserErrorQueryBuilder>
    {
        protected override PageUpdateUserErrorQueryBuilder Self => this;

        public PageUpdateUserErrorQueryBuilder() : this("pageUpdateUserError")
        {
        }

        public PageUpdateUserErrorQueryBuilder(string name) : base(new Query<PageUpdateUserError>(name))
        {
        }

        public PageUpdateUserErrorQueryBuilder(IQuery<PageUpdateUserError> query) : base(query)
        {
        }

        public PageUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PageUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PageUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}