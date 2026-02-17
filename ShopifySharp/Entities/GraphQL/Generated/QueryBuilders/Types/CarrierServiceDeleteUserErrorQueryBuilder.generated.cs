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
    public sealed class CarrierServiceDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<CarrierServiceDeleteUserError, CarrierServiceDeleteUserErrorQueryBuilder>
    {
        protected override CarrierServiceDeleteUserErrorQueryBuilder Self => this;

        public CarrierServiceDeleteUserErrorQueryBuilder() : this("carrierServiceDeleteUserError")
        {
        }

        public CarrierServiceDeleteUserErrorQueryBuilder(string name) : base(new Query<CarrierServiceDeleteUserError>(name))
        {
        }

        public CarrierServiceDeleteUserErrorQueryBuilder(IQuery<CarrierServiceDeleteUserError> query) : base(query)
        {
        }

        public CarrierServiceDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CarrierServiceDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CarrierServiceDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}