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
    public sealed class CustomerStoreCreditAccountsQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountConnection, CustomerStoreCreditAccountsQueryBuilder>, IHasArguments<CustomerStoreCreditAccountsArgumentsBuilder>
    {
        public CustomerStoreCreditAccountsArgumentsBuilder Arguments { get; }
        protected override CustomerStoreCreditAccountsQueryBuilder Self => this;

        public CustomerStoreCreditAccountsQueryBuilder(string name) : base(new Query<StoreCreditAccountConnection>(name))
        {
            Arguments = new CustomerStoreCreditAccountsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerStoreCreditAccountsQueryBuilder(IQuery<StoreCreditAccountConnection> query) : base(query)
        {
            Arguments = new CustomerStoreCreditAccountsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerStoreCreditAccountsQueryBuilder SetArguments(Action<CustomerStoreCreditAccountsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerStoreCreditAccountsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountEdge>(query);
            return this;
        }

        public CustomerStoreCreditAccountsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public CustomerStoreCreditAccountsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}