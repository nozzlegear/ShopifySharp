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
    public sealed class PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionCloseUserError, PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder() : this("pointOfSaleDevicePaymentSessionCloseUserError")
        {
        }

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionCloseUserError>(name))
        {
        }

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionCloseUserError> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}