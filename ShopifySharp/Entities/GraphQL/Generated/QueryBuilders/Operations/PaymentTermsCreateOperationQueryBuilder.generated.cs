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

        public PaymentTermsCreateOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsCreateUserError>(query);
            return this;
        }
    }
}