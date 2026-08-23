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
    public sealed class CashManagementReasonCodeDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeDeleteUserError, CashManagementReasonCodeDeleteUserErrorQueryBuilder>
    {
        protected override CashManagementReasonCodeDeleteUserErrorQueryBuilder Self => this;

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder() : this("cashManagementReasonCodeDeleteUserError")
        {
        }

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder(string name) : base(new Query<CashManagementReasonCodeDeleteUserError>(name))
        {
        }

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder(IQuery<CashManagementReasonCodeDeleteUserError> query) : base(query)
        {
        }

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CashManagementReasonCodeDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}