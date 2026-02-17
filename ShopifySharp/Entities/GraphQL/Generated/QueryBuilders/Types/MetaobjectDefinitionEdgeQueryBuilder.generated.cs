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
    public sealed class MetaobjectDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionEdge, MetaobjectDefinitionEdgeQueryBuilder>
    {
        protected override MetaobjectDefinitionEdgeQueryBuilder Self => this;

        public MetaobjectDefinitionEdgeQueryBuilder() : this("metaobjectDefinitionEdge")
        {
        }

        public MetaobjectDefinitionEdgeQueryBuilder(string name) : base(new Query<MetaobjectDefinitionEdge>(name))
        {
        }

        public MetaobjectDefinitionEdgeQueryBuilder(IQuery<MetaobjectDefinitionEdge> query) : base(query)
        {
        }

        public MetaobjectDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetaobjectDefinitionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }
    }
}