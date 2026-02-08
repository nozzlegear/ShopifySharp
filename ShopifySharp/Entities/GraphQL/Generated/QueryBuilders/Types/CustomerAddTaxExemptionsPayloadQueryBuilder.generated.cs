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
    public sealed class CustomerAddTaxExemptionsPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerAddTaxExemptionsPayload, CustomerAddTaxExemptionsPayloadQueryBuilder>
    {
        protected override CustomerAddTaxExemptionsPayloadQueryBuilder Self => this;

        public CustomerAddTaxExemptionsPayloadQueryBuilder() : this("customerAddTaxExemptionsPayload")
        {
        }

        public CustomerAddTaxExemptionsPayloadQueryBuilder(string name) : base(new Query<CustomerAddTaxExemptionsPayload>(name))
        {
        }

        public CustomerAddTaxExemptionsPayloadQueryBuilder(IQuery<CustomerAddTaxExemptionsPayload> query) : base(query)
        {
        }

        public CustomerAddTaxExemptionsPayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerAddTaxExemptionsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}