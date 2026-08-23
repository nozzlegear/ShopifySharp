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
    public sealed class CommentEventEmbedVariantsInCollectionCountQueryBuilder : FieldsQueryBuilderBase<Count, CommentEventEmbedVariantsInCollectionCountQueryBuilder>, IHasArguments<CommentEventEmbedVariantsInCollectionCountArgumentsBuilder>
    {
        public CommentEventEmbedVariantsInCollectionCountArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedVariantsInCollectionCountQueryBuilder Self => this;

        public CommentEventEmbedVariantsInCollectionCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CommentEventEmbedVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedVariantsInCollectionCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CommentEventEmbedVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedVariantsInCollectionCountQueryBuilder SetArguments(Action<CommentEventEmbedVariantsInCollectionCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedVariantsInCollectionCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CommentEventEmbedVariantsInCollectionCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}