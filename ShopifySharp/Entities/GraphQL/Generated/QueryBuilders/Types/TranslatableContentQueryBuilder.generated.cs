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
    public sealed class TranslatableContentQueryBuilder : FieldsQueryBuilderBase<TranslatableContent, TranslatableContentQueryBuilder>
    {
        protected override TranslatableContentQueryBuilder Self => this;

        public TranslatableContentQueryBuilder() : this("translatableContent")
        {
        }

        public TranslatableContentQueryBuilder(string name) : base(new Query<TranslatableContent>(name))
        {
        }

        public TranslatableContentQueryBuilder(IQuery<TranslatableContent> query) : base(query)
        {
        }

        public TranslatableContentQueryBuilder Digest()
        {
            base.InnerQuery.AddField("digest");
            return this;
        }

        public TranslatableContentQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public TranslatableContentQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public TranslatableContentQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public TranslatableContentQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}