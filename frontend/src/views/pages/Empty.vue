<template>
    <div class="p-4">
      <Card style="width: 25rem; overflow: hidden">
        <template #header>
          <img alt="user header" src="https://primefaces.org/cdn/primevue/images/usercard.png" />
        </template>
        <template #title>
          Empty Page
        </template>
        <template #subtitle>
          Card subtitle
        </template>
        <template #content>
          <p class="m-0">
            Use this page to start from scratch and place your custom content.
          </p>
        </template>
        <template #footer>
          <div class="flex gap-4 mt-1">
            <Button label="Cancel" severity="secondary" outlined class="w-full" />
            <Button label="Save" class="w-full" />
          </div>
        </template>
      </Card>
    </div>
  </template>

  <script setup>
  </script>
