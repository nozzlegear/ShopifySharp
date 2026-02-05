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
    public sealed class CustomerMergePreviewDefaultFieldsQueryBuilder : FieldsQueryBuilderBase<CustomerMergePreviewDefaultFields, CustomerMergePreviewDefaultFieldsQueryBuilder>
    {
        protected override CustomerMergePreviewDefaultFieldsQueryBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsQueryBuilder() : this("customerMergePreviewDefaultFields")
        {
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder(string name) : base(new Query<CustomerMergePreviewDefaultFields>(name))
        {
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder(IQuery<CustomerMergePreviewDefaultFields> query) : base(query)
        {
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder Addresses(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressConnectionQueryBuilder> build)
        {
            var query = new Query<MailingAddressConnection>("addresses");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddressConnection>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DefaultAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("defaultAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DiscountNodeCount()
        {
            base.InnerQuery.AddField("discountNodeCount");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DiscountNodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountNodeConnection>("discountNodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNodeConnection>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DraftOrderCount()
        {
            base.InnerQuery.AddField("draftOrderCount");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder Email(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder> build)
        {
            var query = new Query<CustomerEmailAddress>("email");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailAddress>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder GiftCardCount()
        {
            base.InnerQuery.AddField("giftCardCount");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder GiftCards(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConnectionQueryBuilder> build)
        {
            var query = new Query<GiftCardConnection>("giftCards");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardConnection>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder MetafieldCount()
        {
            base.InnerQuery.AddField("metafieldCount");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder OrderCount()
        {
            base.InnerQuery.AddField("orderCount");
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder PhoneNumber(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder> build)
        {
            var query = new Query<CustomerPhoneNumber>("phoneNumber");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPhoneNumber>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }
    }
}