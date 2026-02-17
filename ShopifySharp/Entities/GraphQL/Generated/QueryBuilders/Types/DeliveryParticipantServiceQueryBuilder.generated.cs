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
    public sealed class DeliveryParticipantServiceQueryBuilder : FieldsQueryBuilderBase<DeliveryParticipantService, DeliveryParticipantServiceQueryBuilder>
    {
        protected override DeliveryParticipantServiceQueryBuilder Self => this;

        public DeliveryParticipantServiceQueryBuilder() : this("deliveryParticipantService")
        {
        }

        public DeliveryParticipantServiceQueryBuilder(string name) : base(new Query<DeliveryParticipantService>(name))
        {
        }

        public DeliveryParticipantServiceQueryBuilder(IQuery<DeliveryParticipantService> query) : base(query)
        {
        }

        public DeliveryParticipantServiceQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public DeliveryParticipantServiceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}