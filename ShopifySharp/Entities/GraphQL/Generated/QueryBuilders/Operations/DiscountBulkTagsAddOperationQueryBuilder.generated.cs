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
    public sealed class DiscountBulkTagsAddOperationQueryBuilder : FieldsQueryBuilderBase<DiscountBulkTagsAddPayload, DiscountBulkTagsAddOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountBulkTagsAddPayload>, IHasArguments<DiscountBulkTagsAddArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountBulkTagsAddArgumentsBuilder Arguments { get; }
        protected override DiscountBulkTagsAddOperationQueryBuilder Self => this;

        public DiscountBulkTagsAddOperationQueryBuilder() : this("discountBulkTagsAdd")
        {
        }

        public DiscountBulkTagsAddOperationQueryBuilder(string name) : base(new Query<DiscountBulkTagsAddPayload>(name))
        {
            Arguments = new DiscountBulkTagsAddArgumentsBuilder(base.InnerQuery);
        }

        public DiscountBulkTagsAddOperationQueryBuilder(IQuery<DiscountBulkTagsAddPayload> query) : base(query)
        {
            Arguments = new DiscountBulkTagsAddArgumentsBuilder(base.InnerQuery);
        }

        public DiscountBulkTagsAddOperationQueryBuilder SetArguments(Action<DiscountBulkTagsAddArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountBulkTagsAddOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountBulkTagsAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}