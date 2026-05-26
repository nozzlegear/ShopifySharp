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
    public sealed class CashManagementReasonCodeCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeCreateUserError, CashManagementReasonCodeCreateUserErrorQueryBuilder>
    {
        protected override CashManagementReasonCodeCreateUserErrorQueryBuilder Self => this;

        public CashManagementReasonCodeCreateUserErrorQueryBuilder() : this("cashManagementReasonCodeCreateUserError")
        {
        }

        public CashManagementReasonCodeCreateUserErrorQueryBuilder(string name) : base(new Query<CashManagementReasonCodeCreateUserError>(name))
        {
        }

        public CashManagementReasonCodeCreateUserErrorQueryBuilder(IQuery<CashManagementReasonCodeCreateUserError> query) : base(query)
        {
        }

        public CashManagementReasonCodeCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashManagementReasonCodeCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CashManagementReasonCodeCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}