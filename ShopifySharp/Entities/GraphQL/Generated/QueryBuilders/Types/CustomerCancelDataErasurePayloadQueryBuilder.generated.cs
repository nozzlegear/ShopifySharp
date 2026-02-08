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
    public sealed class CustomerCancelDataErasurePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerCancelDataErasurePayload, CustomerCancelDataErasurePayloadQueryBuilder>
    {
        protected override CustomerCancelDataErasurePayloadQueryBuilder Self => this;

        public CustomerCancelDataErasurePayloadQueryBuilder() : this("customerCancelDataErasurePayload")
        {
        }

        public CustomerCancelDataErasurePayloadQueryBuilder(string name) : base(new Query<CustomerCancelDataErasurePayload>(name))
        {
        }

        public CustomerCancelDataErasurePayloadQueryBuilder(IQuery<CustomerCancelDataErasurePayload> query) : base(query)
        {
        }

        public CustomerCancelDataErasurePayloadQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public CustomerCancelDataErasurePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCancelDataErasureUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerCancelDataErasureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCancelDataErasureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerCancelDataErasureUserError>(query);
            return this;
        }
    }
}