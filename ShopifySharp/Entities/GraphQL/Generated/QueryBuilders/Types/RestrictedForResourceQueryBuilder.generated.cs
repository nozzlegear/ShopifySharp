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
    public sealed class RestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, RestrictedForResourceQueryBuilder>, IHasArguments<RestrictedForResourceArgumentsBuilder>
    {
        public RestrictedForResourceArgumentsBuilder Arguments { get; }
        protected override RestrictedForResourceQueryBuilder Self => this;

        public RestrictedForResourceQueryBuilder() : this("restrictedForResource")
        {
        }

        public RestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
            Arguments = new RestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public RestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
            Arguments = new RestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public RestrictedForResourceQueryBuilder SetArguments(Action<RestrictedForResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
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