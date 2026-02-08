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
    public sealed class MetafieldDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionEdge, MetafieldDefinitionEdgeQueryBuilder>
    {
        protected override MetafieldDefinitionEdgeQueryBuilder Self => this;

        public MetafieldDefinitionEdgeQueryBuilder() : this("metafieldDefinitionEdge")
        {
        }

        public MetafieldDefinitionEdgeQueryBuilder(string name) : base(new Query<MetafieldDefinitionEdge>(name))
        {
        }

        public MetafieldDefinitionEdgeQueryBuilder(IQuery<MetafieldDefinitionEdge> query) : base(query)
        {
        }

        public MetafieldDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetafieldDefinitionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }
    }
}