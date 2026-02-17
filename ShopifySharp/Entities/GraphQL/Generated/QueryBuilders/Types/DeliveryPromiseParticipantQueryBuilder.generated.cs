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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DeliveryPromiseParticipantQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipant, DeliveryPromiseParticipantQueryBuilder>
    {
        protected override DeliveryPromiseParticipantQueryBuilder Self => this;

        public DeliveryPromiseParticipantQueryBuilder() : this("deliveryPromiseParticipant")
        {
        }

        public DeliveryPromiseParticipantQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipant>(name))
        {
        }

        public DeliveryPromiseParticipantQueryBuilder(IQuery<DeliveryPromiseParticipant> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryPromiseParticipantQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public DeliveryPromiseParticipantQueryBuilder Owner(Action<DeliveryPromiseParticipantOwnerUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantOwner>("owner");
            var unionBuilder = new DeliveryPromiseParticipantOwnerUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}