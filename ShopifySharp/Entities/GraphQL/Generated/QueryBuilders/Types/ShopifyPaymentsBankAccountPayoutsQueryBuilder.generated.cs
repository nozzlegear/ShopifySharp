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
    public sealed class ShopifyPaymentsBankAccountPayoutsQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutConnection, ShopifyPaymentsBankAccountPayoutsQueryBuilder>, IHasArguments<ShopifyPaymentsBankAccountPayoutsArgumentsBuilder>
    {
        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Arguments { get; }
        protected override ShopifyPaymentsBankAccountPayoutsQueryBuilder Self => this;

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutConnection>(name))
        {
            Arguments = new ShopifyPaymentsBankAccountPayoutsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder(IQuery<ShopifyPaymentsPayoutConnection> query) : base(query)
        {
            Arguments = new ShopifyPaymentsBankAccountPayoutsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder SetArguments(Action<ShopifyPaymentsBankAccountPayoutsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutEdge>(query);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayout>(query);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}