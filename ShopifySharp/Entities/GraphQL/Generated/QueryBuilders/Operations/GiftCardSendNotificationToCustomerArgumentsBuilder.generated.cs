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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class GiftCardSendNotificationToCustomerArgumentsBuilder : ArgumentsBuilderBase<GiftCardSendNotificationToCustomerPayload, GiftCardSendNotificationToCustomerArgumentsBuilder>
    {
        protected override GiftCardSendNotificationToCustomerArgumentsBuilder Self => this;

        public GiftCardSendNotificationToCustomerArgumentsBuilder(IQuery<GiftCardSendNotificationToCustomerPayload> query) : base(query)
        {
        }

        public GiftCardSendNotificationToCustomerArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}