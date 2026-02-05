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
    public sealed class CompanyLocationRemoveStaffMembersPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRemoveStaffMembersPayload, CompanyLocationRemoveStaffMembersPayloadQueryBuilder>
    {
        protected override CompanyLocationRemoveStaffMembersPayloadQueryBuilder Self => this;

        public CompanyLocationRemoveStaffMembersPayloadQueryBuilder() : this("companyLocationRemoveStaffMembersPayload")
        {
        }

        public CompanyLocationRemoveStaffMembersPayloadQueryBuilder(string name) : base(new Query<CompanyLocationRemoveStaffMembersPayload>(name))
        {
        }

        public CompanyLocationRemoveStaffMembersPayloadQueryBuilder(IQuery<CompanyLocationRemoveStaffMembersPayload> query) : base(query)
        {
        }

        public CompanyLocationRemoveStaffMembersPayloadQueryBuilder DeletedCompanyLocationStaffMemberAssignmentIds()
        {
            base.InnerQuery.AddField("deletedCompanyLocationStaffMemberAssignmentIds");
            return this;
        }

        public CompanyLocationRemoveStaffMembersPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}