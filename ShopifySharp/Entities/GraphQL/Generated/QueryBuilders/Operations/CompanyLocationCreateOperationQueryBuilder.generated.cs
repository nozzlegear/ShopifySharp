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
    public sealed class CompanyLocationCreateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationCreatePayload, CompanyLocationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationCreateArgumentsBuilder Arguments { get; }
        protected override CompanyLocationCreateOperationQueryBuilder Self => this;

        public CompanyLocationCreateOperationQueryBuilder() : this("companyLocationCreate")
        {
        }

        public CompanyLocationCreateOperationQueryBuilder(string name) : base(new Query<CompanyLocationCreatePayload>(name))
        {
            Arguments = new CompanyLocationCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCreateOperationQueryBuilder(IQuery<CompanyLocationCreatePayload> query) : base(query)
        {
            Arguments = new CompanyLocationCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCreateOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}