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
    public sealed class LocationAddUserErrorQueryBuilder : FieldsQueryBuilderBase<LocationAddUserError, LocationAddUserErrorQueryBuilder>
    {
        protected override LocationAddUserErrorQueryBuilder Self => this;

        public LocationAddUserErrorQueryBuilder() : this("locationAddUserError")
        {
        }

        public LocationAddUserErrorQueryBuilder(string name) : base(new Query<LocationAddUserError>(name))
        {
        }

        public LocationAddUserErrorQueryBuilder(IQuery<LocationAddUserError> query) : base(query)
        {
        }

        public LocationAddUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public LocationAddUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public LocationAddUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}