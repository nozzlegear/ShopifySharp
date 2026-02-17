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
    public sealed class UserErrorQueryBuilder : FieldsQueryBuilderBase<UserError, UserErrorQueryBuilder>
    {
        protected override UserErrorQueryBuilder Self => this;

        public UserErrorQueryBuilder() : this("userError")
        {
        }

        public UserErrorQueryBuilder(string name) : base(new Query<UserError>(name))
        {
        }

        public UserErrorQueryBuilder(IQuery<UserError> query) : base(query)
        {
        }

        public UserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public UserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}