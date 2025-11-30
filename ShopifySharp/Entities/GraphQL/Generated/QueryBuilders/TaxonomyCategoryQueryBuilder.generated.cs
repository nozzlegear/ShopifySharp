#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TaxonomyCategoryQueryBuilder() : GraphQueryBuilder<TaxonomyCategory>("taxonomyCategory")
{
    public TaxonomyCategoryQueryBuilder AddFieldAncestorIds()
    {
        AddField("ancestorIds");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldAttributes(Func<TaxonomyCategoryAttributeConnectionQueryBuilder, TaxonomyCategoryAttributeConnectionQueryBuilder> build)
    {
        AddField<TaxonomyCategoryAttributeConnection, TaxonomyCategoryAttributeConnectionQueryBuilder>("attributes", build);
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldChildrenIds()
    {
        AddField("childrenIds");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldFullName()
    {
        AddField("fullName");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldIsArchived()
    {
        AddField("isArchived");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldIsLeaf()
    {
        AddField("isLeaf");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldIsRoot()
    {
        AddField("isRoot");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldLevel()
    {
        AddField("level");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public TaxonomyCategoryQueryBuilder AddFieldParentId()
    {
        AddField("parentId");
        return this;
    }
}