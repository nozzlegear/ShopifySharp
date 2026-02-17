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
    public sealed class LocationDeactivateUserErrorQueryBuilder : FieldsQueryBuilderBase<LocationDeactivateUserError, LocationDeactivateUserErrorQueryBuilder>
    {
        protected override LocationDeactivateUserErrorQueryBuilder Self => this;

        public LocationDeactivateUserErrorQueryBuilder() : this("locationDeactivateUserError")
        {
        }

        public LocationDeactivateUserErrorQueryBuilder(string name) : base(new Query<LocationDeactivateUserError>(name))
        {
        }

        public LocationDeactivateUserErrorQueryBuilder(IQuery<LocationDeactivateUserError> query) : base(query)
        {
        }

        public LocationDeactivateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public LocationDeactivateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public LocationDeactivateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}