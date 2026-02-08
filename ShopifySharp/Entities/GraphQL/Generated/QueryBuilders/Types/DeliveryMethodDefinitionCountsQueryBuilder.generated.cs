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
    public sealed class DeliveryMethodDefinitionCountsQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinitionCounts, DeliveryMethodDefinitionCountsQueryBuilder>
    {
        protected override DeliveryMethodDefinitionCountsQueryBuilder Self => this;

        public DeliveryMethodDefinitionCountsQueryBuilder() : this("deliveryMethodDefinitionCounts")
        {
        }

        public DeliveryMethodDefinitionCountsQueryBuilder(string name) : base(new Query<DeliveryMethodDefinitionCounts>(name))
        {
        }

        public DeliveryMethodDefinitionCountsQueryBuilder(IQuery<DeliveryMethodDefinitionCounts> query) : base(query)
        {
        }

        public DeliveryMethodDefinitionCountsQueryBuilder ParticipantDefinitionsCount()
        {
            base.InnerQuery.AddField("participantDefinitionsCount");
            return this;
        }

        public DeliveryMethodDefinitionCountsQueryBuilder RateDefinitionsCount()
        {
            base.InnerQuery.AddField("rateDefinitionsCount");
            return this;
        }
    }
}