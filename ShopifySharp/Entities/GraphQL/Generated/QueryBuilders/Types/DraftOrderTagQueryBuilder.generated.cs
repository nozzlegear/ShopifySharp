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
    public sealed class DraftOrderTagQueryBuilder : FieldsQueryBuilderBase<DraftOrderTag, DraftOrderTagQueryBuilder>
    {
        protected override DraftOrderTagQueryBuilder Self => this;

        public DraftOrderTagQueryBuilder() : this("draftOrderTag")
        {
        }

        public DraftOrderTagQueryBuilder(string name) : base(new Query<DraftOrderTag>(name))
        {
        }

        public DraftOrderTagQueryBuilder(IQuery<DraftOrderTag> query) : base(query)
        {
        }

        public DraftOrderTagQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public DraftOrderTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderTagQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}