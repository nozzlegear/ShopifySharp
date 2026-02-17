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
    public sealed class CarrierServiceCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<CarrierServiceCreateUserError, CarrierServiceCreateUserErrorQueryBuilder>
    {
        protected override CarrierServiceCreateUserErrorQueryBuilder Self => this;

        public CarrierServiceCreateUserErrorQueryBuilder() : this("carrierServiceCreateUserError")
        {
        }

        public CarrierServiceCreateUserErrorQueryBuilder(string name) : base(new Query<CarrierServiceCreateUserError>(name))
        {
        }

        public CarrierServiceCreateUserErrorQueryBuilder(IQuery<CarrierServiceCreateUserError> query) : base(query)
        {
        }

        public CarrierServiceCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CarrierServiceCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CarrierServiceCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}