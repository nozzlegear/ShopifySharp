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
    public sealed class QueryRootCheckoutProfileQueryBuilder : FieldsQueryBuilderBase<CheckoutProfile, QueryRootCheckoutProfileQueryBuilder>, IHasArguments<QueryRootCheckoutProfileArgumentsBuilder>
    {
        public QueryRootCheckoutProfileArgumentsBuilder Arguments { get; }
        protected override QueryRootCheckoutProfileQueryBuilder Self => this;

        public QueryRootCheckoutProfileQueryBuilder(string name) : base(new Query<CheckoutProfile>(name))
        {
            Arguments = new QueryRootCheckoutProfileArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutProfileQueryBuilder(IQuery<CheckoutProfile> query) : base(query)
        {
            Arguments = new QueryRootCheckoutProfileArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutProfileQueryBuilder SetArguments(Action<QueryRootCheckoutProfileArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder TypOspPagesActive()
        {
            base.InnerQuery.AddField("typOspPagesActive");
            return this;
        }

        public QueryRootCheckoutProfileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}