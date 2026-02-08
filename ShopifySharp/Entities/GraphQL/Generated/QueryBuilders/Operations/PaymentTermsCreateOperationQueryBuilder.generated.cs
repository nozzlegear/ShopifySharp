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
    public sealed class PaymentTermsCreateOperationQueryBuilder : FieldsQueryBuilderBase<PaymentTermsCreatePayload, PaymentTermsCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentTermsCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentTermsCreateArgumentsBuilder Arguments { get; }
        protected override PaymentTermsCreateOperationQueryBuilder Self => this;

        public PaymentTermsCreateOperationQueryBuilder() : this("paymentTermsCreate")
        {
        }

        public PaymentTermsCreateOperationQueryBuilder(string name) : base(new Query<PaymentTermsCreatePayload>(name))
        {
            Arguments = new PaymentTermsCreateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsCreateOperationQueryBuilder(IQuery<PaymentTermsCreatePayload> query) : base(query)
        {
            Arguments = new PaymentTermsCreateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsCreateOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsCreateUserError>(query);
            return this;
        }
    }
}