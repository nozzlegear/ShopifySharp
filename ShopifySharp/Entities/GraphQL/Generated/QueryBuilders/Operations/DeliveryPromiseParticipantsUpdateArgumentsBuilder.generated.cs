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
    public sealed class DeliveryPromiseParticipantsUpdateArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseParticipantsUpdatePayload, DeliveryPromiseParticipantsUpdateArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantsUpdateArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantsUpdateArgumentsBuilder(IQuery<DeliveryPromiseParticipantsUpdatePayload> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantsUpdateArgumentsBuilder BrandedPromiseHandle(string? brandedPromiseHandle)
        {
            base.InnerQuery.AddArgument("brandedPromiseHandle", brandedPromiseHandle);
            return this;
        }

        public DeliveryPromiseParticipantsUpdateArgumentsBuilder OwnersToAdd(ICollection<string>? ownersToAdd)
        {
            base.InnerQuery.AddArgument("ownersToAdd", ownersToAdd);
            return this;
        }

        public DeliveryPromiseParticipantsUpdateArgumentsBuilder OwnersToRemove(ICollection<string>? ownersToRemove)
        {
            base.InnerQuery.AddArgument("ownersToRemove", ownersToRemove);
            return this;
        }
    }
}