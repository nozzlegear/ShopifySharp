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

        public CompanyLocationCreateOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}