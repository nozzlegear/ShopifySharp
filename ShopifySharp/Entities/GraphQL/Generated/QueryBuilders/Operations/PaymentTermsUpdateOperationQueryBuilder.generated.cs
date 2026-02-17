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
    public sealed class PaymentTermsUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PaymentTermsUpdatePayload, PaymentTermsUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentTermsUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentTermsUpdateArgumentsBuilder Arguments { get; }
        protected override PaymentTermsUpdateOperationQueryBuilder Self => this;

        public PaymentTermsUpdateOperationQueryBuilder() : this("paymentTermsUpdate")
        {
        }

        public PaymentTermsUpdateOperationQueryBuilder(string name) : base(new Query<PaymentTermsUpdatePayload>(name))
        {
            Arguments = new PaymentTermsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsUpdateOperationQueryBuilder(IQuery<PaymentTermsUpdatePayload> query) : base(query)
        {
            Arguments = new PaymentTermsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsUpdateOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsUpdateUserError>(query);
            return this;
        }
    }
}