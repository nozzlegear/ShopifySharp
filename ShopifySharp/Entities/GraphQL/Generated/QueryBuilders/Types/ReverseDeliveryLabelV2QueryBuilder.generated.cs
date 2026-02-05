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
    public sealed class ReverseDeliveryLabelV2QueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryLabelV2, ReverseDeliveryLabelV2QueryBuilder>
    {
        protected override ReverseDeliveryLabelV2QueryBuilder Self => this;

        public ReverseDeliveryLabelV2QueryBuilder() : this("reverseDeliveryLabelV2")
        {
        }

        public ReverseDeliveryLabelV2QueryBuilder(string name) : base(new Query<ReverseDeliveryLabelV2>(name))
        {
        }

        public ReverseDeliveryLabelV2QueryBuilder(IQuery<ReverseDeliveryLabelV2> query) : base(query)
        {
        }

        public ReverseDeliveryLabelV2QueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ReverseDeliveryLabelV2QueryBuilder PublicFileUrl()
        {
            base.InnerQuery.AddField("publicFileUrl");
            return this;
        }

        public ReverseDeliveryLabelV2QueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}