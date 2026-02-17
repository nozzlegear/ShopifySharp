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
    public sealed class MetafieldRelationEdgeQueryBuilder : FieldsQueryBuilderBase<MetafieldRelationEdge, MetafieldRelationEdgeQueryBuilder>
    {
        protected override MetafieldRelationEdgeQueryBuilder Self => this;

        public MetafieldRelationEdgeQueryBuilder() : this("metafieldRelationEdge")
        {
        }

        public MetafieldRelationEdgeQueryBuilder(string name) : base(new Query<MetafieldRelationEdge>(name))
        {
        }

        public MetafieldRelationEdgeQueryBuilder(IQuery<MetafieldRelationEdge> query) : base(query)
        {
        }

        public MetafieldRelationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetafieldRelationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationQueryBuilder> build)
        {
            var query = new Query<MetafieldRelation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelation>(query);
            return this;
        }
    }
}