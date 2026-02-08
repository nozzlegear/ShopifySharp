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
    public sealed class CompanyLocationRevokeRolesPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRevokeRolesPayload, CompanyLocationRevokeRolesPayloadQueryBuilder>
    {
        protected override CompanyLocationRevokeRolesPayloadQueryBuilder Self => this;

        public CompanyLocationRevokeRolesPayloadQueryBuilder() : this("companyLocationRevokeRolesPayload")
        {
        }

        public CompanyLocationRevokeRolesPayloadQueryBuilder(string name) : base(new Query<CompanyLocationRevokeRolesPayload>(name))
        {
        }

        public CompanyLocationRevokeRolesPayloadQueryBuilder(IQuery<CompanyLocationRevokeRolesPayload> query) : base(query)
        {
        }

        public CompanyLocationRevokeRolesPayloadQueryBuilder RevokedRoleAssignmentIds()
        {
            base.InnerQuery.AddField("revokedRoleAssignmentIds");
            return this;
        }

        public CompanyLocationRevokeRolesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}