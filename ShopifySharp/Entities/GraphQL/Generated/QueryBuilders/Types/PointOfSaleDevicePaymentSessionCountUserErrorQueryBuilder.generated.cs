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
    public sealed class PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionCountUserError, PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder() : this("pointOfSaleDevicePaymentSessionCountUserError")
        {
        }

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionCountUserError>(name))
        {
        }

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionCountUserError> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}