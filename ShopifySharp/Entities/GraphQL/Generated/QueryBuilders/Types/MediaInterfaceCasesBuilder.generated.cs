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
    public sealed class MediaInterfaceCasesBuilder : InterfaceCasesBuilderBase<IMedia, MediaInterfaceCasesBuilder>
    {
        protected override MediaInterfaceCasesBuilder Self => this;

        public MediaInterfaceCasesBuilder(string fieldName = "featuredMedia") : this(new Query<IMedia>(fieldName))
        {
        }

        public MediaInterfaceCasesBuilder(IQuery<IMedia> query) : base(query)
        {
        }

        public MediaInterfaceCasesBuilder OnExternalVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder> build)
        {
            var query = new Query<ExternalVideo>("... on ExternalVideo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MediaInterfaceCasesBuilder OnMediaImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MediaInterfaceCasesBuilder OnModel3d(Action<ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder> build)
        {
            var query = new Query<Model3d>("... on Model3d");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MediaInterfaceCasesBuilder OnVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder> build)
        {
            var query = new Query<Video>("... on Video");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}