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
    public sealed class PrivacyFeaturesDisablePayloadQueryBuilder : FieldsQueryBuilderBase<PrivacyFeaturesDisablePayload, PrivacyFeaturesDisablePayloadQueryBuilder>
    {
        protected override PrivacyFeaturesDisablePayloadQueryBuilder Self => this;

        public PrivacyFeaturesDisablePayloadQueryBuilder() : this("privacyFeaturesDisablePayload")
        {
        }

        public PrivacyFeaturesDisablePayloadQueryBuilder(string name) : base(new Query<PrivacyFeaturesDisablePayload>(name))
        {
        }

        public PrivacyFeaturesDisablePayloadQueryBuilder(IQuery<PrivacyFeaturesDisablePayload> query) : base(query)
        {
        }

        public PrivacyFeaturesDisablePayloadQueryBuilder FeaturesDisabled()
        {
            base.InnerQuery.AddField("featuresDisabled");
            return this;
        }

        public PrivacyFeaturesDisablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyFeaturesDisableUserErrorQueryBuilder> build)
        {
            var query = new Query<PrivacyFeaturesDisableUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyFeaturesDisableUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PrivacyFeaturesDisableUserError>(query);
            return this;
        }
    }
}