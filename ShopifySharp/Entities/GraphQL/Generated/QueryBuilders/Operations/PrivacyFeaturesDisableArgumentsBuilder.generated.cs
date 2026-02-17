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