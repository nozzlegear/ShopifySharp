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
    public sealed class CalculatedDiscountApplicationEdgeQueryBuilder : FieldsQueryBuilderBase<CalculatedDiscountApplicationEdge, CalculatedDiscountApplicationEdgeQueryBuilder>
    {
        protected override CalculatedDiscountApplicationEdgeQueryBuilder Self => this;

        public CalculatedDiscountApplicationEdgeQueryBuilder() : this("calculatedDiscountApplicationEdge")
        {
        }

        public CalculatedDiscountApplicationEdgeQueryBuilder(string name) : base(new Query<CalculatedDiscountApplicationEdge>(name))
        {
        }

        public CalculatedDiscountApplicationEdgeQueryBuilder(IQuery<CalculatedDiscountApplicationEdge> query) : base(query)
        {
        }

        public CalculatedDiscountApplicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CalculatedDiscountApplicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ICalculatedDiscountApplication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICalculatedDiscountApplication>(query);
            return this;
        }
    }
}