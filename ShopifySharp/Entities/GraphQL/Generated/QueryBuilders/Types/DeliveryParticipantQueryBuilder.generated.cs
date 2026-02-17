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
    public sealed class DeliveryParticipantQueryBuilder : FieldsQueryBuilderBase<DeliveryParticipant, DeliveryParticipantQueryBuilder>
    {
        protected override DeliveryParticipantQueryBuilder Self => this;

        public DeliveryParticipantQueryBuilder() : this("deliveryParticipant")
        {
        }

        public DeliveryParticipantQueryBuilder(string name) : base(new Query<DeliveryParticipant>(name))
        {
        }

        public DeliveryParticipantQueryBuilder(IQuery<DeliveryParticipant> query) : base(query)
        {
        }

        public DeliveryParticipantQueryBuilder AdaptToNewServicesFlag()
        {
            base.InnerQuery.AddField("adaptToNewServicesFlag");
            return this;
        }

        public DeliveryParticipantQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public DeliveryParticipantQueryBuilder FixedFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("fixedFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryParticipantQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryParticipantQueryBuilder ParticipantServices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryParticipantServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryParticipantService>("participantServices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryParticipantServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryParticipantService>(query);
            return this;
        }

        public DeliveryParticipantQueryBuilder PercentageOfRateFee()
        {
            base.InnerQuery.AddField("percentageOfRateFee");
            return this;
        }
    }
}