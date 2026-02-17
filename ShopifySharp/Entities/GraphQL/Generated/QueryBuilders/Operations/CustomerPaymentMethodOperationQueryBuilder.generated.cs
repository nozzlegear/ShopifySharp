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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerPaymentMethodOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethod, CustomerPaymentMethodOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethod>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerPaymentMethodArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodOperationQueryBuilder Self => this;

        public CustomerPaymentMethodOperationQueryBuilder() : this("customerPaymentMethod")
        {
        }

        public CustomerPaymentMethodOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethod>(name))
        {
            Arguments = new CustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodOperationQueryBuilder(IQuery<CustomerPaymentMethod> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder Mandates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResourceConnection>("mandates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResourceConnection>(query);
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder RevokedAt()
        {
            base.InnerQuery.AddField("revokedAt");
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder RevokedReason()
        {
            base.InnerQuery.AddField("revokedReason");
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public CustomerPaymentMethodOperationQueryBuilder Instrument(Action<CustomerPaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrument>("instrument");
            var unionBuilder = new CustomerPaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}