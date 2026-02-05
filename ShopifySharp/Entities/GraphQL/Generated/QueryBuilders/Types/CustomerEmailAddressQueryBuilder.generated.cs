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
    public sealed class CustomerEmailAddressQueryBuilder : FieldsQueryBuilderBase<CustomerEmailAddress, CustomerEmailAddressQueryBuilder>
    {
        protected override CustomerEmailAddressQueryBuilder Self => this;

        public CustomerEmailAddressQueryBuilder() : this("customerEmailAddress")
        {
        }

        public CustomerEmailAddressQueryBuilder(string name) : base(new Query<CustomerEmailAddress>(name))
        {
        }

        public CustomerEmailAddressQueryBuilder(IQuery<CustomerEmailAddress> query) : base(query)
        {
        }

        public CustomerEmailAddressQueryBuilder EmailAddress()
        {
            base.InnerQuery.AddField("emailAddress");
            return this;
        }

        public CustomerEmailAddressQueryBuilder MarketingOptInLevel()
        {
            base.InnerQuery.AddField("marketingOptInLevel");
            return this;
        }

        public CustomerEmailAddressQueryBuilder MarketingState()
        {
            base.InnerQuery.AddField("marketingState");
            return this;
        }

        public CustomerEmailAddressQueryBuilder MarketingUnsubscribeUrl()
        {
            base.InnerQuery.AddField("marketingUnsubscribeUrl");
            return this;
        }

        public CustomerEmailAddressQueryBuilder MarketingUpdatedAt()
        {
            base.InnerQuery.AddField("marketingUpdatedAt");
            return this;
        }

        public CustomerEmailAddressQueryBuilder OpenTrackingLevel()
        {
            base.InnerQuery.AddField("openTrackingLevel");
            return this;
        }

        public CustomerEmailAddressQueryBuilder OpenTrackingUrl()
        {
            base.InnerQuery.AddField("openTrackingUrl");
            return this;
        }

        public CustomerEmailAddressQueryBuilder SourceLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("sourceLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CustomerEmailAddressQueryBuilder ValidFormat()
        {
            base.InnerQuery.AddField("validFormat");
            return this;
        }
    }
}