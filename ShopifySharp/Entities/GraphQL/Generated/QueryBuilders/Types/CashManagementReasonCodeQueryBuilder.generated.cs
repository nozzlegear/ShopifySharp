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
    public sealed class CashManagementReasonCodeQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCode, CashManagementReasonCodeQueryBuilder>
    {
        protected override CashManagementReasonCodeQueryBuilder Self => this;

        public CashManagementReasonCodeQueryBuilder() : this("cashManagementReasonCode")
        {
        }

        public CashManagementReasonCodeQueryBuilder(string name) : base(new Query<CashManagementReasonCode>(name))
        {
        }

        public CashManagementReasonCodeQueryBuilder(IQuery<CashManagementReasonCode> query) : base(query)
        {
        }

        public CashManagementReasonCodeQueryBuilder CashManagementReasonCode(Action<CashManagementReasonCodeUnionCasesBuilder> build)
        {
            var query = new Query<CashManagementReasonCode>("cashManagementReasonCode");
            var unionBuilder = new CashManagementReasonCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}