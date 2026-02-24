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
    public sealed class MetafieldReferenceStoreCreditAccountsQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountConnection, MetafieldReferenceStoreCreditAccountsQueryBuilder>, IHasArguments<MetafieldReferenceStoreCreditAccountsArgumentsBuilder>
    {
        public MetafieldReferenceStoreCreditAccountsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceStoreCreditAccountsQueryBuilder Self => this;

        public MetafieldReferenceStoreCreditAccountsQueryBuilder(string name) : base(new Query<StoreCreditAccountConnection>(name))
        {
            Arguments = new MetafieldReferenceStoreCreditAccountsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceStoreCreditAccountsQueryBuilder(IQuery<StoreCreditAccountConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceStoreCreditAccountsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceStoreCreditAccountsQueryBuilder SetArguments(Action<MetafieldReferenceStoreCreditAccountsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceStoreCreditAccountsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountEdge>(query);
            return this;
        }

        public MetafieldReferenceStoreCreditAccountsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public MetafieldReferenceStoreCreditAccountsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}