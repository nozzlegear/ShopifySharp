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
    public sealed class SegmentCreateOperationQueryBuilder : FieldsQueryBuilderBase<SegmentCreatePayload, SegmentCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SegmentCreateArgumentsBuilder Arguments { get; }
        protected override SegmentCreateOperationQueryBuilder Self => this;

        public SegmentCreateOperationQueryBuilder() : this("segmentCreate")
        {
        }

        public SegmentCreateOperationQueryBuilder(string name) : base(new Query<SegmentCreatePayload>(name))
        {
            Arguments = new SegmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public SegmentCreateOperationQueryBuilder(IQuery<SegmentCreatePayload> query) : base(query)
        {
            Arguments = new SegmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public SegmentCreateOperationQueryBuilder Segment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}