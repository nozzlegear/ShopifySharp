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
    public sealed class CompanyCreateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyCreatePayload, CompanyCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyCreateArgumentsBuilder Arguments { get; }
        protected override CompanyCreateOperationQueryBuilder Self => this;

        public CompanyCreateOperationQueryBuilder() : this("companyCreate")
        {
        }

        public CompanyCreateOperationQueryBuilder(string name) : base(new Query<CompanyCreatePayload>(name))
        {
            Arguments = new CompanyCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyCreateOperationQueryBuilder(IQuery<CompanyCreatePayload> query) : base(query)
        {
            Arguments = new CompanyCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyCreateOperationQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}