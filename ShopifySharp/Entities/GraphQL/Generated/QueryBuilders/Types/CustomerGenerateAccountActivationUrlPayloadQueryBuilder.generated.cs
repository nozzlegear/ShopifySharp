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
    public sealed class CustomerGenerateAccountActivationUrlPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerGenerateAccountActivationUrlPayload, CustomerGenerateAccountActivationUrlPayloadQueryBuilder>
    {
        protected override CustomerGenerateAccountActivationUrlPayloadQueryBuilder Self => this;

        public CustomerGenerateAccountActivationUrlPayloadQueryBuilder() : this("customerGenerateAccountActivationUrlPayload")
        {
        }

        public CustomerGenerateAccountActivationUrlPayloadQueryBuilder(string name) : base(new Query<CustomerGenerateAccountActivationUrlPayload>(name))
        {
        }

        public CustomerGenerateAccountActivationUrlPayloadQueryBuilder(IQuery<CustomerGenerateAccountActivationUrlPayload> query) : base(query)
        {
        }

        public CustomerGenerateAccountActivationUrlPayloadQueryBuilder AccountActivationUrl()
        {
            base.InnerQuery.AddField("accountActivationUrl");
            return this;
        }

        public CustomerGenerateAccountActivationUrlPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}