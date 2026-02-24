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
    public sealed class MetafieldReferencerRestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, MetafieldReferencerRestrictedForResourceQueryBuilder>, IHasArguments<MetafieldReferencerRestrictedForResourceArgumentsBuilder>
    {
        public MetafieldReferencerRestrictedForResourceArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerRestrictedForResourceQueryBuilder Self => this;

        public MetafieldReferencerRestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
            Arguments = new MetafieldReferencerRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
            Arguments = new MetafieldReferencerRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRestrictedForResourceQueryBuilder SetArguments(Action<MetafieldReferencerRestrictedForResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerRestrictedForResourceQueryBuilder Restricted()
        {
            base.InnerQuery.AddField("restricted");
            return this;
        }

        public MetafieldReferencerRestrictedForResourceQueryBuilder RestrictedReason()
        {
            base.InnerQuery.AddField("restrictedReason");
            return this;
        }
    }
}