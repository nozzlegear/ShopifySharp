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
    public sealed class ConsentPolicyRegionsOperationQueryBuilder : FieldsQueryBuilderBase<ConsentPolicyRegion, ConsentPolicyRegionsOperationQueryBuilder>, IGraphOperationQueryBuilder<ConsentPolicyRegion>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override ConsentPolicyRegionsOperationQueryBuilder Self => this;

        public ConsentPolicyRegionsOperationQueryBuilder() : this("consentPolicyRegions")
        {
        }

        public ConsentPolicyRegionsOperationQueryBuilder(string name) : base(new Query<ConsentPolicyRegion>(name))
        {
        }

        public ConsentPolicyRegionsOperationQueryBuilder(IQuery<ConsentPolicyRegion> query) : base(query)
        {
        }

        public ConsentPolicyRegionsOperationQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ConsentPolicyRegionsOperationQueryBuilder RegionCode()
        {
            base.InnerQuery.AddField("regionCode");
            return this;
        }
    }
}