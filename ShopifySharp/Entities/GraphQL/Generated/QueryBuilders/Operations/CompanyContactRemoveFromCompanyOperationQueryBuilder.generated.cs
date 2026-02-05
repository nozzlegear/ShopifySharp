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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CompanyContactRemoveFromCompanyOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactRemoveFromCompanyPayload, CompanyContactRemoveFromCompanyOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactRemoveFromCompanyPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactRemoveFromCompanyArgumentsBuilder Arguments { get; }
        protected override CompanyContactRemoveFromCompanyOperationQueryBuilder Self => this;

        public CompanyContactRemoveFromCompanyOperationQueryBuilder() : this("companyContactRemoveFromCompany")
        {
        }

        public CompanyContactRemoveFromCompanyOperationQueryBuilder(string name) : base(new Query<CompanyContactRemoveFromCompanyPayload>(name))
        {
            Arguments = new CompanyContactRemoveFromCompanyArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRemoveFromCompanyOperationQueryBuilder(IQuery<CompanyContactRemoveFromCompanyPayload> query) : base(query)
        {
            Arguments = new CompanyContactRemoveFromCompanyArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRemoveFromCompanyOperationQueryBuilder RemovedCompanyContactId()
        {
            base.InnerQuery.AddField("removedCompanyContactId");
            return this;
        }

        public CompanyContactRemoveFromCompanyOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}