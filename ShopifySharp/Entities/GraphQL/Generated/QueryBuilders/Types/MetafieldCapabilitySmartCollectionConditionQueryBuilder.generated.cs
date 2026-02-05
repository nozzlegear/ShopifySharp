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
    public sealed class MetafieldCapabilitySmartCollectionConditionQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilitySmartCollectionCondition, MetafieldCapabilitySmartCollectionConditionQueryBuilder>
    {
        protected override MetafieldCapabilitySmartCollectionConditionQueryBuilder Self => this;

        public MetafieldCapabilitySmartCollectionConditionQueryBuilder() : this("metafieldCapabilitySmartCollectionCondition")
        {
        }

        public MetafieldCapabilitySmartCollectionConditionQueryBuilder(string name) : base(new Query<MetafieldCapabilitySmartCollectionCondition>(name))
        {
        }

        public MetafieldCapabilitySmartCollectionConditionQueryBuilder(IQuery<MetafieldCapabilitySmartCollectionCondition> query) : base(query)
        {
        }

        public MetafieldCapabilitySmartCollectionConditionQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetafieldCapabilitySmartCollectionConditionQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}