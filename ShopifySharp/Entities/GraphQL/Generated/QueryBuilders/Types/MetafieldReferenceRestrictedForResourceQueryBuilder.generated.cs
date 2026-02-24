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
    public sealed class MetafieldReferenceRestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, MetafieldReferenceRestrictedForResourceQueryBuilder>, IHasArguments<MetafieldReferenceRestrictedForResourceArgumentsBuilder>
    {
        public MetafieldReferenceRestrictedForResourceArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceRestrictedForResourceQueryBuilder Self => this;

        public MetafieldReferenceRestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
            Arguments = new MetafieldReferenceRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceRestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
            Arguments = new MetafieldReferenceRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceRestrictedForResourceQueryBuilder SetArguments(Action<MetafieldReferenceRestrictedForResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceRestrictedForResourceQueryBuilder Restricted()
        {
            base.InnerQuery.AddField("restricted");
            return this;
        }

        public MetafieldReferenceRestrictedForResourceQueryBuilder RestrictedReason()
        {
            base.InnerQuery.AddField("restrictedReason");
            return this;
        }
    }
}