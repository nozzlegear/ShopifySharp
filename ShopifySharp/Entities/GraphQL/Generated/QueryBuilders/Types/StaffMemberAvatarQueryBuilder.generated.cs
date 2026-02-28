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
    public sealed class StaffMemberAvatarQueryBuilder : FieldsQueryBuilderBase<Image, StaffMemberAvatarQueryBuilder>, IHasArguments<StaffMemberAvatarArgumentsBuilder>
    {
        public StaffMemberAvatarArgumentsBuilder Arguments { get; }
        protected override StaffMemberAvatarQueryBuilder Self => this;

        public StaffMemberAvatarQueryBuilder(string name) : base(new Query<Image>(name))
        {
            Arguments = new StaffMemberAvatarArgumentsBuilder(base.InnerQuery);
        }

        public StaffMemberAvatarQueryBuilder(IQuery<Image> query) : base(query)
        {
            Arguments = new StaffMemberAvatarArgumentsBuilder(base.InnerQuery);
        }

        public StaffMemberAvatarQueryBuilder SetArguments(Action<StaffMemberAvatarArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public StaffMemberAvatarQueryBuilder AltText()
        {
            base.InnerQuery.AddField("altText");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Height()
        {
            base.InnerQuery.AddField("height");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public StaffMemberAvatarQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public StaffMemberAvatarQueryBuilder OriginalSrc()
        {
            base.InnerQuery.AddField("originalSrc");
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public StaffMemberAvatarQueryBuilder Src()
        {
            base.InnerQuery.AddField("src");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Thumbhash()
        {
            base.InnerQuery.AddField("thumbhash");
            return this;
        }

        [Obsolete("Use `url(transform:)` instead")]
        public StaffMemberAvatarQueryBuilder TransformedSrc()
        {
            base.InnerQuery.AddField("transformedSrc");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public StaffMemberAvatarQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public StaffMemberAvatarQueryBuilder Width()
        {
            base.InnerQuery.AddField("width");
            return this;
        }
    }
}