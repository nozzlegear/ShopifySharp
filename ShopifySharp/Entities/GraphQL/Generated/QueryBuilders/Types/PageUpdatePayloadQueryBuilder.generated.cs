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
    public sealed class PageUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PageUpdatePayload, PageUpdatePayloadQueryBuilder>
    {
        protected override PageUpdatePayloadQueryBuilder Self => this;

        public PageUpdatePayloadQueryBuilder() : this("pageUpdatePayload")
        {
        }

        public PageUpdatePayloadQueryBuilder(string name) : base(new Query<PageUpdatePayload>(name))
        {
        }

        public PageUpdatePayloadQueryBuilder(IQuery<PageUpdatePayload> query) : base(query)
        {
        }

        public PageUpdatePayloadQueryBuilder Page(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("page");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public PageUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PageUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageUpdateUserError>(query);
            return this;
        }
    }
}