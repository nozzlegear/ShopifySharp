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
    public sealed class AbandonmentProductsViewedQueryBuilder : FieldsQueryBuilderBase<CustomerVisitProductInfoConnection, AbandonmentProductsViewedQueryBuilder>, IHasArguments<AbandonmentProductsViewedArgumentsBuilder>
    {
        public AbandonmentProductsViewedArgumentsBuilder Arguments { get; }
        protected override AbandonmentProductsViewedQueryBuilder Self => this;

        public AbandonmentProductsViewedQueryBuilder(string name) : base(new Query<CustomerVisitProductInfoConnection>(name))
        {
            Arguments = new AbandonmentProductsViewedArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentProductsViewedQueryBuilder(IQuery<CustomerVisitProductInfoConnection> query) : base(query)
        {
            Arguments = new AbandonmentProductsViewedArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentProductsViewedQueryBuilder SetArguments(Action<AbandonmentProductsViewedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AbandonmentProductsViewedQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoEdge>(query);
            return this;
        }

        public AbandonmentProductsViewedQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfo>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfo>(query);
            return this;
        }

        public AbandonmentProductsViewedQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}