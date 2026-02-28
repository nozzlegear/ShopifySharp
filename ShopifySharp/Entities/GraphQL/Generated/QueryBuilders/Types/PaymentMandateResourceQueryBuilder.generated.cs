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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class PaymentMandateResourceQueryBuilder : FieldsQueryBuilderBase<PaymentMandateResource, PaymentMandateResourceQueryBuilder>
    {
        protected override PaymentMandateResourceQueryBuilder Self => this;

        public PaymentMandateResourceQueryBuilder() : this("paymentMandateResource")
        {
        }

        public PaymentMandateResourceQueryBuilder(string name) : base(new Query<PaymentMandateResource>(name))
        {
        }

        public PaymentMandateResourceQueryBuilder(IQuery<PaymentMandateResource> query) : base(query)
        {
        }

        public PaymentMandateResourceQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public PaymentMandateResourceQueryBuilder ResourceType()
        {
            base.InnerQuery.AddField("resourceType");
            return this;
        }
    }
}