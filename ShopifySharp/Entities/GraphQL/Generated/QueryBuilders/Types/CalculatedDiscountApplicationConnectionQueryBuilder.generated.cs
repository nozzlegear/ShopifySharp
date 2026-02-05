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
    public sealed class CalculatedDiscountApplicationConnectionQueryBuilder : FieldsQueryBuilderBase<CalculatedDiscountApplicationConnection, CalculatedDiscountApplicationConnectionQueryBuilder>
    {
        protected override CalculatedDiscountApplicationConnectionQueryBuilder Self => this;

        public CalculatedDiscountApplicationConnectionQueryBuilder() : this("calculatedDiscountApplicationConnection")
        {
        }

        public CalculatedDiscountApplicationConnectionQueryBuilder(string name) : base(new Query<CalculatedDiscountApplicationConnection>(name))
        {
        }

        public CalculatedDiscountApplicationConnectionQueryBuilder(IQuery<CalculatedDiscountApplicationConnection> query) : base(query)
        {
        }

        public CalculatedDiscountApplicationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDiscountApplicationEdge>(query);
            return this;
        }

        public CalculatedDiscountApplicationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ICalculatedDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICalculatedDiscountApplication>(query);
            return this;
        }

        public CalculatedDiscountApplicationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}