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
    public sealed class MetafieldEdgeQueryBuilder : FieldsQueryBuilderBase<MetafieldEdge, MetafieldEdgeQueryBuilder>
    {
        protected override MetafieldEdgeQueryBuilder Self => this;

        public MetafieldEdgeQueryBuilder() : this("metafieldEdge")
        {
        }

        public MetafieldEdgeQueryBuilder(string name) : base(new Query<MetafieldEdge>(name))
        {
        }

        public MetafieldEdgeQueryBuilder(IQuery<MetafieldEdge> query) : base(query)
        {
        }

        public MetafieldEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetafieldEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }
    }
}