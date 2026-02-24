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
    public sealed class AbandonedCheckoutConnectionQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutConnection, AbandonedCheckoutConnectionQueryBuilder>, IHasArguments<AbandonedCheckoutConnectionArgumentsBuilder>
    {
        public AbandonedCheckoutConnectionArgumentsBuilder Arguments { get; }
        protected override AbandonedCheckoutConnectionQueryBuilder Self => this;

        public AbandonedCheckoutConnectionQueryBuilder() : this("abandonedCheckoutConnection")
        {
        }

        public AbandonedCheckoutConnectionQueryBuilder(string name) : base(new Query<AbandonedCheckoutConnection>(name))
        {
            Arguments = new AbandonedCheckoutConnectionArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutConnectionQueryBuilder(IQuery<AbandonedCheckoutConnection> query) : base(query)
        {
            Arguments = new AbandonedCheckoutConnectionArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutConnectionQueryBuilder SetArguments(Action<AbandonedCheckoutConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AbandonedCheckoutConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutEdgeQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutEdge>(query);
            return this;
        }

        public AbandonedCheckoutConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public AbandonedCheckoutConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}