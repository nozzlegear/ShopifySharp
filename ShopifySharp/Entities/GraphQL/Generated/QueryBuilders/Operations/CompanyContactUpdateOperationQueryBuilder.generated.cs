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
    public sealed class CompanyContactUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactUpdatePayload, CompanyContactUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactUpdateArgumentsBuilder Arguments { get; }
        protected override CompanyContactUpdateOperationQueryBuilder Self => this;

        public CompanyContactUpdateOperationQueryBuilder() : this("companyContactUpdate")
        {
        }

        public CompanyContactUpdateOperationQueryBuilder(string name) : base(new Query<CompanyContactUpdatePayload>(name))
        {
            Arguments = new CompanyContactUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactUpdateOperationQueryBuilder(IQuery<CompanyContactUpdatePayload> query) : base(query)
        {
            Arguments = new CompanyContactUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactUpdateOperationQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyContactUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}