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
    public sealed class ShopifyPaymentsAccountBankAccountsQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBankAccountConnection, ShopifyPaymentsAccountBankAccountsQueryBuilder>, IHasArguments<ShopifyPaymentsAccountBankAccountsArgumentsBuilder>
    {
        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder Arguments { get; }
        protected override ShopifyPaymentsAccountBankAccountsQueryBuilder Self => this;

        public ShopifyPaymentsAccountBankAccountsQueryBuilder(string name) : base(new Query<ShopifyPaymentsBankAccountConnection>(name))
        {
            Arguments = new ShopifyPaymentsAccountBankAccountsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsAccountBankAccountsQueryBuilder(IQuery<ShopifyPaymentsBankAccountConnection> query) : base(query)
        {
            Arguments = new ShopifyPaymentsAccountBankAccountsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsAccountBankAccountsQueryBuilder SetArguments(Action<ShopifyPaymentsAccountBankAccountsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBankAccountEdge>(query);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccount>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBankAccount>(query);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}