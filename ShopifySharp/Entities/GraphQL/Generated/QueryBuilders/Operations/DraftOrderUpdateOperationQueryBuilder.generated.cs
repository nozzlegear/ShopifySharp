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
    public sealed class DraftOrderUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderUpdatePayload, DraftOrderUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderUpdateArgumentsBuilder Arguments { get; }
        protected override DraftOrderUpdateOperationQueryBuilder Self => this;

        public DraftOrderUpdateOperationQueryBuilder() : this("draftOrderUpdate")
        {
        }

        public DraftOrderUpdateOperationQueryBuilder(string name) : base(new Query<DraftOrderUpdatePayload>(name))
        {
            Arguments = new DraftOrderUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderUpdateOperationQueryBuilder(IQuery<DraftOrderUpdatePayload> query) : base(query)
        {
            Arguments = new DraftOrderUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderUpdateOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}