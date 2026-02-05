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
    public sealed class PaymentTermsTemplateQueryBuilder : FieldsQueryBuilderBase<PaymentTermsTemplate, PaymentTermsTemplateQueryBuilder>
    {
        protected override PaymentTermsTemplateQueryBuilder Self => this;

        public PaymentTermsTemplateQueryBuilder() : this("paymentTermsTemplate")
        {
        }

        public PaymentTermsTemplateQueryBuilder(string name) : base(new Query<PaymentTermsTemplate>(name))
        {
        }

        public PaymentTermsTemplateQueryBuilder(IQuery<PaymentTermsTemplate> query) : base(query)
        {
        }

        public PaymentTermsTemplateQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public PaymentTermsTemplateQueryBuilder DueInDays()
        {
            base.InnerQuery.AddField("dueInDays");
            return this;
        }

        public PaymentTermsTemplateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentTermsTemplateQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PaymentTermsTemplateQueryBuilder PaymentTermsType()
        {
            base.InnerQuery.AddField("paymentTermsType");
            return this;
        }

        public PaymentTermsTemplateQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}