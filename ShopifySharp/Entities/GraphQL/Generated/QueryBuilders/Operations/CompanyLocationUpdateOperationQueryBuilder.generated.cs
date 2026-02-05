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
    public sealed class CompanyLocationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationUpdatePayload, CompanyLocationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationUpdateArgumentsBuilder Arguments { get; }
        protected override CompanyLocationUpdateOperationQueryBuilder Self => this;

        public CompanyLocationUpdateOperationQueryBuilder() : this("companyLocationUpdate")
        {
        }

        public CompanyLocationUpdateOperationQueryBuilder(string name) : base(new Query<CompanyLocationUpdatePayload>(name))
        {
            Arguments = new CompanyLocationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationUpdateOperationQueryBuilder(IQuery<CompanyLocationUpdatePayload> query) : base(query)
        {
            Arguments = new CompanyLocationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationUpdateOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}