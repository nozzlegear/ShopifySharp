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
    public sealed class DisputeEvidenceUpdateArgumentsBuilder : ArgumentsBuilderBase<DisputeEvidenceUpdatePayload, DisputeEvidenceUpdateArgumentsBuilder>
    {
        protected override DisputeEvidenceUpdateArgumentsBuilder Self => this;

        public DisputeEvidenceUpdateArgumentsBuilder(IQuery<DisputeEvidenceUpdatePayload> query) : base(query)
        {
        }

        public DisputeEvidenceUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public DisputeEvidenceUpdateArgumentsBuilder Input(ShopifyPaymentsDisputeEvidenceUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}