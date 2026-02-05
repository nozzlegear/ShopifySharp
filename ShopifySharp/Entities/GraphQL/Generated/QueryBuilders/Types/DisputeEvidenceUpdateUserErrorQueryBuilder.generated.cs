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
    public sealed class DisputeEvidenceUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<DisputeEvidenceUpdateUserError, DisputeEvidenceUpdateUserErrorQueryBuilder>
    {
        protected override DisputeEvidenceUpdateUserErrorQueryBuilder Self => this;

        public DisputeEvidenceUpdateUserErrorQueryBuilder() : this("disputeEvidenceUpdateUserError")
        {
        }

        public DisputeEvidenceUpdateUserErrorQueryBuilder(string name) : base(new Query<DisputeEvidenceUpdateUserError>(name))
        {
        }

        public DisputeEvidenceUpdateUserErrorQueryBuilder(IQuery<DisputeEvidenceUpdateUserError> query) : base(query)
        {
        }

        public DisputeEvidenceUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DisputeEvidenceUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DisputeEvidenceUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}