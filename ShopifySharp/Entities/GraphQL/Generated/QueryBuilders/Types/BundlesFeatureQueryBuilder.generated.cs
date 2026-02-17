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
    public sealed class BundlesFeatureQueryBuilder : FieldsQueryBuilderBase<BundlesFeature, BundlesFeatureQueryBuilder>
    {
        protected override BundlesFeatureQueryBuilder Self => this;

        public BundlesFeatureQueryBuilder() : this("bundlesFeature")
        {
        }

        public BundlesFeatureQueryBuilder(string name) : base(new Query<BundlesFeature>(name))
        {
        }

        public BundlesFeatureQueryBuilder(IQuery<BundlesFeature> query) : base(query)
        {
        }

        public BundlesFeatureQueryBuilder EligibleForBundles()
        {
            base.InnerQuery.AddField("eligibleForBundles");
            return this;
        }

        public BundlesFeatureQueryBuilder IneligibilityReason()
        {
            base.InnerQuery.AddField("ineligibilityReason");
            return this;
        }

        public BundlesFeatureQueryBuilder SellsBundles()
        {
            base.InnerQuery.AddField("sellsBundles");
            return this;
        }
    }
}