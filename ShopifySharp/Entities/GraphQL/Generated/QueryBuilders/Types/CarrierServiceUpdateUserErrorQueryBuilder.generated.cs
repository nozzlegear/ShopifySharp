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
    public sealed class CarrierServiceUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<CarrierServiceUpdateUserError, CarrierServiceUpdateUserErrorQueryBuilder>
    {
        protected override CarrierServiceUpdateUserErrorQueryBuilder Self => this;

        public CarrierServiceUpdateUserErrorQueryBuilder() : this("carrierServiceUpdateUserError")
        {
        }

        public CarrierServiceUpdateUserErrorQueryBuilder(string name) : base(new Query<CarrierServiceUpdateUserError>(name))
        {
        }

        public CarrierServiceUpdateUserErrorQueryBuilder(IQuery<CarrierServiceUpdateUserError> query) : base(query)
        {
        }

        public CarrierServiceUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CarrierServiceUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CarrierServiceUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}