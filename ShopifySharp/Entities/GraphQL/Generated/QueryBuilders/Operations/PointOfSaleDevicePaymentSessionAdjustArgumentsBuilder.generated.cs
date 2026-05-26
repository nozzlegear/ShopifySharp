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
    public sealed class PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionAdjustPayload, PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder Self => this;

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionAdjustPayload> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder Cash(MoneyInput? cash)
        {
            base.InnerQuery.AddArgument("cash", cash);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder Note(string? note)
        {
            base.InnerQuery.AddArgument("note", note);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder PointOfSaleDevicePaymentSessionId(string? pointOfSaleDevicePaymentSessionId)
        {
            base.InnerQuery.AddArgument("pointOfSaleDevicePaymentSessionId", pointOfSaleDevicePaymentSessionId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder ReasonCodeId(string? reasonCodeId)
        {
            base.InnerQuery.AddArgument("reasonCodeId", reasonCodeId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder StaffMemberId(string? staffMemberId)
        {
            base.InnerQuery.AddArgument("staffMemberId", staffMemberId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder Time(DateTimeOffset? time)
        {
            base.InnerQuery.AddArgument("time", time);
            return this;
        }
    }
}