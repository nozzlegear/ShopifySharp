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
    public sealed class CashManagementDefaultReasonCodeQueryBuilder : FieldsQueryBuilderBase<CashManagementDefaultReasonCode, CashManagementDefaultReasonCodeQueryBuilder>
    {
        protected override CashManagementDefaultReasonCodeQueryBuilder Self => this;

        public CashManagementDefaultReasonCodeQueryBuilder() : this("cashManagementDefaultReasonCode")
        {
        }

        public CashManagementDefaultReasonCodeQueryBuilder(string name) : base(new Query<CashManagementDefaultReasonCode>(name))
        {
        }

        public CashManagementDefaultReasonCodeQueryBuilder(IQuery<CashManagementDefaultReasonCode> query) : base(query)
        {
        }

        public CashManagementDefaultReasonCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashManagementDefaultReasonCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}