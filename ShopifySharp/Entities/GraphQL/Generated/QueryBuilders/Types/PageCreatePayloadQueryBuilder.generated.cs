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
    public sealed class PageCreatePayloadQueryBuilder : FieldsQueryBuilderBase<PageCreatePayload, PageCreatePayloadQueryBuilder>
    {
        protected override PageCreatePayloadQueryBuilder Self => this;

        public PageCreatePayloadQueryBuilder() : this("pageCreatePayload")
        {
        }

        public PageCreatePayloadQueryBuilder(string name) : base(new Query<PageCreatePayload>(name))
        {
        }

        public PageCreatePayloadQueryBuilder(IQuery<PageCreatePayload> query) : base(query)
        {
        }

        public PageCreatePayloadQueryBuilder Page(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("page");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public PageCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PageCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageCreateUserError>(query);
            return this;
        }
    }
}