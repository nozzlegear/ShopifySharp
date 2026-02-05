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
    public sealed class DiscountCustomerSegmentsQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerSegments, DiscountCustomerSegmentsQueryBuilder>
    {
        protected override DiscountCustomerSegmentsQueryBuilder Self => this;

        public DiscountCustomerSegmentsQueryBuilder() : this("discountCustomerSegments")
        {
        }

        public DiscountCustomerSegmentsQueryBuilder(string name) : base(new Query<DiscountCustomerSegments>(name))
        {
        }

        public DiscountCustomerSegmentsQueryBuilder(IQuery<DiscountCustomerSegments> query) : base(query)
        {
        }

        public DiscountCustomerSegmentsQueryBuilder Segments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }
    }
}