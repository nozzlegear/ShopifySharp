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
    public sealed class MetaobjectConnectionQueryBuilder : FieldsQueryBuilderBase<MetaobjectConnection, MetaobjectConnectionQueryBuilder>
    {
        protected override MetaobjectConnectionQueryBuilder Self => this;

        public MetaobjectConnectionQueryBuilder() : this("metaobjectConnection")
        {
        }

        public MetaobjectConnectionQueryBuilder(string name) : base(new Query<MetaobjectConnection>(name))
        {
        }

        public MetaobjectConnectionQueryBuilder(IQuery<MetaobjectConnection> query) : base(query)
        {
        }

        public MetaobjectConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectEdge>(query);
            return this;
        }

        public MetaobjectConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}