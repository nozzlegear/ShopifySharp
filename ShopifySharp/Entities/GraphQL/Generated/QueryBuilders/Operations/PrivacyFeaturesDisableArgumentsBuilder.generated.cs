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
    public sealed class PrivacyFeaturesDisableArgumentsBuilder : ArgumentsBuilderBase<PrivacyFeaturesDisablePayload, PrivacyFeaturesDisableArgumentsBuilder>
    {
        protected override PrivacyFeaturesDisableArgumentsBuilder Self => this;

        public PrivacyFeaturesDisableArgumentsBuilder(IQuery<PrivacyFeaturesDisablePayload> query) : base(query)
        {
        }

        public PrivacyFeaturesDisableArgumentsBuilder FeaturesToDisable(ICollection<PrivacyFeaturesEnum>? featuresToDisable)
        {
            base.InnerQuery.AddArgument("featuresToDisable", featuresToDisable);
            return this;
        }
    }
}