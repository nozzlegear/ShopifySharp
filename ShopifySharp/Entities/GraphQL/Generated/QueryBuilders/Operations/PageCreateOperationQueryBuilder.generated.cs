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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PageCreateOperationQueryBuilder : FieldsQueryBuilderBase<PageCreatePayload, PageCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PageCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PageCreateArgumentsBuilder Arguments { get; }
        protected override PageCreateOperationQueryBuilder Self => this;

        public PageCreateOperationQueryBuilder() : this("pageCreate")
        {
        }

        public PageCreateOperationQueryBuilder(string name) : base(new Query<PageCreatePayload>(name))
        {
            Arguments = new PageCreateArgumentsBuilder(base.InnerQuery);
        }

        public PageCreateOperationQueryBuilder(IQuery<PageCreatePayload> query) : base(query)
        {
            Arguments = new PageCreateArgumentsBuilder(base.InnerQuery);
        }

        public PageCreateOperationQueryBuilder Page(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("page");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public PageCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PageCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageCreateUserError>(query);
            return this;
        }
    }
}