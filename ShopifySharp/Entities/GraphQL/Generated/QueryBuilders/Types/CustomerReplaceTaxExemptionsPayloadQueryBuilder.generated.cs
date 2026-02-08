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
    public sealed class CustomerReplaceTaxExemptionsPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerReplaceTaxExemptionsPayload, CustomerReplaceTaxExemptionsPayloadQueryBuilder>
    {
        protected override CustomerReplaceTaxExemptionsPayloadQueryBuilder Self => this;

        public CustomerReplaceTaxExemptionsPayloadQueryBuilder() : this("customerReplaceTaxExemptionsPayload")
        {
        }

        public CustomerReplaceTaxExemptionsPayloadQueryBuilder(string name) : base(new Query<CustomerReplaceTaxExemptionsPayload>(name))
        {
        }

        public CustomerReplaceTaxExemptionsPayloadQueryBuilder(IQuery<CustomerReplaceTaxExemptionsPayload> query) : base(query)
        {
        }

        public CustomerReplaceTaxExemptionsPayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerReplaceTaxExemptionsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}