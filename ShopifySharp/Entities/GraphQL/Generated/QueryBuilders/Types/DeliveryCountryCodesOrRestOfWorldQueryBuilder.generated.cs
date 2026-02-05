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
    public sealed class DeliveryCountryCodesOrRestOfWorldQueryBuilder : FieldsQueryBuilderBase<DeliveryCountryCodesOrRestOfWorld, DeliveryCountryCodesOrRestOfWorldQueryBuilder>
    {
        protected override DeliveryCountryCodesOrRestOfWorldQueryBuilder Self => this;

        public DeliveryCountryCodesOrRestOfWorldQueryBuilder() : this("deliveryCountryCodesOrRestOfWorld")
        {
        }

        public DeliveryCountryCodesOrRestOfWorldQueryBuilder(string name) : base(new Query<DeliveryCountryCodesOrRestOfWorld>(name))
        {
        }

        public DeliveryCountryCodesOrRestOfWorldQueryBuilder(IQuery<DeliveryCountryCodesOrRestOfWorld> query) : base(query)
        {
        }

        public DeliveryCountryCodesOrRestOfWorldQueryBuilder CountryCodes()
        {
            base.InnerQuery.AddField("countryCodes");
            return this;
        }

        public DeliveryCountryCodesOrRestOfWorldQueryBuilder RestOfWorld()
        {
            base.InnerQuery.AddField("restOfWorld");
            return this;
        }
    }
}