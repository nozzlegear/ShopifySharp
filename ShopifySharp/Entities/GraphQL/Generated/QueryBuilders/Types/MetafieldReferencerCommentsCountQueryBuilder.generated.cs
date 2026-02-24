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
    public sealed class MetafieldReferencerCommentsCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferencerCommentsCountQueryBuilder>, IHasArguments<MetafieldReferencerCommentsCountArgumentsBuilder>
    {
        public MetafieldReferencerCommentsCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerCommentsCountQueryBuilder Self => this;

        public MetafieldReferencerCommentsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferencerCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCommentsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferencerCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCommentsCountQueryBuilder SetArguments(Action<MetafieldReferencerCommentsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerCommentsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferencerCommentsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}