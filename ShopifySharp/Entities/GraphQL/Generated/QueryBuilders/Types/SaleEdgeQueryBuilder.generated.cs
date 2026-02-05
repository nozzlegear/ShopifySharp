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
    public sealed class SaleEdgeQueryBuilder : FieldsQueryBuilderBase<SaleEdge, SaleEdgeQueryBuilder>
    {
        protected override SaleEdgeQueryBuilder Self => this;

        public SaleEdgeQueryBuilder() : this("saleEdge")
        {
        }

        public SaleEdgeQueryBuilder(string name) : base(new Query<SaleEdge>(name))
        {
        }

        public SaleEdgeQueryBuilder(IQuery<SaleEdge> query) : base(query)
        {
        }

        public SaleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SaleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleQueryBuilder> build)
        {
            var query = new Query<ISale>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISale>(query);
            return this;
        }
    }
}