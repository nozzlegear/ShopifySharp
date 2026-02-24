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
    public sealed class QueryRootOrderPaymentStatusQueryBuilder : FieldsQueryBuilderBase<OrderPaymentStatus, QueryRootOrderPaymentStatusQueryBuilder>, IHasArguments<QueryRootOrderPaymentStatusArgumentsBuilder>
    {
        public QueryRootOrderPaymentStatusArgumentsBuilder Arguments { get; }
        protected override QueryRootOrderPaymentStatusQueryBuilder Self => this;

        public QueryRootOrderPaymentStatusQueryBuilder(string name) : base(new Query<OrderPaymentStatus>(name))
        {
            Arguments = new QueryRootOrderPaymentStatusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderPaymentStatusQueryBuilder(IQuery<OrderPaymentStatus> query) : base(query)
        {
            Arguments = new QueryRootOrderPaymentStatusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderPaymentStatusQueryBuilder SetArguments(Action<QueryRootOrderPaymentStatusArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootOrderPaymentStatusQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public QueryRootOrderPaymentStatusQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public QueryRootOrderPaymentStatusQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootOrderPaymentStatusQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public QueryRootOrderPaymentStatusQueryBuilder TranslatedErrorMessage()
        {
            base.InnerQuery.AddField("translatedErrorMessage");
            return this;
        }
    }
}