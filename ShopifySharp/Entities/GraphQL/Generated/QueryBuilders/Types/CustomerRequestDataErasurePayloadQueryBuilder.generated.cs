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
    public sealed class CustomerRequestDataErasurePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerRequestDataErasurePayload, CustomerRequestDataErasurePayloadQueryBuilder>
    {
        protected override CustomerRequestDataErasurePayloadQueryBuilder Self => this;

        public CustomerRequestDataErasurePayloadQueryBuilder() : this("customerRequestDataErasurePayload")
        {
        }

        public CustomerRequestDataErasurePayloadQueryBuilder(string name) : base(new Query<CustomerRequestDataErasurePayload>(name))
        {
        }

        public CustomerRequestDataErasurePayloadQueryBuilder(IQuery<CustomerRequestDataErasurePayload> query) : base(query)
        {
        }

        public CustomerRequestDataErasurePayloadQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public CustomerRequestDataErasurePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerRequestDataErasureUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerRequestDataErasureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerRequestDataErasureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerRequestDataErasureUserError>(query);
            return this;
        }
    }
}