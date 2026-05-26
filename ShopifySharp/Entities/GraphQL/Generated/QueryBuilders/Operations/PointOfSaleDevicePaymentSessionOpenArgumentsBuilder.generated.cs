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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class PointOfSaleDevicePaymentSessionOpenArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionOpenPayload, PointOfSaleDevicePaymentSessionOpenArgumentsBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionOpenArgumentsBuilder Self => this;

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionOpenPayload> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder Balance(MoneyInput? balance)
        {
            base.InnerQuery.AddArgument("balance", balance);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder Note(string? note)
        {
            base.InnerQuery.AddArgument("note", note);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder PointOfSaleDeviceId(string? pointOfSaleDeviceId)
        {
            base.InnerQuery.AddArgument("pointOfSaleDeviceId", pointOfSaleDeviceId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder ReasonCodeId(string? reasonCodeId)
        {
            base.InnerQuery.AddArgument("reasonCodeId", reasonCodeId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder StaffMemberId(string? staffMemberId)
        {
            base.InnerQuery.AddArgument("staffMemberId", staffMemberId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder Time(DateTimeOffset? time)
        {
            base.InnerQuery.AddArgument("time", time);
            return this;
        }
    }
}