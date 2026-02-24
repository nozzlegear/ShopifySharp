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
    public sealed class ProductRestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, ProductRestrictedForResourceQueryBuilder>, IHasArguments<ProductRestrictedForResourceArgumentsBuilder>
    {
        public ProductRestrictedForResourceArgumentsBuilder Arguments { get; }
        protected override ProductRestrictedForResourceQueryBuilder Self => this;

        public ProductRestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
            Arguments = new ProductRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public ProductRestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
            Arguments = new ProductRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public ProductRestrictedForResourceQueryBuilder SetArguments(Action<ProductRestrictedForResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductRestrictedForResourceQueryBuilder Restricted()
        {
            base.InnerQuery.AddField("restricted");
            return this;
        }

        public ProductRestrictedForResourceQueryBuilder RestrictedReason()
        {
            base.InnerQuery.AddField("restrictedReason");
            return this;
        }
    }
}