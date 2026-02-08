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
    public sealed class CustomerMergePreviewAlternateFieldsQueryBuilder : FieldsQueryBuilderBase<CustomerMergePreviewAlternateFields, CustomerMergePreviewAlternateFieldsQueryBuilder>
    {
        protected override CustomerMergePreviewAlternateFieldsQueryBuilder Self => this;

        public CustomerMergePreviewAlternateFieldsQueryBuilder() : this("customerMergePreviewAlternateFields")
        {
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder(string name) : base(new Query<CustomerMergePreviewAlternateFields>(name))
        {
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder(IQuery<CustomerMergePreviewAlternateFields> query) : base(query)
        {
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder DefaultAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("defaultAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder Email(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder> build)
        {
            var query = new Query<CustomerEmailAddress>("email");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailAddress>(query);
            return this;
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerMergePreviewAlternateFieldsQueryBuilder PhoneNumber(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder> build)
        {
            var query = new Query<CustomerPhoneNumber>("phoneNumber");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPhoneNumber>(query);
            return this;
        }
    }
}