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