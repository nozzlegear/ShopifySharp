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
    public sealed class DraftOrderDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderDuplicatePayload, DraftOrderDuplicateOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderDuplicatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderDuplicateArgumentsBuilder Arguments { get; }
        protected override DraftOrderDuplicateOperationQueryBuilder Self => this;

        public DraftOrderDuplicateOperationQueryBuilder() : this("draftOrderDuplicate")
        {
        }

        public DraftOrderDuplicateOperationQueryBuilder(string name) : base(new Query<DraftOrderDuplicatePayload>(name))
        {
            Arguments = new DraftOrderDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderDuplicateOperationQueryBuilder(IQuery<DraftOrderDuplicatePayload> query) : base(query)
        {
            Arguments = new DraftOrderDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderDuplicateOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderDuplicateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}