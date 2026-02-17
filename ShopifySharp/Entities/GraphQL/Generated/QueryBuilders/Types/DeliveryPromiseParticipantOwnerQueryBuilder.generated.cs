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
    public sealed class DeliveryPromiseParticipantOwnerQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantOwner, DeliveryPromiseParticipantOwnerQueryBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerQueryBuilder() : this("deliveryPromiseParticipantOwner")
        {
        }

        public DeliveryPromiseParticipantOwnerQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantOwner>(name))
        {
        }

        public DeliveryPromiseParticipantOwnerQueryBuilder(IQuery<DeliveryPromiseParticipantOwner> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerQueryBuilder DeliveryPromiseParticipantOwner(Action<DeliveryPromiseParticipantOwnerUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantOwner>("deliveryPromiseParticipantOwner");
            var unionBuilder = new DeliveryPromiseParticipantOwnerUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}