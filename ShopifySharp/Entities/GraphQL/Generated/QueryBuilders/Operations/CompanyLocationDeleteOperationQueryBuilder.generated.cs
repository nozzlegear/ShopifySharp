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
    public sealed class CompanyLocationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationDeletePayload, CompanyLocationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyLocationDeleteOperationQueryBuilder Self => this;

        public CompanyLocationDeleteOperationQueryBuilder() : this("companyLocationDelete")
        {
        }

        public CompanyLocationDeleteOperationQueryBuilder(string name) : base(new Query<CompanyLocationDeletePayload>(name))
        {
            Arguments = new CompanyLocationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationDeleteOperationQueryBuilder(IQuery<CompanyLocationDeletePayload> query) : base(query)
        {
            Arguments = new CompanyLocationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationDeleteOperationQueryBuilder DeletedCompanyLocationId()
        {
            base.InnerQuery.AddField("deletedCompanyLocationId");
            return this;
        }

        public CompanyLocationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}