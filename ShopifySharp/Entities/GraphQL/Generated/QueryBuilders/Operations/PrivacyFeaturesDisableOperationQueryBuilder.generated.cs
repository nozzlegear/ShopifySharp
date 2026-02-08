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
    public sealed class PrivacyFeaturesDisableOperationQueryBuilder : FieldsQueryBuilderBase<PrivacyFeaturesDisablePayload, PrivacyFeaturesDisableOperationQueryBuilder>, IGraphOperationQueryBuilder<PrivacyFeaturesDisablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PrivacyFeaturesDisableArgumentsBuilder Arguments { get; }
        protected override PrivacyFeaturesDisableOperationQueryBuilder Self => this;

        public PrivacyFeaturesDisableOperationQueryBuilder() : this("privacyFeaturesDisable")
        {
        }

        public PrivacyFeaturesDisableOperationQueryBuilder(string name) : base(new Query<PrivacyFeaturesDisablePayload>(name))
        {
            Arguments = new PrivacyFeaturesDisableArgumentsBuilder(base.InnerQuery);
        }

        public PrivacyFeaturesDisableOperationQueryBuilder(IQuery<PrivacyFeaturesDisablePayload> query) : base(query)
        {
            Arguments = new PrivacyFeaturesDisableArgumentsBuilder(base.InnerQuery);
        }

        public PrivacyFeaturesDisableOperationQueryBuilder FeaturesDisabled()
        {
            base.InnerQuery.AddField("featuresDisabled");
            return this;
        }

        public PrivacyFeaturesDisableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyFeaturesDisableUserErrorQueryBuilder> build)
        {
            var query = new Query<PrivacyFeaturesDisableUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyFeaturesDisableUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PrivacyFeaturesDisableUserError>(query);
            return this;
        }
    }
}