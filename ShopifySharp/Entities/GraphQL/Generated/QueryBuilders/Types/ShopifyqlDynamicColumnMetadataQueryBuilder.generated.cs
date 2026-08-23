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
    public sealed class ShopifyqlDynamicColumnMetadataQueryBuilder : FieldsQueryBuilderBase<ShopifyqlDynamicColumnMetadata, ShopifyqlDynamicColumnMetadataQueryBuilder>
    {
        protected override ShopifyqlDynamicColumnMetadataQueryBuilder Self => this;

        public ShopifyqlDynamicColumnMetadataQueryBuilder() : this("shopifyqlDynamicColumnMetadata")
        {
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder(string name) : base(new Query<ShopifyqlDynamicColumnMetadata>(name))
        {
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder(IQuery<ShopifyqlDynamicColumnMetadata> query) : base(query)
        {
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder AggregatedBy()
        {
            base.InnerQuery.AddField("aggregatedBy");
            return this;
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder ComparisonReference()
        {
            base.InnerQuery.AddField("comparisonReference");
            return this;
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder OriginalColumnName()
        {
            base.InnerQuery.AddField("originalColumnName");
            return this;
        }

        public ShopifyqlDynamicColumnMetadataQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}