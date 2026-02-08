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
    public sealed class VaultPaypalBillingAgreementQueryBuilder : FieldsQueryBuilderBase<VaultPaypalBillingAgreement, VaultPaypalBillingAgreementQueryBuilder>
    {
        protected override VaultPaypalBillingAgreementQueryBuilder Self => this;

        public VaultPaypalBillingAgreementQueryBuilder() : this("vaultPaypalBillingAgreement")
        {
        }

        public VaultPaypalBillingAgreementQueryBuilder(string name) : base(new Query<VaultPaypalBillingAgreement>(name))
        {
        }

        public VaultPaypalBillingAgreementQueryBuilder(IQuery<VaultPaypalBillingAgreement> query) : base(query)
        {
        }

        public VaultPaypalBillingAgreementQueryBuilder Inactive()
        {
            base.InnerQuery.AddField("inactive");
            return this;
        }

        public VaultPaypalBillingAgreementQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public VaultPaypalBillingAgreementQueryBuilder PaypalAccountEmail()
        {
            base.InnerQuery.AddField("paypalAccountEmail");
            return this;
        }
    }
}