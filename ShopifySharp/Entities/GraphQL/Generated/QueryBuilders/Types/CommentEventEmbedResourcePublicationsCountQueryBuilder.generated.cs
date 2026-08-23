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
    public sealed class CommentEventEmbedResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, CommentEventEmbedResourcePublicationsCountQueryBuilder>, IHasArguments<CommentEventEmbedResourcePublicationsCountArgumentsBuilder>
    {
        public CommentEventEmbedResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedResourcePublicationsCountQueryBuilder Self => this;

        public CommentEventEmbedResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CommentEventEmbedResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CommentEventEmbedResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedResourcePublicationsCountQueryBuilder SetArguments(Action<CommentEventEmbedResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CommentEventEmbedResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}