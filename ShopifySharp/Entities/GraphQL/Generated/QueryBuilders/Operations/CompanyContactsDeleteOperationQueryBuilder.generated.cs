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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CompanyContactsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactsDeletePayload, CompanyContactsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactsDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyContactsDeleteOperationQueryBuilder Self => this;

        public CompanyContactsDeleteOperationQueryBuilder() : this("companyContactsDelete")
        {
        }

        public CompanyContactsDeleteOperationQueryBuilder(string name) : base(new Query<CompanyContactsDeletePayload>(name))
        {
            Arguments = new CompanyContactsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactsDeleteOperationQueryBuilder(IQuery<CompanyContactsDeletePayload> query) : base(query)
        {
            Arguments = new CompanyContactsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactsDeleteOperationQueryBuilder DeletedCompanyContactIds()
        {
            base.InnerQuery.AddField("deletedCompanyContactIds");
            return this;
        }

        public CompanyContactsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}