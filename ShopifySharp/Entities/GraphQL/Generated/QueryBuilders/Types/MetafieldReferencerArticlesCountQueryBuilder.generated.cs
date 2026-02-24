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
    public sealed class MetafieldReferencerArticlesCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferencerArticlesCountQueryBuilder>, IHasArguments<MetafieldReferencerArticlesCountArgumentsBuilder>
    {
        public MetafieldReferencerArticlesCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerArticlesCountQueryBuilder Self => this;

        public MetafieldReferencerArticlesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferencerArticlesCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerArticlesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferencerArticlesCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerArticlesCountQueryBuilder SetArguments(Action<MetafieldReferencerArticlesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerArticlesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferencerArticlesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}