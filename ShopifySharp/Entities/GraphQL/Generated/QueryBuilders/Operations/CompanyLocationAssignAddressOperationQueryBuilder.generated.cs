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
    public sealed class CompanyLocationAssignAddressOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignAddressPayload, CompanyLocationAssignAddressOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationAssignAddressPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationAssignAddressArgumentsBuilder Arguments { get; }
        protected override CompanyLocationAssignAddressOperationQueryBuilder Self => this;

        public CompanyLocationAssignAddressOperationQueryBuilder() : this("companyLocationAssignAddress")
        {
        }

        public CompanyLocationAssignAddressOperationQueryBuilder(string name) : base(new Query<CompanyLocationAssignAddressPayload>(name))
        {
            Arguments = new CompanyLocationAssignAddressArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignAddressOperationQueryBuilder(IQuery<CompanyLocationAssignAddressPayload> query) : base(query)
        {
            Arguments = new CompanyLocationAssignAddressArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignAddressOperationQueryBuilder Addresses(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("addresses");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public CompanyLocationAssignAddressOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}