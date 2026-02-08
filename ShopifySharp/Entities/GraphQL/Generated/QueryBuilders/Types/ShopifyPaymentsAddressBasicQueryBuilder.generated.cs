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
    public sealed class ShopifyPaymentsAddressBasicQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsAddressBasic, ShopifyPaymentsAddressBasicQueryBuilder>
    {
        protected override ShopifyPaymentsAddressBasicQueryBuilder Self => this;

        public ShopifyPaymentsAddressBasicQueryBuilder() : this("shopifyPaymentsAddressBasic")
        {
        }

        public ShopifyPaymentsAddressBasicQueryBuilder(string name) : base(new Query<ShopifyPaymentsAddressBasic>(name))
        {
        }

        public ShopifyPaymentsAddressBasicQueryBuilder(IQuery<ShopifyPaymentsAddressBasic> query) : base(query)
        {
        }

        public ShopifyPaymentsAddressBasicQueryBuilder AddressLine1()
        {
            base.InnerQuery.AddField("addressLine1");
            return this;
        }

        public ShopifyPaymentsAddressBasicQueryBuilder AddressLine2()
        {
            base.InnerQuery.AddField("addressLine2");
            return this;
        }

        public ShopifyPaymentsAddressBasicQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public ShopifyPaymentsAddressBasicQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public ShopifyPaymentsAddressBasicQueryBuilder PostalCode()
        {
            base.InnerQuery.AddField("postalCode");
            return this;
        }

        public ShopifyPaymentsAddressBasicQueryBuilder Zone()
        {
            base.InnerQuery.AddField("zone");
            return this;
        }
    }
}