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
    public sealed class CashManagementReasonCodeConnectionQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeConnection, CashManagementReasonCodeConnectionQueryBuilder>, IHasArguments<CashManagementReasonCodeConnectionArgumentsBuilder>
    {
        public CashManagementReasonCodeConnectionArgumentsBuilder Arguments { get; }
        protected override CashManagementReasonCodeConnectionQueryBuilder Self => this;

        public CashManagementReasonCodeConnectionQueryBuilder() : this("cashManagementReasonCodeConnection")
        {
        }

        public CashManagementReasonCodeConnectionQueryBuilder(string name) : base(new Query<CashManagementReasonCodeConnection>(name))
        {
            Arguments = new CashManagementReasonCodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeConnectionQueryBuilder(IQuery<CashManagementReasonCodeConnection> query) : base(query)
        {
            Arguments = new CashManagementReasonCodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementReasonCodeConnectionQueryBuilder SetArguments(Action<CashManagementReasonCodeConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementReasonCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeEdgeQueryBuilder> build)
        {
            var query = new Query<CashManagementReasonCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementReasonCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashManagementReasonCodeEdge>(query);
            return this;
        }

        public CashManagementReasonCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public CashManagementReasonCodeConnectionQueryBuilder Nodes(Action<CashManagementReasonCodeUnionCasesBuilder> build)
        {
            var query = new Query<CashManagementReasonCode>("nodes");
            var unionBuilder = new CashManagementReasonCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}