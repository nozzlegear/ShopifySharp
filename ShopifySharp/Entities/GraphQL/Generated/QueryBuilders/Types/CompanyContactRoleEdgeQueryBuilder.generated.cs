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
    public sealed class CompanyContactRoleEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleEdge, CompanyContactRoleEdgeQueryBuilder>
    {
        protected override CompanyContactRoleEdgeQueryBuilder Self => this;

        public CompanyContactRoleEdgeQueryBuilder() : this("companyContactRoleEdge")
        {
        }

        public CompanyContactRoleEdgeQueryBuilder(string name) : base(new Query<CompanyContactRoleEdge>(name))
        {
        }

        public CompanyContactRoleEdgeQueryBuilder(IQuery<CompanyContactRoleEdge> query) : base(query)
        {
        }

        public CompanyContactRoleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyContactRoleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }
    }
}