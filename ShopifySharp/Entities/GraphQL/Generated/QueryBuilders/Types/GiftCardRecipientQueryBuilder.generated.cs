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
    public sealed class GiftCardRecipientQueryBuilder : FieldsQueryBuilderBase<GiftCardRecipient, GiftCardRecipientQueryBuilder>
    {
        protected override GiftCardRecipientQueryBuilder Self => this;

        public GiftCardRecipientQueryBuilder() : this("giftCardRecipient")
        {
        }

        public GiftCardRecipientQueryBuilder(string name) : base(new Query<GiftCardRecipient>(name))
        {
        }

        public GiftCardRecipientQueryBuilder(IQuery<GiftCardRecipient> query) : base(query)
        {
        }

        public GiftCardRecipientQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public GiftCardRecipientQueryBuilder PreferredName()
        {
            base.InnerQuery.AddField("preferredName");
            return this;
        }

        public GiftCardRecipientQueryBuilder Recipient(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("recipient");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public GiftCardRecipientQueryBuilder SendNotificationAt()
        {
            base.InnerQuery.AddField("sendNotificationAt");
            return this;
        }
    }
}