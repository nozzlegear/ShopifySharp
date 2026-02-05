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
    public sealed class CustomerPaymentInstrumentQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentInstrument, CustomerPaymentInstrumentQueryBuilder>
    {
        protected override CustomerPaymentInstrumentQueryBuilder Self => this;

        public CustomerPaymentInstrumentQueryBuilder() : this("customerPaymentInstrument")
        {
        }

        public CustomerPaymentInstrumentQueryBuilder(string name) : base(new Query<CustomerPaymentInstrument>(name))
        {
        }

        public CustomerPaymentInstrumentQueryBuilder(IQuery<CustomerPaymentInstrument> query) : base(query)
        {
        }

        public CustomerPaymentInstrumentQueryBuilder CustomerPaymentInstrument(Action<CustomerPaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrument>("customerPaymentInstrument");
            var unionBuilder = new CustomerPaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}