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
    public sealed class SubscriptionDraftCustomerPaymentMethodQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethod, SubscriptionDraftCustomerPaymentMethodQueryBuilder>, IHasArguments<SubscriptionDraftCustomerPaymentMethodArgumentsBuilder>
    {
        public SubscriptionDraftCustomerPaymentMethodArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftCustomerPaymentMethodQueryBuilder Self => this;

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder(string name) : base(new Query<CustomerPaymentMethod>(name))
        {
            Arguments = new SubscriptionDraftCustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder(IQuery<CustomerPaymentMethod> query) : base(query)
        {
            Arguments = new SubscriptionDraftCustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder SetArguments(Action<SubscriptionDraftCustomerPaymentMethodArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder Mandates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResourceConnection>("mandates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResourceConnection>(query);
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder RevokedAt()
        {
            base.InnerQuery.AddField("revokedAt");
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder RevokedReason()
        {
            base.InnerQuery.AddField("revokedReason");
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public SubscriptionDraftCustomerPaymentMethodQueryBuilder Instrument(Action<CustomerPaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrument>("instrument");
            var unionBuilder = new CustomerPaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}