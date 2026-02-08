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
    public sealed class DraftOrderCompleteOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderCompletePayload, DraftOrderCompleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderCompletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderCompleteArgumentsBuilder Arguments { get; }
        protected override DraftOrderCompleteOperationQueryBuilder Self => this;

        public DraftOrderCompleteOperationQueryBuilder() : this("draftOrderComplete")
        {
        }

        public DraftOrderCompleteOperationQueryBuilder(string name) : base(new Query<DraftOrderCompletePayload>(name))
        {
            Arguments = new DraftOrderCompleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCompleteOperationQueryBuilder(IQuery<DraftOrderCompletePayload> query) : base(query)
        {
            Arguments = new DraftOrderCompleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCompleteOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderCompleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}