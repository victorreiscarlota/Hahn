<script setup>
import { ref } from 'vue';

const menu = ref(null);

const items = ref([
    { label: 'Add Favorite', icon: 'pi pi-fw pi-heart' },
    { label: 'Share', icon: 'pi pi-fw pi-share-alt' }
]);
</script>

<template>
    <div class="card">
        <div class="flex justify-between items-center mb-6">
            <div class="font-semibold text-xl">Most Used Pokémon</div>
            <div>
                <Button icon="pi pi-ellipsis-v" class="p-button-text p-button-plain p-button-rounded" @click="$refs.menu.toggle($event)"></Button>
                <Menu ref="menu" popup :model="items" class="!min-w-40"></Menu>
            </div>
        </div>
        <ul class="list-none p-0 m-0">
            <li class="flex flex-col md:flex-row md:items-center md:justify-between mb-6">
                <div>
                    <span class="text-surface-900 dark:text-surface-0 font-medium mr-2 mb-1 md:mb-0">Charizard</span>
                    <div class="mt-1 text-muted-color">Fire/Flying</div>
                </div>
                <div class="mt-2 md:mt-0 flex items-center">
                    <div class="bg-surface-300 dark:bg-surface-500 rounded-border overflow-hidden w-40 lg:w-24" style="height: 8px">
                        <div class="bg-red-500 h-full" style="width: 82%"></div>
                    </div>
                    <span class="text-red-500 ml-4 font-medium">%82</span>
                </div>
            </li>
            <li class="flex flex-col md:flex-row md:items-center md:justify-between mb-6">
                <div>
                    <span class="text-surface-900 dark:text-surface-0 font-medium mr-2 mb-1 md:mb-0">Greninja</span>
                    <div class="mt-1 text-muted-color">Water/Dark</div>
                </div>
                <div class="mt-2 md:mt-0 ml-0 md:ml-20 flex items-center">
                    <div class="bg-surface-300 dark:bg-surface-500 rounded-border overflow-hidden w-40 lg:w-24" style="height: 8px">
                        <div class="bg-blue-500 h-full" style="width: 75%"></div>
                    </div>
                    <span class="text-blue-500 ml-4 font-medium">%75</span>
                </div>
            </li>
            <li class="flex flex-col md:flex-row md:items-center md:justify-between mb-6">
                <div>
                    <span class="text-surface-900 dark:text-surface-0 font-medium mr-2 mb-1 md:mb-0">Lucario</span>
                    <div class="mt-1 text-muted-color">Fighting/Steel</div>
                </div>
                <div class="mt-2 md:mt-0 ml-0 md:ml-20 flex items-center">
                    <div class="bg-surface-300 dark:bg-surface-500 rounded-border overflow-hidden w-40 lg:w-24" style="height: 8px">
                        <div class="bg-orange-500 h-full" style="width: 68%"></div>
                    </div>
                    <span class="text-orange-500 ml-4 font-medium">%68</span>
                </div>
            </li>
        </ul>
    </div>
</template>
