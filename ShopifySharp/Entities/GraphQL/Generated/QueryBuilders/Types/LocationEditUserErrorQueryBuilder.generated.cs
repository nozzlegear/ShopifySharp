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
    public sealed class LocationEditUserErrorQueryBuilder : FieldsQueryBuilderBase<LocationEditUserError, LocationEditUserErrorQueryBuilder>
    {
        protected override LocationEditUserErrorQueryBuilder Self => this;

        public LocationEditUserErrorQueryBuilder() : this("locationEditUserError")
        {
        }

        public LocationEditUserErrorQueryBuilder(string name) : base(new Query<LocationEditUserError>(name))
        {
        }

        public LocationEditUserErrorQueryBuilder(IQuery<LocationEditUserError> query) : base(query)
        {
        }

        public LocationEditUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public LocationEditUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public LocationEditUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}