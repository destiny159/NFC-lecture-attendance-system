<template>
  <v-container fluid>
    <v-layout column align-center>
      <img src="@/assets/logo.png" alt="Vuetify.js" class="mb-5">
      <h1 class="headline">NFC lankomumo sistema</h1>
    </v-layout>
  </v-container>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import HelloWorld from '../components/HelloWorld.vue'; // @ is an alias to /src

@Component({
  components: {
    HelloWorld,
  },
})
export default class Home extends Vue {}
</script>
