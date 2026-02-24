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
    public sealed class MetafieldReferenceContactsQueryBuilder : FieldsQueryBuilderBase<CompanyContactConnection, MetafieldReferenceContactsQueryBuilder>, IHasArguments<MetafieldReferenceContactsArgumentsBuilder>
    {
        public MetafieldReferenceContactsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceContactsQueryBuilder Self => this;

        public MetafieldReferenceContactsQueryBuilder(string name) : base(new Query<CompanyContactConnection>(name))
        {
            Arguments = new MetafieldReferenceContactsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceContactsQueryBuilder(IQuery<CompanyContactConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceContactsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceContactsQueryBuilder SetArguments(Action<MetafieldReferenceContactsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceContactsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactEdge>(query);
            return this;
        }

        public MetafieldReferenceContactsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public MetafieldReferenceContactsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}