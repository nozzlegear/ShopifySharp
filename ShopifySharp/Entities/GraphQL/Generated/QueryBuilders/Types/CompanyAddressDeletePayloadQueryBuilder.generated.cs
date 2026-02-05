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
    public sealed class CompanyAddressDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyAddressDeletePayload, CompanyAddressDeletePayloadQueryBuilder>
    {
        protected override CompanyAddressDeletePayloadQueryBuilder Self => this;

        public CompanyAddressDeletePayloadQueryBuilder() : this("companyAddressDeletePayload")
        {
        }

        public CompanyAddressDeletePayloadQueryBuilder(string name) : base(new Query<CompanyAddressDeletePayload>(name))
        {
        }

        public CompanyAddressDeletePayloadQueryBuilder(IQuery<CompanyAddressDeletePayload> query) : base(query)
        {
        }

        public CompanyAddressDeletePayloadQueryBuilder DeletedAddressId()
        {
            base.InnerQuery.AddField("deletedAddressId");
            return this;
        }

        public CompanyAddressDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}