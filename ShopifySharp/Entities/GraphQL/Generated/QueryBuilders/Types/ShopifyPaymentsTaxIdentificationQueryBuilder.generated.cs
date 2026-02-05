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
    public sealed class ShopifyPaymentsTaxIdentificationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsTaxIdentification, ShopifyPaymentsTaxIdentificationQueryBuilder>
    {
        protected override ShopifyPaymentsTaxIdentificationQueryBuilder Self => this;

        public ShopifyPaymentsTaxIdentificationQueryBuilder() : this("shopifyPaymentsTaxIdentification")
        {
        }

        public ShopifyPaymentsTaxIdentificationQueryBuilder(string name) : base(new Query<ShopifyPaymentsTaxIdentification>(name))
        {
        }

        public ShopifyPaymentsTaxIdentificationQueryBuilder(IQuery<ShopifyPaymentsTaxIdentification> query) : base(query)
        {
        }

        public ShopifyPaymentsTaxIdentificationQueryBuilder TaxIdentificationType()
        {
            base.InnerQuery.AddField("taxIdentificationType");
            return this;
        }

        public ShopifyPaymentsTaxIdentificationQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}