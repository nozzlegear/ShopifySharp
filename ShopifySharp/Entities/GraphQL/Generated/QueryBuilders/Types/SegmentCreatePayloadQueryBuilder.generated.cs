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
    public sealed class SegmentCreatePayloadQueryBuilder : FieldsQueryBuilderBase<SegmentCreatePayload, SegmentCreatePayloadQueryBuilder>
    {
        protected override SegmentCreatePayloadQueryBuilder Self => this;

        public SegmentCreatePayloadQueryBuilder() : this("segmentCreatePayload")
        {
        }

        public SegmentCreatePayloadQueryBuilder(string name) : base(new Query<SegmentCreatePayload>(name))
        {
        }

        public SegmentCreatePayloadQueryBuilder(IQuery<SegmentCreatePayload> query) : base(query)
        {
        }

        public SegmentCreatePayloadQueryBuilder Segment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}