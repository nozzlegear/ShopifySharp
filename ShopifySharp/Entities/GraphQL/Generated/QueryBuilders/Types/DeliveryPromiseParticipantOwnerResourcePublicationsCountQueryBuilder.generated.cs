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
    public sealed class DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder>, IHasArguments<DeliveryPromiseParticipantOwnerResourcePublicationsCountArgumentsBuilder>
    {
        public DeliveryPromiseParticipantOwnerResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new DeliveryPromiseParticipantOwnerResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantOwnerResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder SetArguments(Action<DeliveryPromiseParticipantOwnerResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}