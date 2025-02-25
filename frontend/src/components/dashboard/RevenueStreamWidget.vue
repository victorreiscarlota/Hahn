<script setup>
import { useLayout } from '@/layout/composables/layout';
import { onMounted, ref, watch } from 'vue';

const { getPrimary, getSurface, isDarkTheme } = useLayout();

const chartData = ref(null);
const chartOptions = ref(null);

function setChartData() {
    return {
        labels: ['Fire', 'Water', 'Electric', 'Grass'],
        datasets: [
            {
                label: 'Type Effectiveness',
                backgroundColor: ['#FF4422', '#3399FF', '#FFCC33', '#77CC55'],
                data: [85, 92, 78, 65],
                barThickness: 32
            }
        ]
    };
}

function setChartOptions() {
    return {
        maintainAspectRatio: false,
        aspectRatio: 0.8,
        plugins: {
            legend: {
                labels: {
                    color: '#6B7280'
                }
            }
        },
        scales: {
            x: {
                ticks: {
                    color: '#6B7280'
                },
                grid: {
                    color: 'transparent'
                }
            },
            y: {
                ticks: {
                    color: '#6B7280'
                },
                grid: {
                    color: '#E5E7EB'
                }
            }
        }
    };
}

watch([getPrimary, getSurface, isDarkTheme], () => {
    chartData.value = setChartData();
    chartOptions.value = setChartOptions();
});

onMounted(() => {
    chartData.value = setChartData();
    chartOptions.value = setChartOptions();
});
</script>

<template>
    <div class="card">
        <div class="font-semibold text-xl mb-4">Type Effectiveness</div>
        <Chart type="bar" :data="chartData" :options="chartOptions" class="h-80" />
    </div>
</template>
