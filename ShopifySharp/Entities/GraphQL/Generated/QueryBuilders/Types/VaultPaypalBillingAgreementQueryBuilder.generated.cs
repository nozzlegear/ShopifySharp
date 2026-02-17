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