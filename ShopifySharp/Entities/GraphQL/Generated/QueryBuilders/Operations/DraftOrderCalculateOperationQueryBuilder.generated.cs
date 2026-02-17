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
    public sealed class DraftOrderCalculateOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderCalculatePayload, DraftOrderCalculateOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderCalculatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderCalculateArgumentsBuilder Arguments { get; }
        protected override DraftOrderCalculateOperationQueryBuilder Self => this;

        public DraftOrderCalculateOperationQueryBuilder() : this("draftOrderCalculate")
        {
        }

        public DraftOrderCalculateOperationQueryBuilder(string name) : base(new Query<DraftOrderCalculatePayload>(name))
        {
            Arguments = new DraftOrderCalculateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCalculateOperationQueryBuilder(IQuery<DraftOrderCalculatePayload> query) : base(query)
        {
            Arguments = new DraftOrderCalculateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCalculateOperationQueryBuilder CalculatedDraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDraftOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrder>("calculatedDraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDraftOrder>(query);
            return this;
        }

        public DraftOrderCalculateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}