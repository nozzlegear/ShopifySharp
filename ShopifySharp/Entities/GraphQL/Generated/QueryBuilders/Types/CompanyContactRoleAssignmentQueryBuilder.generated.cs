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
    public sealed class CompanyContactRoleAssignmentQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleAssignment, CompanyContactRoleAssignmentQueryBuilder>
    {
        protected override CompanyContactRoleAssignmentQueryBuilder Self => this;

        public CompanyContactRoleAssignmentQueryBuilder() : this("companyContactRoleAssignment")
        {
        }

        public CompanyContactRoleAssignmentQueryBuilder(string name) : base(new Query<CompanyContactRoleAssignment>(name))
        {
        }

        public CompanyContactRoleAssignmentQueryBuilder(IQuery<CompanyContactRoleAssignment> query) : base(query)
        {
        }

        public CompanyContactRoleAssignmentQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder Role(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("role");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }

        public CompanyContactRoleAssignmentQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}