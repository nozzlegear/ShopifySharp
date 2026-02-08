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
    public sealed class DisputeEvidenceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DisputeEvidenceUpdatePayload, DisputeEvidenceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DisputeEvidenceUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DisputeEvidenceUpdateArgumentsBuilder Arguments { get; }
        protected override DisputeEvidenceUpdateOperationQueryBuilder Self => this;

        public DisputeEvidenceUpdateOperationQueryBuilder() : this("disputeEvidenceUpdate")
        {
        }

        public DisputeEvidenceUpdateOperationQueryBuilder(string name) : base(new Query<DisputeEvidenceUpdatePayload>(name))
        {
            Arguments = new DisputeEvidenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DisputeEvidenceUpdateOperationQueryBuilder(IQuery<DisputeEvidenceUpdatePayload> query) : base(query)
        {
            Arguments = new DisputeEvidenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DisputeEvidenceUpdateOperationQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public DisputeEvidenceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DisputeEvidenceUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<DisputeEvidenceUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DisputeEvidenceUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DisputeEvidenceUpdateUserError>(query);
            return this;
        }
    }
}