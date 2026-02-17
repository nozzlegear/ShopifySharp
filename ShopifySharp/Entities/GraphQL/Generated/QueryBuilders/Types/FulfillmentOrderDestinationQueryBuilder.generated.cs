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
    public sealed class FulfillmentOrderDestinationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderDestination, FulfillmentOrderDestinationQueryBuilder>
    {
        protected override FulfillmentOrderDestinationQueryBuilder Self => this;

        public FulfillmentOrderDestinationQueryBuilder() : this("fulfillmentOrderDestination")
        {
        }

        public FulfillmentOrderDestinationQueryBuilder(string name) : base(new Query<FulfillmentOrderDestination>(name))
        {
        }

        public FulfillmentOrderDestinationQueryBuilder(IQuery<FulfillmentOrderDestination> query) : base(query)
        {
        }

        public FulfillmentOrderDestinationQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public FulfillmentOrderDestinationQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}