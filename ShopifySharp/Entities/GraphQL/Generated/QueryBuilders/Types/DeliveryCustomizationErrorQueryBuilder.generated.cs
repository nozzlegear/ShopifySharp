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
    public sealed class DeliveryCustomizationErrorQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationError, DeliveryCustomizationErrorQueryBuilder>
    {
        protected override DeliveryCustomizationErrorQueryBuilder Self => this;

        public DeliveryCustomizationErrorQueryBuilder() : this("deliveryCustomizationError")
        {
        }

        public DeliveryCustomizationErrorQueryBuilder(string name) : base(new Query<DeliveryCustomizationError>(name))
        {
        }

        public DeliveryCustomizationErrorQueryBuilder(IQuery<DeliveryCustomizationError> query) : base(query)
        {
        }

        public DeliveryCustomizationErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DeliveryCustomizationErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DeliveryCustomizationErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}