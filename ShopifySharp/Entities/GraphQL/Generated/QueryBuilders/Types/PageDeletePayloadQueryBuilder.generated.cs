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
    public sealed class PageDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PageDeletePayload, PageDeletePayloadQueryBuilder>
    {
        protected override PageDeletePayloadQueryBuilder Self => this;

        public PageDeletePayloadQueryBuilder() : this("pageDeletePayload")
        {
        }

        public PageDeletePayloadQueryBuilder(string name) : base(new Query<PageDeletePayload>(name))
        {
        }

        public PageDeletePayloadQueryBuilder(IQuery<PageDeletePayload> query) : base(query)
        {
        }

        public PageDeletePayloadQueryBuilder DeletedPageId()
        {
            base.InnerQuery.AddField("deletedPageId");
            return this;
        }

        public PageDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<PageDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageDeleteUserError>(query);
            return this;
        }
    }
}