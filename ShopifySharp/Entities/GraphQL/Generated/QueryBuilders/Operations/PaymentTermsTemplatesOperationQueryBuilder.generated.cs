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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PaymentTermsTemplatesOperationQueryBuilder : FieldsQueryBuilderBase<PaymentTermsTemplate, PaymentTermsTemplatesOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentTermsTemplate>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PaymentTermsTemplatesArgumentsBuilder Arguments { get; }
        protected override PaymentTermsTemplatesOperationQueryBuilder Self => this;

        public PaymentTermsTemplatesOperationQueryBuilder() : this("paymentTermsTemplates")
        {
        }

        public PaymentTermsTemplatesOperationQueryBuilder(string name) : base(new Query<PaymentTermsTemplate>(name))
        {
            Arguments = new PaymentTermsTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsTemplatesOperationQueryBuilder(IQuery<PaymentTermsTemplate> query) : base(query)
        {
            Arguments = new PaymentTermsTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsTemplatesOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public PaymentTermsTemplatesOperationQueryBuilder DueInDays()
        {
            base.InnerQuery.AddField("dueInDays");
            return this;
        }

        public PaymentTermsTemplatesOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentTermsTemplatesOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PaymentTermsTemplatesOperationQueryBuilder PaymentTermsType()
        {
            base.InnerQuery.AddField("paymentTermsType");
            return this;
        }

        public PaymentTermsTemplatesOperationQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}