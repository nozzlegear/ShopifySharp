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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DeliveryPromiseParticipantsUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantsUpdatePayload, DeliveryPromiseParticipantsUpdatePayloadQueryBuilder>
    {
        protected override DeliveryPromiseParticipantsUpdatePayloadQueryBuilder Self => this;

        public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder() : this("deliveryPromiseParticipantsUpdatePayload")
        {
        }

        public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantsUpdatePayload>(name))
        {
        }

        public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder(IQuery<DeliveryPromiseParticipantsUpdatePayload> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder PromiseParticipants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("promiseParticipants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }

        public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}