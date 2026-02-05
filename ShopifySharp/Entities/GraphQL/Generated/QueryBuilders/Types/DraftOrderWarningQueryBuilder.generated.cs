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
    public sealed class DraftOrderWarningQueryBuilder : FieldsQueryBuilderBase<IDraftOrderWarning, DraftOrderWarningQueryBuilder>
    {
        protected override DraftOrderWarningQueryBuilder Self => this;

        public DraftOrderWarningQueryBuilder() : this("draftOrderWarning")
        {
        }

        public DraftOrderWarningQueryBuilder(string name) : base(new Query<IDraftOrderWarning>(name))
        {
        }

        public DraftOrderWarningQueryBuilder(IQuery<IDraftOrderWarning> query) : base(query)
        {
        }

        public DraftOrderWarningQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public DraftOrderWarningQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DraftOrderWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}