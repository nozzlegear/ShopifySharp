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
    public sealed class PointOfSaleDevicePaymentSessionCloseArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionClosePayload, PointOfSaleDevicePaymentSessionCloseArgumentsBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionCloseArgumentsBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionClosePayload> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder Balance(MoneyInput? balance)
        {
            base.InnerQuery.AddArgument("balance", balance);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder Note(string? note)
        {
            base.InnerQuery.AddArgument("note", note);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder PointOfSaleDevicePaymentSessionId(string? pointOfSaleDevicePaymentSessionId)
        {
            base.InnerQuery.AddArgument("pointOfSaleDevicePaymentSessionId", pointOfSaleDevicePaymentSessionId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder ReasonCodeId(string? reasonCodeId)
        {
            base.InnerQuery.AddArgument("reasonCodeId", reasonCodeId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder StaffMemberId(string? staffMemberId)
        {
            base.InnerQuery.AddArgument("staffMemberId", staffMemberId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder Time(DateTimeOffset? time)
        {
            base.InnerQuery.AddArgument("time", time);
            return this;
        }
    }
}