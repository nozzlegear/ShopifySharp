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
    public sealed class PaymentTermsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PaymentTermsDeletePayload, PaymentTermsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentTermsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentTermsDeleteArgumentsBuilder Arguments { get; }
        protected override PaymentTermsDeleteOperationQueryBuilder Self => this;

        public PaymentTermsDeleteOperationQueryBuilder() : this("paymentTermsDelete")
        {
        }

        public PaymentTermsDeleteOperationQueryBuilder(string name) : base(new Query<PaymentTermsDeletePayload>(name))
        {
            Arguments = new PaymentTermsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsDeleteOperationQueryBuilder(IQuery<PaymentTermsDeletePayload> query) : base(query)
        {
            Arguments = new PaymentTermsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PaymentTermsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsDeleteUserError>(query);
            return this;
        }
    }
}