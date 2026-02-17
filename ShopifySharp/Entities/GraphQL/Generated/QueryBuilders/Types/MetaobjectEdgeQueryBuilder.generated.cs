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
    public sealed class MetaobjectEdgeQueryBuilder : FieldsQueryBuilderBase<MetaobjectEdge, MetaobjectEdgeQueryBuilder>
    {
        protected override MetaobjectEdgeQueryBuilder Self => this;

        public MetaobjectEdgeQueryBuilder() : this("metaobjectEdge")
        {
        }

        public MetaobjectEdgeQueryBuilder(string name) : base(new Query<MetaobjectEdge>(name))
        {
        }

        public MetaobjectEdgeQueryBuilder(IQuery<MetaobjectEdge> query) : base(query)
        {
        }

        public MetaobjectEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetaobjectEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }
    }
}