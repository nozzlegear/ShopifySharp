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
    public sealed class CashManagementSystemReasonCodeQueryBuilder : FieldsQueryBuilderBase<CashManagementSystemReasonCode, CashManagementSystemReasonCodeQueryBuilder>
    {
        protected override CashManagementSystemReasonCodeQueryBuilder Self => this;

        public CashManagementSystemReasonCodeQueryBuilder() : this("cashManagementSystemReasonCode")
        {
        }

        public CashManagementSystemReasonCodeQueryBuilder(string name) : base(new Query<CashManagementSystemReasonCode>(name))
        {
        }

        public CashManagementSystemReasonCodeQueryBuilder(IQuery<CashManagementSystemReasonCode> query) : base(query)
        {
        }

        public CashManagementSystemReasonCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashManagementSystemReasonCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}