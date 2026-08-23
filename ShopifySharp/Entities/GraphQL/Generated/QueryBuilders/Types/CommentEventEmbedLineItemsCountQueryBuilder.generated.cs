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
    public sealed class CommentEventEmbedLineItemsCountQueryBuilder : FieldsQueryBuilderBase<Count, CommentEventEmbedLineItemsCountQueryBuilder>, IHasArguments<CommentEventEmbedLineItemsCountArgumentsBuilder>
    {
        public CommentEventEmbedLineItemsCountArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedLineItemsCountQueryBuilder Self => this;

        public CommentEventEmbedLineItemsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CommentEventEmbedLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedLineItemsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CommentEventEmbedLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedLineItemsCountQueryBuilder SetArguments(Action<CommentEventEmbedLineItemsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedLineItemsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CommentEventEmbedLineItemsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}