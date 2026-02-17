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
    public sealed class FulfillmentOrderAssignedLocationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderAssignedLocation, FulfillmentOrderAssignedLocationQueryBuilder>
    {
        protected override FulfillmentOrderAssignedLocationQueryBuilder Self => this;

        public FulfillmentOrderAssignedLocationQueryBuilder() : this("fulfillmentOrderAssignedLocation")
        {
        }

        public FulfillmentOrderAssignedLocationQueryBuilder(string name) : base(new Query<FulfillmentOrderAssignedLocation>(name))
        {
        }

        public FulfillmentOrderAssignedLocationQueryBuilder(IQuery<FulfillmentOrderAssignedLocation> query) : base(query)
        {
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public FulfillmentOrderAssignedLocationQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}