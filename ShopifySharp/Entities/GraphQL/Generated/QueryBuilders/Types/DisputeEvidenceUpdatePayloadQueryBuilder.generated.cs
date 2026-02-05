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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DisputeEvidenceUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DisputeEvidenceUpdatePayload, DisputeEvidenceUpdatePayloadQueryBuilder>
    {
        protected override DisputeEvidenceUpdatePayloadQueryBuilder Self => this;

        public DisputeEvidenceUpdatePayloadQueryBuilder() : this("disputeEvidenceUpdatePayload")
        {
        }

        public DisputeEvidenceUpdatePayloadQueryBuilder(string name) : base(new Query<DisputeEvidenceUpdatePayload>(name))
        {
        }

        public DisputeEvidenceUpdatePayloadQueryBuilder(IQuery<DisputeEvidenceUpdatePayload> query) : base(query)
        {
        }

        public DisputeEvidenceUpdatePayloadQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public DisputeEvidenceUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DisputeEvidenceUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<DisputeEvidenceUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DisputeEvidenceUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DisputeEvidenceUpdateUserError>(query);
            return this;
        }
    }
}