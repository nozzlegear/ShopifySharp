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
    public sealed class CashManagementReasonCodeDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeDeletePayload, CashManagementReasonCodeDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CashManagementReasonCodeDeletePayload>, IHasArguments<CashManagementReasonCodeDeleteArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CashManagementReasonCodeDeleteArgumentsBuilder Arguments { get; }
        protected override CashManagementReasonCodeDeleteOperationQueryBuilder Self => this;

        public CashManagementReasonCodeDeleteOperationQueryBuilder() : this("cashManagementReasonCodeDelete")
        {
        }

        public CashManagementReasonCodeDeleteOperationQueryBuilder(string name) : base(new Query<CashManagementReasonCodeDeletePayload>(name))
        {
            Arguments = new CashManagementReasonCodeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeDeleteOperationQueryBuilder(IQuery<CashManagementReasonCodeDeletePayload> query) : base(query)
        {
            Arguments = new CashManagementReasonCodeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeDeleteOperationQueryBuilder SetArguments(Action<CashManagementReasonCodeDeleteArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementReasonCodeDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CashManagementReasonCodeDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CashManagementReasonCodeDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashManagementReasonCodeDeleteUserError>(query);
            return this;
        }
    }
}