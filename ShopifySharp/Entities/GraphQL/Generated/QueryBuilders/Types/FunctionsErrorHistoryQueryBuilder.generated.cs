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
    public sealed class FunctionsErrorHistoryQueryBuilder : FieldsQueryBuilderBase<FunctionsErrorHistory, FunctionsErrorHistoryQueryBuilder>
    {
        protected override FunctionsErrorHistoryQueryBuilder Self => this;

        public FunctionsErrorHistoryQueryBuilder() : this("functionsErrorHistory")
        {
        }

        public FunctionsErrorHistoryQueryBuilder(string name) : base(new Query<FunctionsErrorHistory>(name))
        {
        }

        public FunctionsErrorHistoryQueryBuilder(IQuery<FunctionsErrorHistory> query) : base(query)
        {
        }

        public FunctionsErrorHistoryQueryBuilder ErrorsFirstOccurredAt()
        {
            base.InnerQuery.AddField("errorsFirstOccurredAt");
            return this;
        }

        public FunctionsErrorHistoryQueryBuilder FirstOccurredAt()
        {
            base.InnerQuery.AddField("firstOccurredAt");
            return this;
        }

        public FunctionsErrorHistoryQueryBuilder HasBeenSharedSinceLastError()
        {
            base.InnerQuery.AddField("hasBeenSharedSinceLastError");
            return this;
        }

        public FunctionsErrorHistoryQueryBuilder HasSharedRecentErrors()
        {
            base.InnerQuery.AddField("hasSharedRecentErrors");
            return this;
        }
    }
}