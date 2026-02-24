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
    public sealed class TranslatableResourceTranslatableContentQueryBuilder : FieldsQueryBuilderBase<TranslatableContent, TranslatableResourceTranslatableContentQueryBuilder>, IHasArguments<TranslatableResourceTranslatableContentArgumentsBuilder>
    {
        public TranslatableResourceTranslatableContentArgumentsBuilder Arguments { get; }
        protected override TranslatableResourceTranslatableContentQueryBuilder Self => this;

        public TranslatableResourceTranslatableContentQueryBuilder(string name) : base(new Query<TranslatableContent>(name))
        {
            Arguments = new TranslatableResourceTranslatableContentArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceTranslatableContentQueryBuilder(IQuery<TranslatableContent> query) : base(query)
        {
            Arguments = new TranslatableResourceTranslatableContentArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceTranslatableContentQueryBuilder SetArguments(Action<TranslatableResourceTranslatableContentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public TranslatableResourceTranslatableContentQueryBuilder Digest()
        {
            base.InnerQuery.AddField("digest");
            return this;
        }

        public TranslatableResourceTranslatableContentQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public TranslatableResourceTranslatableContentQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public TranslatableResourceTranslatableContentQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public TranslatableResourceTranslatableContentQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}