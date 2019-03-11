<template>
  <v-container fluid>
    <v-slide-y-transition mode="out-in">
      <v-layout column>
        <h1>NFC fetch</h1>
        <p>This component demonstrates fetching data from the server.</p>

        <v-data-table
            :headers="headers"
            :items="scans"
            hide-actions
            :loading="loading"
            class="elevation-1"
          >
            <v-progress-linear v-slot:progress color="blue" indeterminate></v-progress-linear>
            <template v-slot:items="props">
              <td>{{ props.item.dateTime }}</td>
              <td>{{ props.item.timeStamp }}</td>
              <td>{{ props.item.uid }}</td>
            </template>
          </v-data-table>

      </v-layout>
    </v-slide-y-transition>
  </v-container>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import { NfcScan } from '../models/NfcScan';
import axios from 'axios';

@Component({})
export default class FetchDataView extends Vue {
  private loading: boolean = true;
  private scans: NfcScan[] = [];
  private headers = [
    { text: 'TimeStamp', value: 'timeStamp' },
    { text: 'UID', value: 'uid' },
    { text: 'DateTime', value: 'dateTime' },
  ];

  private created() {
    this.fetcNfc();
  }

  private fetcNfc() {
    axios.get<NfcScan[]>('api/nfcscan/getscans')
      .then((response) => {
        this.scans = response.data;
        this.loading = false;
      });
  }
}
</script>
