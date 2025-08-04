#!/usr/bin/env fish

# Parse arguments using argparse
argparse --name='create-pr' 's/schema-file=' -- $argv
or exit 1

# Validate required arguments
if test -z "$_flag_schema_file"
    echo "Error: --schema-file argument is required"
    echo "Usage: $argv[0] --schema-file <path-to-schema-file>"
    exit 1
end

# Validate that schema file exists
if not test -f "$_flag_schema_file"
    echo "Error: Schema file '$_flag_schema_file' does not exist"
    exit 1
end

set branch_name "graphql-types-update-$(date +%Y%m%d-%H%M%S)"

echo "Creating branch: $branch_name"

git config --local user.email "action@github.com"
git config --local user.name "GitHub Action"
git switch -C "$branch_name"
git add ShopifySharp/Entities/GraphQL/Generated/ "$_flag_schema_file"

if git diff --staged --quiet
    echo "No changes to commit"
    exit 0
end

git commit -m "Add/update GraphQL schema and generated GraphQL types

🤖 Generated with GitHub Actions"

git push origin "$branch_name"

gh pr create \
    --title "🤖 Update GraphQL schema and generated types" \
    --body "## Summary
- Added/updated GraphQL schema `$schema_name`
- Cleaned output directory before generation
- Updated GraphQL types generated from schema using ShopifySharp.GraphQL.Parser.CLI

## Test plan
- [ ] Verify generated types compile successfully
- [ ] Run unit tests to ensure no breaking changes
- [ ] Check that removed types are properly cleaned up

🤖 Generated with GitHub Actions" \
    --base master \
    --head "$branch_name"
