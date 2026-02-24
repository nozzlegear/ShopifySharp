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
    public sealed class PublishableResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, PublishableResourcePublicationsCountQueryBuilder>, IHasArguments<PublishableResourcePublicationsCountArgumentsBuilder>
    {
        public PublishableResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override PublishableResourcePublicationsCountQueryBuilder Self => this;

        public PublishableResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new PublishableResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublishableResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new PublishableResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublishableResourcePublicationsCountQueryBuilder SetArguments(Action<PublishableResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublishableResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PublishableResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}