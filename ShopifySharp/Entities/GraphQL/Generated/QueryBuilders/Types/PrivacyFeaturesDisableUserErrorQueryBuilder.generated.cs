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
    public sealed class PrivacyFeaturesDisableUserErrorQueryBuilder : FieldsQueryBuilderBase<PrivacyFeaturesDisableUserError, PrivacyFeaturesDisableUserErrorQueryBuilder>
    {
        protected override PrivacyFeaturesDisableUserErrorQueryBuilder Self => this;

        public PrivacyFeaturesDisableUserErrorQueryBuilder() : this("privacyFeaturesDisableUserError")
        {
        }

        public PrivacyFeaturesDisableUserErrorQueryBuilder(string name) : base(new Query<PrivacyFeaturesDisableUserError>(name))
        {
        }

        public PrivacyFeaturesDisableUserErrorQueryBuilder(IQuery<PrivacyFeaturesDisableUserError> query) : base(query)
        {
        }

        public PrivacyFeaturesDisableUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PrivacyFeaturesDisableUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PrivacyFeaturesDisableUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}