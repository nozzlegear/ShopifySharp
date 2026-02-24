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
    public sealed class AbandonedCheckoutLineItemsQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItemConnection, AbandonedCheckoutLineItemsQueryBuilder>, IHasArguments<AbandonedCheckoutLineItemsArgumentsBuilder>
    {
        public AbandonedCheckoutLineItemsArgumentsBuilder Arguments { get; }
        protected override AbandonedCheckoutLineItemsQueryBuilder Self => this;

        public AbandonedCheckoutLineItemsQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItemConnection>(name))
        {
            Arguments = new AbandonedCheckoutLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutLineItemsQueryBuilder(IQuery<AbandonedCheckoutLineItemConnection> query) : base(query)
        {
            Arguments = new AbandonedCheckoutLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutLineItemsQueryBuilder SetArguments(Action<AbandonedCheckoutLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AbandonedCheckoutLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItemEdge>(query);
            return this;
        }

        public AbandonedCheckoutLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItem>(query);
            return this;
        }

        public AbandonedCheckoutLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}