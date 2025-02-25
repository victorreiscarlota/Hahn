<script setup>
import { ref } from 'vue';

const battles = ref([
    { trainer: 'Ash K.', team: 'Pikachu, Charizard, Greninja', result: 'Victory' },
    { trainer: 'Team Rocket', team: 'Arbok, Weezing, Meowth', result: 'Defeat' },
    { trainer: 'Misty', team: 'Starmie, Psyduck, Gyarados', result: 'Victory' },
    { trainer: 'Brock', team: 'Onix, Geodude, Steelix', result: 'Draw' },
    { trainer: 'Gary', team: 'Blastoise, Arcanine, Alakazam', result: 'Victory' }
]);

function getStatusBadge(result) {
    return {
        'Victory': 'bg-green-100 text-green-800',
        'Defeat': 'bg-red-100 text-red-800',
        'Draw': 'bg-yellow-100 text-yellow-800'
    }[result];
}
</script>

<template>
    <div class="card">
        <div class="font-semibold text-xl mb-4">Recent Battles</div>
        <div class="space-y-6">
            <div v-for="(battle, index) in battles" :key="index" class="flex items-start">
                <div class="w-12 h-12 flex items-center justify-center bg-surface-100 rounded-full mr-4">
                    <i class="pi pi-send text-surface-600"></i>
                </div>
                <div class="flex-1">
                    <div class="flex items-center justify-between mb-2">
                        <span class="font-medium text-surface-900">{{ battle.trainer }}</span>
                        <span :class="['px-3 py-1 rounded-full text-sm', getStatusBadge(battle.result)]">
                            {{ battle.result }}
                        </span>
                    </div>
                    <div class="text-muted-color text-sm">{{ battle.team }}</div>
                </div>
            </div>
        </div>
    </div>
</template>
