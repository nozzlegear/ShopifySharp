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
    public sealed class CashManagementReasonCodeCreateOperationQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeCreatePayload, CashManagementReasonCodeCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CashManagementReasonCodeCreatePayload>, IHasArguments<CashManagementReasonCodeCreateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CashManagementReasonCodeCreateArgumentsBuilder Arguments { get; }
        protected override CashManagementReasonCodeCreateOperationQueryBuilder Self => this;

        public CashManagementReasonCodeCreateOperationQueryBuilder() : this("cashManagementReasonCodeCreate")
        {
        }

        public CashManagementReasonCodeCreateOperationQueryBuilder(string name) : base(new Query<CashManagementReasonCodeCreatePayload>(name))
        {
            Arguments = new CashManagementReasonCodeCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeCreateOperationQueryBuilder(IQuery<CashManagementReasonCodeCreatePayload> query) : base(query)
        {
            Arguments = new CashManagementReasonCodeCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeCreateOperationQueryBuilder SetArguments(Action<CashManagementReasonCodeCreateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementReasonCodeCreateOperationQueryBuilder ReasonCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementCustomReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementCustomReasonCode>("reasonCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementCustomReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashManagementCustomReasonCode>(query);
            return this;
        }

        public CashManagementReasonCodeCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CashManagementReasonCodeCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashManagementReasonCodeCreateUserError>(query);
            return this;
        }
    }
}