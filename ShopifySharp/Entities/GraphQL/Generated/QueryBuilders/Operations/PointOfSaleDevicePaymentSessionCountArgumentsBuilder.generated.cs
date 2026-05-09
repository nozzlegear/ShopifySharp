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
    public sealed class PointOfSaleDevicePaymentSessionCountArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionCountPayload, PointOfSaleDevicePaymentSessionCountArgumentsBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionCountArgumentsBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionCountPayload> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder Balance(MoneyInput? balance)
        {
            base.InnerQuery.AddArgument("balance", balance);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder Note(string? note)
        {
            base.InnerQuery.AddArgument("note", note);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder PointOfSaleDevicePaymentSessionId(string? pointOfSaleDevicePaymentSessionId)
        {
            base.InnerQuery.AddArgument("pointOfSaleDevicePaymentSessionId", pointOfSaleDevicePaymentSessionId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder ReasonCodeId(string? reasonCodeId)
        {
            base.InnerQuery.AddArgument("reasonCodeId", reasonCodeId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder StaffMemberId(string? staffMemberId)
        {
            base.InnerQuery.AddArgument("staffMemberId", staffMemberId);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder Time(DateTimeOffset? time)
        {
            base.InnerQuery.AddArgument("time", time);
            return this;
        }
    }
}