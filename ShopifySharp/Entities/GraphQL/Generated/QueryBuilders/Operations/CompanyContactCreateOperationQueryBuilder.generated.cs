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
    public sealed class CompanyContactCreateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactCreatePayload, CompanyContactCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactCreateArgumentsBuilder Arguments { get; }
        protected override CompanyContactCreateOperationQueryBuilder Self => this;

        public CompanyContactCreateOperationQueryBuilder() : this("companyContactCreate")
        {
        }

        public CompanyContactCreateOperationQueryBuilder(string name) : base(new Query<CompanyContactCreatePayload>(name))
        {
            Arguments = new CompanyContactCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactCreateOperationQueryBuilder(IQuery<CompanyContactCreatePayload> query) : base(query)
        {
            Arguments = new CompanyContactCreateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactCreateOperationQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyContactCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}