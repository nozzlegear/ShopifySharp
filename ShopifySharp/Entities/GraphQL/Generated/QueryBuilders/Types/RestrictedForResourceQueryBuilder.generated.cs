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
    public sealed class RestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, RestrictedForResourceQueryBuilder>
    {
        protected override RestrictedForResourceQueryBuilder Self => this;

        public RestrictedForResourceQueryBuilder() : this("restrictedForResource")
        {
        }

        public RestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
        }

        public RestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
        }

        public RestrictedForResourceQueryBuilder Restricted()
        {
            base.InnerQuery.AddField("restricted");
            return this;
        }

        public RestrictedForResourceQueryBuilder RestrictedReason()
        {
            base.InnerQuery.AddField("restrictedReason");
            return this;
        }
    }
}