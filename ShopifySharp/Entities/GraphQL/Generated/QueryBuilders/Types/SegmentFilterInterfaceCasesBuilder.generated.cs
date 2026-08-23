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
    public sealed class SegmentFilterInterfaceCasesBuilder : InterfaceCasesBuilderBase<ISegmentFilter, SegmentFilterInterfaceCasesBuilder>
    {
        protected override SegmentFilterInterfaceCasesBuilder Self => this;

        public SegmentFilterInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ISegmentFilter>(fieldName))
        {
        }

        public SegmentFilterInterfaceCasesBuilder(IQuery<ISegmentFilter> query) : base(query)
        {
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentAssociationFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentAssociationFilterQueryBuilder> build)
        {
            var query = new Query<SegmentAssociationFilter>("... on SegmentAssociationFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentAssociationFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentBooleanFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentBooleanFilterQueryBuilder> build)
        {
            var query = new Query<SegmentBooleanFilter>("... on SegmentBooleanFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentBooleanFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentDateFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentDateFilterQueryBuilder> build)
        {
            var query = new Query<SegmentDateFilter>("... on SegmentDateFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentDateFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentEnumFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEnumFilterQueryBuilder> build)
        {
            var query = new Query<SegmentEnumFilter>("... on SegmentEnumFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEnumFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentEventFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEventFilterQueryBuilder> build)
        {
            var query = new Query<SegmentEventFilter>("... on SegmentEventFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEventFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentFloatFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFloatFilterQueryBuilder> build)
        {
            var query = new Query<SegmentFloatFilter>("... on SegmentFloatFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFloatFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentIntegerFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentIntegerFilterQueryBuilder> build)
        {
            var query = new Query<SegmentIntegerFilter>("... on SegmentIntegerFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentIntegerFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SegmentFilterInterfaceCasesBuilder OnSegmentStringFilter(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentStringFilterQueryBuilder> build)
        {
            var query = new Query<SegmentStringFilter>("... on SegmentStringFilter");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentStringFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}