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
    public sealed class CompanyContactDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactDeletePayload, CompanyContactDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyContactDeleteOperationQueryBuilder Self => this;

        public CompanyContactDeleteOperationQueryBuilder() : this("companyContactDelete")
        {
        }

        public CompanyContactDeleteOperationQueryBuilder(string name) : base(new Query<CompanyContactDeletePayload>(name))
        {
            Arguments = new CompanyContactDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactDeleteOperationQueryBuilder(IQuery<CompanyContactDeletePayload> query) : base(query)
        {
            Arguments = new CompanyContactDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactDeleteOperationQueryBuilder DeletedCompanyContactId()
        {
            base.InnerQuery.AddField("deletedCompanyContactId");
            return this;
        }

        public CompanyContactDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}