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
    public sealed class DeliveryPromiseProviderUpsertUserErrorQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProviderUpsertUserError, DeliveryPromiseProviderUpsertUserErrorQueryBuilder>
    {
        protected override DeliveryPromiseProviderUpsertUserErrorQueryBuilder Self => this;

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder() : this("deliveryPromiseProviderUpsertUserError")
        {
        }

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder(string name) : base(new Query<DeliveryPromiseProviderUpsertUserError>(name))
        {
        }

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder(IQuery<DeliveryPromiseProviderUpsertUserError> query) : base(query)
        {
        }

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DeliveryPromiseProviderUpsertUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}