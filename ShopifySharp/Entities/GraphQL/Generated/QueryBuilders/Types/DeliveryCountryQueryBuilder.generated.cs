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
    public sealed class DeliveryCountryQueryBuilder : FieldsQueryBuilderBase<DeliveryCountry, DeliveryCountryQueryBuilder>
    {
        protected override DeliveryCountryQueryBuilder Self => this;

        public DeliveryCountryQueryBuilder() : this("deliveryCountry")
        {
        }

        public DeliveryCountryQueryBuilder(string name) : base(new Query<DeliveryCountry>(name))
        {
        }

        public DeliveryCountryQueryBuilder(IQuery<DeliveryCountry> query) : base(query)
        {
        }

        public DeliveryCountryQueryBuilder Code(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryCodeOrRestOfWorldQueryBuilder> build)
        {
            var query = new Query<DeliveryCountryCodeOrRestOfWorld>("code");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryCodeOrRestOfWorldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountryCodeOrRestOfWorld>(query);
            return this;
        }

        public DeliveryCountryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryCountryQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryCountryQueryBuilder Provinces(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProvinceQueryBuilder> build)
        {
            var query = new Query<DeliveryProvince>("provinces");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProvinceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProvince>(query);
            return this;
        }

        public DeliveryCountryQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}