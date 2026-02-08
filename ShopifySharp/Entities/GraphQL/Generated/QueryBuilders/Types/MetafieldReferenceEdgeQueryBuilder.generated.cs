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
    public sealed class MetafieldReferenceEdgeQueryBuilder : FieldsQueryBuilderBase<MetafieldReferenceEdge, MetafieldReferenceEdgeQueryBuilder>
    {
        protected override MetafieldReferenceEdgeQueryBuilder Self => this;

        public MetafieldReferenceEdgeQueryBuilder() : this("metafieldReferenceEdge")
        {
        }

        public MetafieldReferenceEdgeQueryBuilder(string name) : base(new Query<MetafieldReferenceEdge>(name))
        {
        }

        public MetafieldReferenceEdgeQueryBuilder(IQuery<MetafieldReferenceEdge> query) : base(query)
        {
        }

        public MetafieldReferenceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MetafieldReferenceEdgeQueryBuilder Node(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("node");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}