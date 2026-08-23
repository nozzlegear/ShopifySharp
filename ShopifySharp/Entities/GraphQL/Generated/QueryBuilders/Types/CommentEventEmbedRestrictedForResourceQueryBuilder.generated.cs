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
    public sealed class CommentEventEmbedRestrictedForResourceQueryBuilder : FieldsQueryBuilderBase<RestrictedForResource, CommentEventEmbedRestrictedForResourceQueryBuilder>, IHasArguments<CommentEventEmbedRestrictedForResourceArgumentsBuilder>
    {
        public CommentEventEmbedRestrictedForResourceArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedRestrictedForResourceQueryBuilder Self => this;

        public CommentEventEmbedRestrictedForResourceQueryBuilder(string name) : base(new Query<RestrictedForResource>(name))
        {
            Arguments = new CommentEventEmbedRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRestrictedForResourceQueryBuilder(IQuery<RestrictedForResource> query) : base(query)
        {
            Arguments = new CommentEventEmbedRestrictedForResourceArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRestrictedForResourceQueryBuilder SetArguments(Action<CommentEventEmbedRestrictedForResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedRestrictedForResourceQueryBuilder Restricted()
        {
            base.InnerQuery.AddField("restricted");
            return this;
        }

        public CommentEventEmbedRestrictedForResourceQueryBuilder RestrictedReason()
        {
            base.InnerQuery.AddField("restrictedReason");
            return this;
        }
    }
}