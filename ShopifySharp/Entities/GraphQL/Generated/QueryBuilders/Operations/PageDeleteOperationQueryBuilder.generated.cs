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
    public sealed class PageDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PageDeletePayload, PageDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PageDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PageDeleteArgumentsBuilder Arguments { get; }
        protected override PageDeleteOperationQueryBuilder Self => this;

        public PageDeleteOperationQueryBuilder() : this("pageDelete")
        {
        }

        public PageDeleteOperationQueryBuilder(string name) : base(new Query<PageDeletePayload>(name))
        {
            Arguments = new PageDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PageDeleteOperationQueryBuilder(IQuery<PageDeletePayload> query) : base(query)
        {
            Arguments = new PageDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PageDeleteOperationQueryBuilder DeletedPageId()
        {
            base.InnerQuery.AddField("deletedPageId");
            return this;
        }

        public PageDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<PageDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageDeleteUserError>(query);
            return this;
        }
    }
}