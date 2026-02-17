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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class PageUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PageUpdatePayload, PageUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PageUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PageUpdateArgumentsBuilder Arguments { get; }
        protected override PageUpdateOperationQueryBuilder Self => this;

        public PageUpdateOperationQueryBuilder() : this("pageUpdate")
        {
        }

        public PageUpdateOperationQueryBuilder(string name) : base(new Query<PageUpdatePayload>(name))
        {
            Arguments = new PageUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PageUpdateOperationQueryBuilder(IQuery<PageUpdatePayload> query) : base(query)
        {
            Arguments = new PageUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PageUpdateOperationQueryBuilder Page(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("page");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public PageUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PageUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageUpdateUserError>(query);
            return this;
        }
    }
}