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
    public sealed class QueryRootDisputeEvidenceArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsDisputeEvidence?, QueryRootDisputeEvidenceArgumentsBuilder>
    {
        protected override QueryRootDisputeEvidenceArgumentsBuilder Self => this;

        public QueryRootDisputeEvidenceArgumentsBuilder(IQuery<ShopifyPaymentsDisputeEvidence?> query) : base(query)
        {
        }

        public QueryRootDisputeEvidenceArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}