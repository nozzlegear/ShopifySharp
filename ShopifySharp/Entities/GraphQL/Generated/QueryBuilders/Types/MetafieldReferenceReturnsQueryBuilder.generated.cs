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
    public sealed class MetafieldReferenceReturnsQueryBuilder : FieldsQueryBuilderBase<ReturnConnection, MetafieldReferenceReturnsQueryBuilder>, IHasArguments<MetafieldReferenceReturnsArgumentsBuilder>
    {
        public MetafieldReferenceReturnsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceReturnsQueryBuilder Self => this;

        public MetafieldReferenceReturnsQueryBuilder(string name) : base(new Query<ReturnConnection>(name))
        {
            Arguments = new MetafieldReferenceReturnsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceReturnsQueryBuilder(IQuery<ReturnConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceReturnsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceReturnsQueryBuilder SetArguments(Action<MetafieldReferenceReturnsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceReturnsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnEdge>(query);
            return this;
        }

        public MetafieldReferenceReturnsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public MetafieldReferenceReturnsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}