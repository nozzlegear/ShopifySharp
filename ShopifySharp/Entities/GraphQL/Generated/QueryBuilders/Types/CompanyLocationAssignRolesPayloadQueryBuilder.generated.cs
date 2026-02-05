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
    public sealed class CompanyLocationAssignRolesPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignRolesPayload, CompanyLocationAssignRolesPayloadQueryBuilder>
    {
        protected override CompanyLocationAssignRolesPayloadQueryBuilder Self => this;

        public CompanyLocationAssignRolesPayloadQueryBuilder() : this("companyLocationAssignRolesPayload")
        {
        }

        public CompanyLocationAssignRolesPayloadQueryBuilder(string name) : base(new Query<CompanyLocationAssignRolesPayload>(name))
        {
        }

        public CompanyLocationAssignRolesPayloadQueryBuilder(IQuery<CompanyLocationAssignRolesPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignRolesPayloadQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public CompanyLocationAssignRolesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}