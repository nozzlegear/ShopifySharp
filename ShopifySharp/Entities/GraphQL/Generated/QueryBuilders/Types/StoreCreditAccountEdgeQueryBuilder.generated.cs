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
    public sealed class StoreCreditAccountEdgeQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountEdge, StoreCreditAccountEdgeQueryBuilder>
    {
        protected override StoreCreditAccountEdgeQueryBuilder Self => this;

        public StoreCreditAccountEdgeQueryBuilder() : this("storeCreditAccountEdge")
        {
        }

        public StoreCreditAccountEdgeQueryBuilder(string name) : base(new Query<StoreCreditAccountEdge>(name))
        {
        }

        public StoreCreditAccountEdgeQueryBuilder(IQuery<StoreCreditAccountEdge> query) : base(query)
        {
        }

        public StoreCreditAccountEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StoreCreditAccountEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }
    }
}