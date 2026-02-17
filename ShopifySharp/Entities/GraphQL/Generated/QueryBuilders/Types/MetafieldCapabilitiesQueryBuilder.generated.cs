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
    public sealed class MetafieldCapabilitiesQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilities, MetafieldCapabilitiesQueryBuilder>
    {
        protected override MetafieldCapabilitiesQueryBuilder Self => this;

        public MetafieldCapabilitiesQueryBuilder() : this("metafieldCapabilities")
        {
        }

        public MetafieldCapabilitiesQueryBuilder(string name) : base(new Query<MetafieldCapabilities>(name))
        {
        }

        public MetafieldCapabilitiesQueryBuilder(IQuery<MetafieldCapabilities> query) : base(query)
        {
        }

        public MetafieldCapabilitiesQueryBuilder AdminFilterable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilityAdminFilterableQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilityAdminFilterable>("adminFilterable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilityAdminFilterableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilityAdminFilterable>(query);
            return this;
        }

        public MetafieldCapabilitiesQueryBuilder SmartCollectionCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitySmartCollectionConditionQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilitySmartCollectionCondition>("smartCollectionCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitySmartCollectionConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilitySmartCollectionCondition>(query);
            return this;
        }

        public MetafieldCapabilitiesQueryBuilder UniqueValues(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilityUniqueValuesQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilityUniqueValues>("uniqueValues");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilityUniqueValuesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilityUniqueValues>(query);
            return this;
        }
    }
}