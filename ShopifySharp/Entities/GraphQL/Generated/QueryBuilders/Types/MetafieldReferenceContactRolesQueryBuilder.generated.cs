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
    public sealed class MetafieldReferenceContactRolesQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleConnection, MetafieldReferenceContactRolesQueryBuilder>, IHasArguments<MetafieldReferenceContactRolesArgumentsBuilder>
    {
        public MetafieldReferenceContactRolesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceContactRolesQueryBuilder Self => this;

        public MetafieldReferenceContactRolesQueryBuilder(string name) : base(new Query<CompanyContactRoleConnection>(name))
        {
            Arguments = new MetafieldReferenceContactRolesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceContactRolesQueryBuilder(IQuery<CompanyContactRoleConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceContactRolesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceContactRolesQueryBuilder SetArguments(Action<MetafieldReferenceContactRolesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceContactRolesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleEdge>(query);
            return this;
        }

        public MetafieldReferenceContactRolesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }

        public MetafieldReferenceContactRolesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}