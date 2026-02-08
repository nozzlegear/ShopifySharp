#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DraftOrderBundleAddedWarningQueryBuilder : FieldsQueryBuilderBase<DraftOrderBundleAddedWarning, DraftOrderBundleAddedWarningQueryBuilder>
    {
        protected override DraftOrderBundleAddedWarningQueryBuilder Self => this;

        public DraftOrderBundleAddedWarningQueryBuilder() : this("draftOrderBundleAddedWarning")
        {
        }

        public DraftOrderBundleAddedWarningQueryBuilder(string name) : base(new Query<DraftOrderBundleAddedWarning>(name))
        {
        }

        public DraftOrderBundleAddedWarningQueryBuilder(IQuery<DraftOrderBundleAddedWarning> query) : base(query)
        {
        }

        public DraftOrderBundleAddedWarningQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public DraftOrderBundleAddedWarningQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DraftOrderBundleAddedWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}