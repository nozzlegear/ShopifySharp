#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CompanyContactRoleConnectionQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleConnection, CompanyContactRoleConnectionQueryBuilder>
    {
        protected override CompanyContactRoleConnectionQueryBuilder Self => this;

        public CompanyContactRoleConnectionQueryBuilder() : this("companyContactRoleConnection")
        {
        }

        public CompanyContactRoleConnectionQueryBuilder(string name) : base(new Query<CompanyContactRoleConnection>(name))
        {
        }

        public CompanyContactRoleConnectionQueryBuilder(IQuery<CompanyContactRoleConnection> query) : base(query)
        {
        }

        public CompanyContactRoleConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleEdge>(query);
            return this;
        }

        public CompanyContactRoleConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }

        public CompanyContactRoleConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}