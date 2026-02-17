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
    public sealed class DeliveryMethodAdditionalInformationQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodAdditionalInformation, DeliveryMethodAdditionalInformationQueryBuilder>
    {
        protected override DeliveryMethodAdditionalInformationQueryBuilder Self => this;

        public DeliveryMethodAdditionalInformationQueryBuilder() : this("deliveryMethodAdditionalInformation")
        {
        }

        public DeliveryMethodAdditionalInformationQueryBuilder(string name) : base(new Query<DeliveryMethodAdditionalInformation>(name))
        {
        }

        public DeliveryMethodAdditionalInformationQueryBuilder(IQuery<DeliveryMethodAdditionalInformation> query) : base(query)
        {
        }

        public DeliveryMethodAdditionalInformationQueryBuilder Instructions()
        {
            base.InnerQuery.AddField("instructions");
            return this;
        }

        public DeliveryMethodAdditionalInformationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }
    }
}