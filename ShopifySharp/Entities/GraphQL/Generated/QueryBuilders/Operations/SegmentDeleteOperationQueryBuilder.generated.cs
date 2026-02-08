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
    public sealed class SegmentDeleteOperationQueryBuilder : FieldsQueryBuilderBase<SegmentDeletePayload, SegmentDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SegmentDeleteArgumentsBuilder Arguments { get; }
        protected override SegmentDeleteOperationQueryBuilder Self => this;

        public SegmentDeleteOperationQueryBuilder() : this("segmentDelete")
        {
        }

        public SegmentDeleteOperationQueryBuilder(string name) : base(new Query<SegmentDeletePayload>(name))
        {
            Arguments = new SegmentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SegmentDeleteOperationQueryBuilder(IQuery<SegmentDeletePayload> query) : base(query)
        {
            Arguments = new SegmentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SegmentDeleteOperationQueryBuilder DeletedSegmentId()
        {
            base.InnerQuery.AddField("deletedSegmentId");
            return this;
        }

        public SegmentDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}