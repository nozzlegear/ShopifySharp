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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CompanyLocationAssignAddressPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignAddressPayload, CompanyLocationAssignAddressPayloadQueryBuilder>
    {
        protected override CompanyLocationAssignAddressPayloadQueryBuilder Self => this;

        public CompanyLocationAssignAddressPayloadQueryBuilder() : this("companyLocationAssignAddressPayload")
        {
        }

        public CompanyLocationAssignAddressPayloadQueryBuilder(string name) : base(new Query<CompanyLocationAssignAddressPayload>(name))
        {
        }

        public CompanyLocationAssignAddressPayloadQueryBuilder(IQuery<CompanyLocationAssignAddressPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignAddressPayloadQueryBuilder Addresses(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("addresses");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public CompanyLocationAssignAddressPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}