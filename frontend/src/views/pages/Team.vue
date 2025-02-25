<template>
    <div class="p-4">
        <Card style="width: 25rem; overflow: hidden">
            <template #header>
                <div v-if="pokemonData" class="flex gap-4">
                    <img alt="user header" :src="pokemonData.sprites.front_default" />
                    <img alt="user header" :src="pokemonData.sprites.back_default" />
                </div>
            </template>
            <template #title>
                <span class="capitalize"> {{ pokemonData.name }} </span>
            </template>
            <template #subtitle>
                <p v-for="type in pokemonData.types" class="m-0 capitalize">{{ type.type.name }}</p></template
            >
            <template #content>
                <p v-for="ability in pokemonData.abilities" class="m-0 capitalize">{{ ability.ability.name }}</p>
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
import { onMounted, ref } from 'vue';

const pokemonData = ref('');
const getPokemon = async () => {
    const response = await fetch('https://pokeapi.co/api/v2/pokemon/ditto');
    const data = await response.json();
    console.log(data);
    pokemonData.value = data;
};

onMounted(() => {
    getPokemon();
});
</script>
