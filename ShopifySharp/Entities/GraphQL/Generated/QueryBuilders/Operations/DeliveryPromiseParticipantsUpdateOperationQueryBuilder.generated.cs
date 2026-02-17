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
    public sealed class DeliveryPromiseParticipantsUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantsUpdatePayload, DeliveryPromiseParticipantsUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryPromiseParticipantsUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryPromiseParticipantsUpdateArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantsUpdateOperationQueryBuilder Self => this;

        public DeliveryPromiseParticipantsUpdateOperationQueryBuilder() : this("deliveryPromiseParticipantsUpdate")
        {
        }

        public DeliveryPromiseParticipantsUpdateOperationQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantsUpdatePayload>(name))
        {
            Arguments = new DeliveryPromiseParticipantsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantsUpdateOperationQueryBuilder(IQuery<DeliveryPromiseParticipantsUpdatePayload> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantsUpdateOperationQueryBuilder PromiseParticipants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("promiseParticipants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }

        public DeliveryPromiseParticipantsUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}