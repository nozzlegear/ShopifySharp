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
    public sealed class MetafieldDefinitionConstraintValueEdgeQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConstraintValueEdge, MetafieldDefinitionConstraintValueEdgeQueryBuilder>
    {
        protected override MetafieldDefinitionConstraintValueEdgeQueryBuilder Self => this;

        public MetafieldDefinitionConstraintValueEdgeQueryBuilder() : this("metafieldDefinitionConstraintValueEdge")
        {
        }

        public MetafieldDefinitionConstraintValueEdgeQueryBuilder(string name) : base(new Query<MetafieldDefinitionConstraintValueEdge>(name))
        {
        }

        public MetafieldDefinitionConstraintValueEdgeQueryBuilder(IQuery<MetafieldDefinitionConstraintValueEdge> query) : base(query)
        {
        }

        public MetafieldDefinitionConstraintValueEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetafieldDefinitionConstraintValueEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValue>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValue>(query);
            return this;
        }
    }
}