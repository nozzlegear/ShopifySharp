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
    public sealed class SegmentMigrationQueryBuilder : FieldsQueryBuilderBase<SegmentMigration, SegmentMigrationQueryBuilder>
    {
        protected override SegmentMigrationQueryBuilder Self => this;

        public SegmentMigrationQueryBuilder() : this("segmentMigration")
        {
        }

        public SegmentMigrationQueryBuilder(string name) : base(new Query<SegmentMigration>(name))
        {
        }

        public SegmentMigrationQueryBuilder(IQuery<SegmentMigration> query) : base(query)
        {
        }

        public SegmentMigrationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SegmentMigrationQueryBuilder SavedSearchId()
        {
            base.InnerQuery.AddField("savedSearchId");
            return this;
        }

        public SegmentMigrationQueryBuilder SegmentId()
        {
            base.InnerQuery.AddField("segmentId");
            return this;
        }
    }
}