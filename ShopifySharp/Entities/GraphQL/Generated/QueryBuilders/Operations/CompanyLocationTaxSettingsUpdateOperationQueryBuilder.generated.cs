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
    public sealed class CompanyLocationTaxSettingsUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationTaxSettingsUpdatePayload, CompanyLocationTaxSettingsUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationTaxSettingsUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationTaxSettingsUpdateArgumentsBuilder Arguments { get; }
        protected override CompanyLocationTaxSettingsUpdateOperationQueryBuilder Self => this;

        public CompanyLocationTaxSettingsUpdateOperationQueryBuilder() : this("companyLocationTaxSettingsUpdate")
        {
        }

        public CompanyLocationTaxSettingsUpdateOperationQueryBuilder(string name) : base(new Query<CompanyLocationTaxSettingsUpdatePayload>(name))
        {
            Arguments = new CompanyLocationTaxSettingsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationTaxSettingsUpdateOperationQueryBuilder(IQuery<CompanyLocationTaxSettingsUpdatePayload> query) : base(query)
        {
            Arguments = new CompanyLocationTaxSettingsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationTaxSettingsUpdateOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationTaxSettingsUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}