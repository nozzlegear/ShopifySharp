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
    public sealed class MetafieldReferencerReturnsQueryBuilder : FieldsQueryBuilderBase<ReturnConnection, MetafieldReferencerReturnsQueryBuilder>, IHasArguments<MetafieldReferencerReturnsArgumentsBuilder>
    {
        public MetafieldReferencerReturnsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerReturnsQueryBuilder Self => this;

        public MetafieldReferencerReturnsQueryBuilder(string name) : base(new Query<ReturnConnection>(name))
        {
            Arguments = new MetafieldReferencerReturnsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerReturnsQueryBuilder(IQuery<ReturnConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerReturnsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerReturnsQueryBuilder SetArguments(Action<MetafieldReferencerReturnsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerReturnsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnEdge>(query);
            return this;
        }

        public MetafieldReferencerReturnsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public MetafieldReferencerReturnsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}