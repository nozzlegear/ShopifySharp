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
    public sealed class MetafieldReferenceCommentsCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferenceCommentsCountQueryBuilder>, IHasArguments<MetafieldReferenceCommentsCountArgumentsBuilder>
    {
        public MetafieldReferenceCommentsCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceCommentsCountQueryBuilder Self => this;

        public MetafieldReferenceCommentsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferenceCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceCommentsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferenceCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceCommentsCountQueryBuilder SetArguments(Action<MetafieldReferenceCommentsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceCommentsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferenceCommentsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}