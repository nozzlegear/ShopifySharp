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
    public sealed class MetafieldReferenceLocationsQueryBuilder : FieldsQueryBuilderBase<CompanyLocationConnection, MetafieldReferenceLocationsQueryBuilder>, IHasArguments<MetafieldReferenceLocationsArgumentsBuilder>
    {
        public MetafieldReferenceLocationsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceLocationsQueryBuilder Self => this;

        public MetafieldReferenceLocationsQueryBuilder(string name) : base(new Query<CompanyLocationConnection>(name))
        {
            Arguments = new MetafieldReferenceLocationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceLocationsQueryBuilder(IQuery<CompanyLocationConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceLocationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceLocationsQueryBuilder SetArguments(Action<MetafieldReferenceLocationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceLocationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationEdge>(query);
            return this;
        }

        public MetafieldReferenceLocationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public MetafieldReferenceLocationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}