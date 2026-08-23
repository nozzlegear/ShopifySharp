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
    public sealed class CatalogEdgeQueryBuilder : FieldsQueryBuilderBase<CatalogEdge, CatalogEdgeQueryBuilder>
    {
        protected override CatalogEdgeQueryBuilder Self => this;

        public CatalogEdgeQueryBuilder() : this("catalogEdge")
        {
        }

        public CatalogEdgeQueryBuilder(string name) : base(new Query<CatalogEdge>(name))
        {
        }

        public CatalogEdgeQueryBuilder(IQuery<CatalogEdge> query) : base(query)
        {
        }

        public CatalogEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CatalogEdgeQueryBuilder Node(Action<CatalogInterfaceCasesBuilder> build)
        {
            var query = new Query<ICatalog>("node");
            var unionBuilder = new CatalogInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}