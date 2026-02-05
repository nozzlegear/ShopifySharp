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
    public sealed class SegmentDeletePayloadQueryBuilder : FieldsQueryBuilderBase<SegmentDeletePayload, SegmentDeletePayloadQueryBuilder>
    {
        protected override SegmentDeletePayloadQueryBuilder Self => this;

        public SegmentDeletePayloadQueryBuilder() : this("segmentDeletePayload")
        {
        }

        public SegmentDeletePayloadQueryBuilder(string name) : base(new Query<SegmentDeletePayload>(name))
        {
        }

        public SegmentDeletePayloadQueryBuilder(IQuery<SegmentDeletePayload> query) : base(query)
        {
        }

        public SegmentDeletePayloadQueryBuilder DeletedSegmentId()
        {
            base.InnerQuery.AddField("deletedSegmentId");
            return this;
        }

        public SegmentDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}