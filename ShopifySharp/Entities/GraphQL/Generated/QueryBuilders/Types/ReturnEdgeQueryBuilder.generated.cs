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
    public sealed class ReturnEdgeQueryBuilder : FieldsQueryBuilderBase<ReturnEdge, ReturnEdgeQueryBuilder>
    {
        protected override ReturnEdgeQueryBuilder Self => this;

        public ReturnEdgeQueryBuilder() : this("returnEdge")
        {
        }

        public ReturnEdgeQueryBuilder(string name) : base(new Query<ReturnEdge>(name))
        {
        }

        public ReturnEdgeQueryBuilder(IQuery<ReturnEdge> query) : base(query)
        {
        }

        public ReturnEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReturnEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }
    }
}