#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class TaxonomyCategoryQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategory, TaxonomyCategoryQueryBuilder>
    {
        protected override TaxonomyCategoryQueryBuilder Self => this;

        public TaxonomyCategoryQueryBuilder() : this("taxonomyCategory")
        {
        }

        public TaxonomyCategoryQueryBuilder(string name) : base(new Query<TaxonomyCategory>(name))
        {
        }

        public TaxonomyCategoryQueryBuilder(IQuery<TaxonomyCategory> query) : base(query)
        {
        }

        public TaxonomyCategoryQueryBuilder AncestorIds()
        {
            base.InnerQuery.AddField("ancestorIds");
            return this;
        }

        public TaxonomyCategoryQueryBuilder Attributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryAttributeConnectionQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttributeConnection>("attributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryAttributeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryAttributeConnection>(query);
            return this;
        }

        public TaxonomyCategoryQueryBuilder ChildrenIds()
        {
            base.InnerQuery.AddField("childrenIds");
            return this;
        }

        public TaxonomyCategoryQueryBuilder FullName()
        {
            base.InnerQuery.AddField("fullName");
            return this;
        }

        public TaxonomyCategoryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TaxonomyCategoryQueryBuilder IsArchived()
        {
            base.InnerQuery.AddField("isArchived");
            return this;
        }

        public TaxonomyCategoryQueryBuilder IsLeaf()
        {
            base.InnerQuery.AddField("isLeaf");
            return this;
        }

        public TaxonomyCategoryQueryBuilder IsRoot()
        {
            base.InnerQuery.AddField("isRoot");
            return this;
        }

        public TaxonomyCategoryQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        public TaxonomyCategoryQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public TaxonomyCategoryQueryBuilder ParentId()
        {
            base.InnerQuery.AddField("parentId");
            return this;
        }
    }
}