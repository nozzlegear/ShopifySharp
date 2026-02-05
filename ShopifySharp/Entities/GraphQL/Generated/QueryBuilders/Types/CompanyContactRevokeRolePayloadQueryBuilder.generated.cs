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
    public sealed class CompanyContactRevokeRolePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyContactRevokeRolePayload, CompanyContactRevokeRolePayloadQueryBuilder>
    {
        protected override CompanyContactRevokeRolePayloadQueryBuilder Self => this;

        public CompanyContactRevokeRolePayloadQueryBuilder() : this("companyContactRevokeRolePayload")
        {
        }

        public CompanyContactRevokeRolePayloadQueryBuilder(string name) : base(new Query<CompanyContactRevokeRolePayload>(name))
        {
        }

        public CompanyContactRevokeRolePayloadQueryBuilder(IQuery<CompanyContactRevokeRolePayload> query) : base(query)
        {
        }

        public CompanyContactRevokeRolePayloadQueryBuilder RevokedCompanyContactRoleAssignmentId()
        {
            base.InnerQuery.AddField("revokedCompanyContactRoleAssignmentId");
            return this;
        }

        public CompanyContactRevokeRolePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}