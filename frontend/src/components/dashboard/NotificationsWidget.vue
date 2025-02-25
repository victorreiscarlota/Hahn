<script setup>
import { ref } from 'vue';

const menu = ref(null);

const items = ref([
    { label: 'Mark All Read', icon: 'pi pi-fw pi-check' },
    { label: 'Notification Settings', icon: 'pi pi-fw pi-cog' }
]);

const notifications = ref([
    { type: 'gym', message: 'New Gym Challenge available in Viridian City!', time: 'TODAY' },
    { type: 'raid', message: 'Mewtwo Raid Battle starting in 1 hour!', time: 'TODAY' },
    { type: 'achievement', message: 'Unlocked "Master Trainer" achievement!', time: 'YESTERDAY' },
    { type: 'trade', message: 'Trade request from Trainer Red', time: 'LAST WEEK' }
]);
</script>

<template>
    <div class="card">
        <div class="flex items-center justify-between mb-6">
            <div class="font-semibold text-xl">Battle Alerts</div>
            <div>
                <Button icon="pi pi-ellipsis-v" class="p-button-text p-button-plain p-button-rounded"
                    @click="$refs.menu.toggle($event)"></Button>
                <Menu ref="menu" popup :model="items" class="!min-w-40"></Menu>
            </div>
        </div>

        <div v-for="(notification, index) in notifications" :key="index" class="mb-6">
            <div class="flex items-start">
                <div class="w-12 h-12 flex items-center justify-center rounded-full mr-4" :class="{
                    'bg-blue-100': notification.type === 'gym',
                    'bg-purple-100': notification.type === 'raid',
                    'bg-green-100': notification.type === 'achievement',
                    'bg-orange-100': notification.type === 'trade'
                }">
                    <i class="pi" :class="{
                        'pi-flag-fill text-blue-500': notification.type === 'gym',
                        'pi-bolt-fill text-purple-500': notification.type === 'raid',
                        'pi-star-fill text-green-500': notification.type === 'achievement',
                        'pi-share-alt text-orange-500': notification.type === 'trade'
                    }"></i>
                </div>
                <div class="flex-1">
                    <div class="text-surface-900 dark:text-surface-0">{{ notification.message }}</div>
                    <div class="text-muted-color text-sm mt-1">{{ notification.time }}</div>
                </div>
            </div>
        </div>
    </div>
</template>
