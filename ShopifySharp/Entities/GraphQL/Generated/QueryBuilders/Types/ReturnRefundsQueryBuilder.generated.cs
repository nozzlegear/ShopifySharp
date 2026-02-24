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
    public sealed class ReturnRefundsQueryBuilder : FieldsQueryBuilderBase<RefundConnection, ReturnRefundsQueryBuilder>, IHasArguments<ReturnRefundsArgumentsBuilder>
    {
        public ReturnRefundsArgumentsBuilder Arguments { get; }
        protected override ReturnRefundsQueryBuilder Self => this;

        public ReturnRefundsQueryBuilder(string name) : base(new Query<RefundConnection>(name))
        {
            Arguments = new ReturnRefundsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRefundsQueryBuilder(IQuery<RefundConnection> query) : base(query)
        {
            Arguments = new ReturnRefundsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRefundsQueryBuilder SetArguments(Action<ReturnRefundsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnRefundsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundEdgeQueryBuilder> build)
        {
            var query = new Query<RefundEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundEdge>(query);
            return this;
        }

        public ReturnRefundsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public ReturnRefundsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}