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
    public sealed class MetaobjectsOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectConnection, MetaobjectsOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetaobjectsArgumentsBuilder Arguments { get; }
        protected override MetaobjectsOperationQueryBuilder Self => this;

        public MetaobjectsOperationQueryBuilder() : this("metaobjects")
        {
        }

        public MetaobjectsOperationQueryBuilder(string name) : base(new Query<MetaobjectConnection>(name))
        {
            Arguments = new MetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectsOperationQueryBuilder(IQuery<MetaobjectConnection> query) : base(query)
        {
            Arguments = new MetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectEdge>(query);
            return this;
        }

        public MetaobjectsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}