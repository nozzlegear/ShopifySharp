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
    public sealed class DeliveryProvinceQueryBuilder : FieldsQueryBuilderBase<DeliveryProvince, DeliveryProvinceQueryBuilder>
    {
        protected override DeliveryProvinceQueryBuilder Self => this;

        public DeliveryProvinceQueryBuilder() : this("deliveryProvince")
        {
        }

        public DeliveryProvinceQueryBuilder(string name) : base(new Query<DeliveryProvince>(name))
        {
        }

        public DeliveryProvinceQueryBuilder(IQuery<DeliveryProvince> query) : base(query)
        {
        }

        public DeliveryProvinceQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DeliveryProvinceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryProvinceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryProvinceQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}