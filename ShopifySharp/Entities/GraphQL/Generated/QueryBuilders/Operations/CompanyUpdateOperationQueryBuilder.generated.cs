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
    public sealed class CompanyUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyUpdatePayload, CompanyUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyUpdateArgumentsBuilder Arguments { get; }
        protected override CompanyUpdateOperationQueryBuilder Self => this;

        public CompanyUpdateOperationQueryBuilder() : this("companyUpdate")
        {
        }

        public CompanyUpdateOperationQueryBuilder(string name) : base(new Query<CompanyUpdatePayload>(name))
        {
            Arguments = new CompanyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyUpdateOperationQueryBuilder(IQuery<CompanyUpdatePayload> query) : base(query)
        {
            Arguments = new CompanyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyUpdateOperationQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}