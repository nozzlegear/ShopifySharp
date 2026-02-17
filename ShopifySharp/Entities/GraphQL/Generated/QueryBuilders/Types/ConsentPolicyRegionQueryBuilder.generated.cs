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
    public sealed class ConsentPolicyRegionQueryBuilder : FieldsQueryBuilderBase<ConsentPolicyRegion, ConsentPolicyRegionQueryBuilder>
    {
        protected override ConsentPolicyRegionQueryBuilder Self => this;

        public ConsentPolicyRegionQueryBuilder() : this("consentPolicyRegion")
        {
        }

        public ConsentPolicyRegionQueryBuilder(string name) : base(new Query<ConsentPolicyRegion>(name))
        {
        }

        public ConsentPolicyRegionQueryBuilder(IQuery<ConsentPolicyRegion> query) : base(query)
        {
        }

        public ConsentPolicyRegionQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ConsentPolicyRegionQueryBuilder RegionCode()
        {
            base.InnerQuery.AddField("regionCode");
            return this;
        }
    }
}