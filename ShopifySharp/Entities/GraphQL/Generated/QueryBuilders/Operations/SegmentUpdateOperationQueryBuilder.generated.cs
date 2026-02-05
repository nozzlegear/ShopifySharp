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
    public sealed class SegmentUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SegmentUpdatePayload, SegmentUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SegmentUpdateArgumentsBuilder Arguments { get; }
        protected override SegmentUpdateOperationQueryBuilder Self => this;

        public SegmentUpdateOperationQueryBuilder() : this("segmentUpdate")
        {
        }

        public SegmentUpdateOperationQueryBuilder(string name) : base(new Query<SegmentUpdatePayload>(name))
        {
            Arguments = new SegmentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SegmentUpdateOperationQueryBuilder(IQuery<SegmentUpdatePayload> query) : base(query)
        {
            Arguments = new SegmentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SegmentUpdateOperationQueryBuilder Segment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}