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
    public sealed class QueryRootPaymentTermsTemplatesQueryBuilder : FieldsQueryBuilderBase<PaymentTermsTemplate, QueryRootPaymentTermsTemplatesQueryBuilder>, IHasArguments<QueryRootPaymentTermsTemplatesArgumentsBuilder>
    {
        public QueryRootPaymentTermsTemplatesArgumentsBuilder Arguments { get; }
        protected override QueryRootPaymentTermsTemplatesQueryBuilder Self => this;

        public QueryRootPaymentTermsTemplatesQueryBuilder(string name) : base(new Query<PaymentTermsTemplate>(name))
        {
            Arguments = new QueryRootPaymentTermsTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder(IQuery<PaymentTermsTemplate> query) : base(query)
        {
            Arguments = new QueryRootPaymentTermsTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder SetArguments(Action<QueryRootPaymentTermsTemplatesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder DueInDays()
        {
            base.InnerQuery.AddField("dueInDays");
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder PaymentTermsType()
        {
            base.InnerQuery.AddField("paymentTermsType");
            return this;
        }

        public QueryRootPaymentTermsTemplatesQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}