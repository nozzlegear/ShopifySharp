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

        public PaymentTermsUpdateOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsUpdateUserError>(query);
            return this;
        }
    }
}