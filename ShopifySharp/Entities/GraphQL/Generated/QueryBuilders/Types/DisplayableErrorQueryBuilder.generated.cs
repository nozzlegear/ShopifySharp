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
    public sealed class DisplayableErrorQueryBuilder : FieldsQueryBuilderBase<IDisplayableError, DisplayableErrorQueryBuilder>
    {
        protected override DisplayableErrorQueryBuilder Self => this;

        public DisplayableErrorQueryBuilder() : this("displayableError")
        {
        }

        public DisplayableErrorQueryBuilder(string name) : base(new Query<IDisplayableError>(name))
        {
        }

        public DisplayableErrorQueryBuilder(IQuery<IDisplayableError> query) : base(query)
        {
        }

        public DisplayableErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DisplayableErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}