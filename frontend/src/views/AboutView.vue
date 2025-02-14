<template>
    <button @click="CreateEvent">Lisa sundmus</button>
    <EventList :title="title" />
    <button @click="CreatePerson">Lisa inimene</button>
    <PeopleList :title="title" />
</template>

<script setup lang="ts">
    import EventList from "@/components/EventList.vue"
    import PeopleList from "@/components/PeopleList.vue"
    import { defineProps } from "vue";

    
 

  
  defineProps<{ title: String}>();
</script>
