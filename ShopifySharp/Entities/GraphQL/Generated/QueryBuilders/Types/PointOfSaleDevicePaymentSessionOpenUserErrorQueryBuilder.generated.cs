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
    public sealed class PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionOpenUserError, PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder() : this("pointOfSaleDevicePaymentSessionOpenUserError")
        {
        }

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionOpenUserError>(name))
        {
        }

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionOpenUserError> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}