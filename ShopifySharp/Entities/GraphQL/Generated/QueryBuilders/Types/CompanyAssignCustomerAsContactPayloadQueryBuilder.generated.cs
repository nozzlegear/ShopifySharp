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
    public sealed class CompanyAssignCustomerAsContactPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyAssignCustomerAsContactPayload, CompanyAssignCustomerAsContactPayloadQueryBuilder>
    {
        protected override CompanyAssignCustomerAsContactPayloadQueryBuilder Self => this;

        public CompanyAssignCustomerAsContactPayloadQueryBuilder() : this("companyAssignCustomerAsContactPayload")
        {
        }

        public CompanyAssignCustomerAsContactPayloadQueryBuilder(string name) : base(new Query<CompanyAssignCustomerAsContactPayload>(name))
        {
        }

        public CompanyAssignCustomerAsContactPayloadQueryBuilder(IQuery<CompanyAssignCustomerAsContactPayload> query) : base(query)
        {
        }

        public CompanyAssignCustomerAsContactPayloadQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyAssignCustomerAsContactPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}