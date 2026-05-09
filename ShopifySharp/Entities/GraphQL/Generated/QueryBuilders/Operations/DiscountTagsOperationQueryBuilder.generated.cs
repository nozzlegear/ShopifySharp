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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountTagsOperationQueryBuilder : FieldsQueryBuilderBase<StringConnection, DiscountTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<StringConnection>, IHasArguments<DiscountTagsArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DiscountTagsArgumentsBuilder Arguments { get; }
        protected override DiscountTagsOperationQueryBuilder Self => this;

        public DiscountTagsOperationQueryBuilder() : this("discountTags")
        {
        }

        public DiscountTagsOperationQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new DiscountTagsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountTagsOperationQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new DiscountTagsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountTagsOperationQueryBuilder SetArguments(Action<DiscountTagsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountTagsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public DiscountTagsOperationQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public DiscountTagsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}