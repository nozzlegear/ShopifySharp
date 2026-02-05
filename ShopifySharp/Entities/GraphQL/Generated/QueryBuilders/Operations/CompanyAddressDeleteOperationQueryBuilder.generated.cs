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
    public sealed class CompanyAddressDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyAddressDeletePayload, CompanyAddressDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyAddressDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyAddressDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyAddressDeleteOperationQueryBuilder Self => this;

        public CompanyAddressDeleteOperationQueryBuilder() : this("companyAddressDelete")
        {
        }

        public CompanyAddressDeleteOperationQueryBuilder(string name) : base(new Query<CompanyAddressDeletePayload>(name))
        {
            Arguments = new CompanyAddressDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyAddressDeleteOperationQueryBuilder(IQuery<CompanyAddressDeletePayload> query) : base(query)
        {
            Arguments = new CompanyAddressDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyAddressDeleteOperationQueryBuilder DeletedAddressId()
        {
            base.InnerQuery.AddField("deletedAddressId");
            return this;
        }

        public CompanyAddressDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}