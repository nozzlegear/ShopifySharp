import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';
import starlightLinksValidator from 'starlight-links-validator';
export default defineConfig({
  site: 'https://shopifysharp.net',
  server: {
    allowedHosts: ['nozzlegear.ngrok.io', 'shopifysharp.net'],
  },
  output: 'static',
  integrations: [
    starlight({
      plugins: [starlightLinksValidator()],
      title: 'ShopifySharp',
      description: "A .NET library that helps developers easily authenticate with and manage Shopify stores using Shopify's GraphQL and Rest APIs.",
      logo: {
        src: './src/assets/shopifysharp-logo-no-text.svg',
        alt: 'ShopifySharp',
      },
      // Favicon must be in the public/ directory
      favicon: 'favicons/shopifysharp-logo-favicon.svg',
      components: {
        Footer: './src/components/Footer.astro',
      },
      editLink: {
        baseUrl: 'https://github.com/nozzlegear/shopifysharp/edit/master/docs/',
      },
      social: [
          { icon: "github", label: "GitHub", href: 'https://github.com/nozzlegear/shopifysharp' }
      ],
      customCss: [
        './src/styles/fonts.css',
        './src/styles/custom.css',
      ],
      head: [
        {
          tag: 'script',
          attrs: {
            defer: true,
            src: 'https://luminary.high.charity/script.js',
            'data-website-id': 'e5d87224-f49e-4ee3-8caf-be2275393a70',
          },
        },
      ],
      sidebar: [
        {
          label: 'Getting Started',
          items: [
            { label: 'Introduction', slug: 'index' },
            { autogenerate: { "directory": "getting-started" }}
          ],
        },
        {
          label: 'GraphQL API',
          items: [{ autogenerate: { "directory": "graphql" } }]
        },
        {
          label: 'Rest API',
          collapsed: true,
          badge: { text: 'Deprecated', variant: 'caution' },
          items: [
            {
              autogenerate: {
                directory: "rest",
                collapsed: true,
              }
            },
          ]
        },
        {
          label: 'Migration Guides',
          collapsed: true,
          items: [{ autogenerate: { "directory": "migration-guides" }}]
        },
        {
          label: 'Release Notes',
          collapsed: true,
          items: [{ autogenerate: { directory: "release-notes", }}]
        },
        {
          label: 'Development',
          collapsed: true,
          items: [{ autogenerate: { "directory": "development" }}]
        },
        {
          label: 'Support ShopifySharp',
          slug: 'support'
        },
      ],
    }),
  ],
});
