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
    public sealed class LocationActivateUserErrorQueryBuilder : FieldsQueryBuilderBase<LocationActivateUserError, LocationActivateUserErrorQueryBuilder>
    {
        protected override LocationActivateUserErrorQueryBuilder Self => this;

        public LocationActivateUserErrorQueryBuilder() : this("locationActivateUserError")
        {
        }

        public LocationActivateUserErrorQueryBuilder(string name) : base(new Query<LocationActivateUserError>(name))
        {
        }

        public LocationActivateUserErrorQueryBuilder(IQuery<LocationActivateUserError> query) : base(query)
        {
        }

        public LocationActivateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public LocationActivateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public LocationActivateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}