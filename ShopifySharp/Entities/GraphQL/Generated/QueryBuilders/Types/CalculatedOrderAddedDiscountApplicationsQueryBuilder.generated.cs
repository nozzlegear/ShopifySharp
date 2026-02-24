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
    public sealed class CalculatedOrderAddedDiscountApplicationsQueryBuilder : FieldsQueryBuilderBase<CalculatedDiscountApplicationConnection, CalculatedOrderAddedDiscountApplicationsQueryBuilder>, IHasArguments<CalculatedOrderAddedDiscountApplicationsArgumentsBuilder>
    {
        public CalculatedOrderAddedDiscountApplicationsArgumentsBuilder Arguments { get; }
        protected override CalculatedOrderAddedDiscountApplicationsQueryBuilder Self => this;

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder(string name) : base(new Query<CalculatedDiscountApplicationConnection>(name))
        {
            Arguments = new CalculatedOrderAddedDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder(IQuery<CalculatedDiscountApplicationConnection> query) : base(query)
        {
            Arguments = new CalculatedOrderAddedDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder SetArguments(Action<CalculatedOrderAddedDiscountApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDiscountApplicationEdge>(query);
            return this;
        }

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ICalculatedDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICalculatedDiscountApplication>(query);
            return this;
        }

        public CalculatedOrderAddedDiscountApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}