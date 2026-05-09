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
    public sealed class CashManagementReasonCodesOperationQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeConnection, CashManagementReasonCodesOperationQueryBuilder>, IGraphOperationQueryBuilder<CashManagementReasonCodeConnection>, IHasArguments<CashManagementReasonCodesArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashManagementReasonCodesArgumentsBuilder Arguments { get; }
        protected override CashManagementReasonCodesOperationQueryBuilder Self => this;

        public CashManagementReasonCodesOperationQueryBuilder() : this("cashManagementReasonCodes")
        {
        }

        public CashManagementReasonCodesOperationQueryBuilder(string name) : base(new Query<CashManagementReasonCodeConnection>(name))
        {
            Arguments = new CashManagementReasonCodesArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodesOperationQueryBuilder(IQuery<CashManagementReasonCodeConnection> query) : base(query)
        {
            Arguments = new CashManagementReasonCodesArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodesOperationQueryBuilder SetArguments(Action<CashManagementReasonCodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementReasonCodesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeEdgeQueryBuilder> build)
        {
            var query = new Query<CashManagementReasonCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashManagementReasonCodeEdge>(query);
            return this;
        }

        public CashManagementReasonCodesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public CashManagementReasonCodesOperationQueryBuilder Nodes(Action<CashManagementReasonCodeUnionCasesBuilder> build)
        {
            var query = new Query<CashManagementReasonCode>("nodes");
            var unionBuilder = new CashManagementReasonCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}