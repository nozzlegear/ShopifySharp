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
    public sealed class CashManagementCustomReasonCodeQueryBuilder : FieldsQueryBuilderBase<CashManagementCustomReasonCode, CashManagementCustomReasonCodeQueryBuilder>
    {
        protected override CashManagementCustomReasonCodeQueryBuilder Self => this;

        public CashManagementCustomReasonCodeQueryBuilder() : this("cashManagementCustomReasonCode")
        {
        }

        public CashManagementCustomReasonCodeQueryBuilder(string name) : base(new Query<CashManagementCustomReasonCode>(name))
        {
        }

        public CashManagementCustomReasonCodeQueryBuilder(IQuery<CashManagementCustomReasonCode> query) : base(query)
        {
        }

        public CashManagementCustomReasonCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashManagementCustomReasonCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}