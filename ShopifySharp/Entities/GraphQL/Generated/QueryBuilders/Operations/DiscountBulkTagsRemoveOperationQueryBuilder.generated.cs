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
    public sealed class DiscountBulkTagsRemoveOperationQueryBuilder : FieldsQueryBuilderBase<DiscountBulkTagsRemovePayload, DiscountBulkTagsRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountBulkTagsRemovePayload>, IHasArguments<DiscountBulkTagsRemoveArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountBulkTagsRemoveArgumentsBuilder Arguments { get; }
        protected override DiscountBulkTagsRemoveOperationQueryBuilder Self => this;

        public DiscountBulkTagsRemoveOperationQueryBuilder() : this("discountBulkTagsRemove")
        {
        }

        public DiscountBulkTagsRemoveOperationQueryBuilder(string name) : base(new Query<DiscountBulkTagsRemovePayload>(name))
        {
            Arguments = new DiscountBulkTagsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public DiscountBulkTagsRemoveOperationQueryBuilder(IQuery<DiscountBulkTagsRemovePayload> query) : base(query)
        {
            Arguments = new DiscountBulkTagsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public DiscountBulkTagsRemoveOperationQueryBuilder SetArguments(Action<DiscountBulkTagsRemoveArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountBulkTagsRemoveOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountBulkTagsRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}