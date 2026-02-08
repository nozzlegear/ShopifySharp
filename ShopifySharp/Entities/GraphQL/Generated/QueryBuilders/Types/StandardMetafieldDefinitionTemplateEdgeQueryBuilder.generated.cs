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
    public sealed class StandardMetafieldDefinitionTemplateEdgeQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionTemplateEdge, StandardMetafieldDefinitionTemplateEdgeQueryBuilder>
    {
        protected override StandardMetafieldDefinitionTemplateEdgeQueryBuilder Self => this;

        public StandardMetafieldDefinitionTemplateEdgeQueryBuilder() : this("standardMetafieldDefinitionTemplateEdge")
        {
        }

        public StandardMetafieldDefinitionTemplateEdgeQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionTemplateEdge>(name))
        {
        }

        public StandardMetafieldDefinitionTemplateEdgeQueryBuilder(IQuery<StandardMetafieldDefinitionTemplateEdge> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionTemplateEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StandardMetafieldDefinitionTemplateEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }
    }
}