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
    public sealed class AbandonedCheckoutLineItemComponentQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItemComponent, AbandonedCheckoutLineItemComponentQueryBuilder>
    {
        protected override AbandonedCheckoutLineItemComponentQueryBuilder Self => this;

        public AbandonedCheckoutLineItemComponentQueryBuilder() : this("abandonedCheckoutLineItemComponent")
        {
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItemComponent>(name))
        {
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder(IQuery<AbandonedCheckoutLineItemComponent> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AbandonedCheckoutLineItemComponentQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }
    }
}