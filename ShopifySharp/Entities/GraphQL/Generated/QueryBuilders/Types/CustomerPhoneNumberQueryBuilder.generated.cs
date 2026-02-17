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
    public sealed class CustomerPhoneNumberQueryBuilder : FieldsQueryBuilderBase<CustomerPhoneNumber, CustomerPhoneNumberQueryBuilder>
    {
        protected override CustomerPhoneNumberQueryBuilder Self => this;

        public CustomerPhoneNumberQueryBuilder() : this("customerPhoneNumber")
        {
        }

        public CustomerPhoneNumberQueryBuilder(string name) : base(new Query<CustomerPhoneNumber>(name))
        {
        }

        public CustomerPhoneNumberQueryBuilder(IQuery<CustomerPhoneNumber> query) : base(query)
        {
        }

        public CustomerPhoneNumberQueryBuilder MarketingCollectedFrom()
        {
            base.InnerQuery.AddField("marketingCollectedFrom");
            return this;
        }

        public CustomerPhoneNumberQueryBuilder MarketingOptInLevel()
        {
            base.InnerQuery.AddField("marketingOptInLevel");
            return this;
        }

        public CustomerPhoneNumberQueryBuilder MarketingState()
        {
            base.InnerQuery.AddField("marketingState");
            return this;
        }

        public CustomerPhoneNumberQueryBuilder MarketingUpdatedAt()
        {
            base.InnerQuery.AddField("marketingUpdatedAt");
            return this;
        }

        public CustomerPhoneNumberQueryBuilder PhoneNumber()
        {
            base.InnerQuery.AddField("phoneNumber");
            return this;
        }

        public CustomerPhoneNumberQueryBuilder SourceLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("sourceLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}