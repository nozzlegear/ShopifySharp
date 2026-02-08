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
    public sealed class AbandonmentEmailStateUpdateArgumentsBuilder : ArgumentsBuilderBase<AbandonmentEmailStateUpdatePayload, AbandonmentEmailStateUpdateArgumentsBuilder>
    {
        protected override AbandonmentEmailStateUpdateArgumentsBuilder Self => this;

        public AbandonmentEmailStateUpdateArgumentsBuilder(IQuery<AbandonmentEmailStateUpdatePayload> query) : base(query)
        {
        }

        public AbandonmentEmailStateUpdateArgumentsBuilder EmailSentAt(DateTimeOffset? emailSentAt)
        {
            base.InnerQuery.AddArgument("emailSentAt", emailSentAt);
            return this;
        }

        public AbandonmentEmailStateUpdateArgumentsBuilder EmailState(AbandonmentEmailState? emailState)
        {
            base.InnerQuery.AddArgument("emailState", emailState);
            return this;
        }

        public AbandonmentEmailStateUpdateArgumentsBuilder EmailStateChangeReason(string? emailStateChangeReason)
        {
            base.InnerQuery.AddArgument("emailStateChangeReason", emailStateChangeReason);
            return this;
        }

        public AbandonmentEmailStateUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}