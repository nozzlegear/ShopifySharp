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
    public sealed class ChannelProductsCountQueryBuilder : FieldsQueryBuilderBase<Count, ChannelProductsCountQueryBuilder>, IHasArguments<ChannelProductsCountArgumentsBuilder>
    {
        public ChannelProductsCountArgumentsBuilder Arguments { get; }
        protected override ChannelProductsCountQueryBuilder Self => this;

        public ChannelProductsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ChannelProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public ChannelProductsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ChannelProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public ChannelProductsCountQueryBuilder SetArguments(Action<ChannelProductsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelProductsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ChannelProductsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}