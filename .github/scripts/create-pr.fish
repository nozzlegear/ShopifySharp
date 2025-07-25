#!/usr/bin/env fish

# Create a pull request with generated GraphQL types
# Requires GITHUB_TOKEN environment variable

set branch_name "graphql-types-update-$(date +%Y%m%d-%H%M%S)"

echo "Creating branch: $branch_name"

git config --local user.email "action@github.com"
git config --local user.name "GitHub Action"
git switch -C "$branch_name"
git add ShopifySharp/Entities/GraphQL/Generated/

if git diff --staged --quiet
    echo "No changes to commit"
    exit 0
end

git commit -m "Update generated GraphQL types

🤖 Generated with GitHub Actions"

git push origin "$branch_name"

gh pr create \
    --title "Update Generated GraphQL Types" \
    --body "## Summary
- Updated GraphQL types generated from schema
- Cleaned output directory before generation
- Generated types using ShopifySharp.GraphQL.Parser.CLI

## Test plan
- [ ] Verify generated types compile successfully
- [ ] Run unit tests to ensure no breaking changes
- [ ] Check that removed types are properly cleaned up

🤖 Generated with GitHub Actions" \
    --base master \
    --head "$branch_name"