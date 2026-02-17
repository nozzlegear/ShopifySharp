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
    public sealed class SaleConnectionQueryBuilder : FieldsQueryBuilderBase<SaleConnection, SaleConnectionQueryBuilder>
    {
        protected override SaleConnectionQueryBuilder Self => this;

        public SaleConnectionQueryBuilder() : this("saleConnection")
        {
        }

        public SaleConnectionQueryBuilder(string name) : base(new Query<SaleConnection>(name))
        {
        }

        public SaleConnectionQueryBuilder(IQuery<SaleConnection> query) : base(query)
        {
        }

        public SaleConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder> build)
        {
            var query = new Query<SaleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleEdge>(query);
            return this;
        }

        public SaleConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleQueryBuilder> build)
        {
            var query = new Query<ISale>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISale>(query);
            return this;
        }

        public SaleConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}