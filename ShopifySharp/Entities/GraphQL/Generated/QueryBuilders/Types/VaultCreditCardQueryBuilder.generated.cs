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
    public sealed class VaultCreditCardQueryBuilder : FieldsQueryBuilderBase<VaultCreditCard, VaultCreditCardQueryBuilder>
    {
        protected override VaultCreditCardQueryBuilder Self => this;

        public VaultCreditCardQueryBuilder() : this("vaultCreditCard")
        {
        }

        public VaultCreditCardQueryBuilder(string name) : base(new Query<VaultCreditCard>(name))
        {
        }

        public VaultCreditCardQueryBuilder(IQuery<VaultCreditCard> query) : base(query)
        {
        }

        public VaultCreditCardQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder> build)
        {
            var query = new Query<CustomerCreditCardBillingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerCreditCardBillingAddress>(query);
            return this;
        }

        public VaultCreditCardQueryBuilder Brand()
        {
            base.InnerQuery.AddField("brand");
            return this;
        }

        public VaultCreditCardQueryBuilder Expired()
        {
            base.InnerQuery.AddField("expired");
            return this;
        }

        public VaultCreditCardQueryBuilder ExpiryMonth()
        {
            base.InnerQuery.AddField("expiryMonth");
            return this;
        }

        public VaultCreditCardQueryBuilder ExpiryYear()
        {
            base.InnerQuery.AddField("expiryYear");
            return this;
        }

        public VaultCreditCardQueryBuilder LastDigits()
        {
            base.InnerQuery.AddField("lastDigits");
            return this;
        }

        public VaultCreditCardQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}