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
    public sealed class QueryRootCustomerPaymentMethodQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethod, QueryRootCustomerPaymentMethodQueryBuilder>, IHasArguments<QueryRootCustomerPaymentMethodArgumentsBuilder>
    {
        public QueryRootCustomerPaymentMethodArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerPaymentMethodQueryBuilder Self => this;

        public QueryRootCustomerPaymentMethodQueryBuilder(string name) : base(new Query<CustomerPaymentMethod>(name))
        {
            Arguments = new QueryRootCustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerPaymentMethodQueryBuilder(IQuery<CustomerPaymentMethod> query) : base(query)
        {
            Arguments = new QueryRootCustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerPaymentMethodQueryBuilder SetArguments(Action<QueryRootCustomerPaymentMethodArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder Mandates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResourceConnection>("mandates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResourceConnection>(query);
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder RevokedAt()
        {
            base.InnerQuery.AddField("revokedAt");
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder RevokedReason()
        {
            base.InnerQuery.AddField("revokedReason");
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public QueryRootCustomerPaymentMethodQueryBuilder Instrument(Action<CustomerPaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrument>("instrument");
            var unionBuilder = new CustomerPaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}