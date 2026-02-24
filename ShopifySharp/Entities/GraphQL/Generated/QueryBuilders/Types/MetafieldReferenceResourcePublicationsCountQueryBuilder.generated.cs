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
    public sealed class MetafieldReferenceResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferenceResourcePublicationsCountQueryBuilder>, IHasArguments<MetafieldReferenceResourcePublicationsCountArgumentsBuilder>
    {
        public MetafieldReferenceResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceResourcePublicationsCountQueryBuilder Self => this;

        public MetafieldReferenceResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferenceResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferenceResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceResourcePublicationsCountQueryBuilder SetArguments(Action<MetafieldReferenceResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferenceResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}