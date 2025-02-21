<template>

</template>

<script setup lang="ts">
    import EventList from "@/components/EventList.vue";
    import PeopleList from "@/components/PeopleList.vue";
    import { defineProps } from "vue";
    import axios from "axios";

    // Define props passed to the component
    defineProps<{ title: string }>();

    // Function to create a new event
    const CreateEvent = async () => {
        try {
            const response = await axios.post('/Controllers/EventsController-CreateEvent');
            alert('Sündmus lisatud: ' + response.data);
        } catch (error) {
            console.error('Viga:', error);
        }
    };

    // Function to create a new person
    const CreatePerson = async () => {
        try {
            const response = await axios.post('/Controllers/PeopleController-CreatePerson');
            alert('Isik lisatud: ' + response.data);
        } catch (error) {
            console.error('Viga:', error);
        }
    };
</script>
