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
    public sealed class MetafieldCapabilityAnalyticsQueryableQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilityAnalyticsQueryable, MetafieldCapabilityAnalyticsQueryableQueryBuilder>
    {
        protected override MetafieldCapabilityAnalyticsQueryableQueryBuilder Self => this;

        public MetafieldCapabilityAnalyticsQueryableQueryBuilder() : this("metafieldCapabilityAnalyticsQueryable")
        {
        }

        public MetafieldCapabilityAnalyticsQueryableQueryBuilder(string name) : base(new Query<MetafieldCapabilityAnalyticsQueryable>(name))
        {
        }

        public MetafieldCapabilityAnalyticsQueryableQueryBuilder(IQuery<MetafieldCapabilityAnalyticsQueryable> query) : base(query)
        {
        }

        public MetafieldCapabilityAnalyticsQueryableQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetafieldCapabilityAnalyticsQueryableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}