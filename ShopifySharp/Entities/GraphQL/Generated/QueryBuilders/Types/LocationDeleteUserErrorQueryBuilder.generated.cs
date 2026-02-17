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
    public sealed class LocationDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<LocationDeleteUserError, LocationDeleteUserErrorQueryBuilder>
    {
        protected override LocationDeleteUserErrorQueryBuilder Self => this;

        public LocationDeleteUserErrorQueryBuilder() : this("locationDeleteUserError")
        {
        }

        public LocationDeleteUserErrorQueryBuilder(string name) : base(new Query<LocationDeleteUserError>(name))
        {
        }

        public LocationDeleteUserErrorQueryBuilder(IQuery<LocationDeleteUserError> query) : base(query)
        {
        }

        public LocationDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public LocationDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public LocationDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}