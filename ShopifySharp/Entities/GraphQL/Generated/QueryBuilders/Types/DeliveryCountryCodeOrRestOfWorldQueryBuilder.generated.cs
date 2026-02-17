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
    public sealed class DeliveryCountryCodeOrRestOfWorldQueryBuilder : FieldsQueryBuilderBase<DeliveryCountryCodeOrRestOfWorld, DeliveryCountryCodeOrRestOfWorldQueryBuilder>
    {
        protected override DeliveryCountryCodeOrRestOfWorldQueryBuilder Self => this;

        public DeliveryCountryCodeOrRestOfWorldQueryBuilder() : this("deliveryCountryCodeOrRestOfWorld")
        {
        }

        public DeliveryCountryCodeOrRestOfWorldQueryBuilder(string name) : base(new Query<DeliveryCountryCodeOrRestOfWorld>(name))
        {
        }

        public DeliveryCountryCodeOrRestOfWorldQueryBuilder(IQuery<DeliveryCountryCodeOrRestOfWorld> query) : base(query)
        {
        }

        public DeliveryCountryCodeOrRestOfWorldQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public DeliveryCountryCodeOrRestOfWorldQueryBuilder RestOfWorld()
        {
            base.InnerQuery.AddField("restOfWorld");
            return this;
        }
    }
}