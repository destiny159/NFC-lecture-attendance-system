<template>
  <div>
  <v-container fluid>
    <v-slide-y-transition mode="out-in">
      <v-layout column>
        <h1>Users fetch</h1>
        <p>This component demonstrates fetching data from the server.</p>
        <v-data-table
            :headers="headers"
            :items="users"
            hide-actions
            :loading="loading"
            class="elevation-1"
          >
            <v-progress-linear v-slot:progress color="blue" indeterminate></v-progress-linear>
            <template v-slot:items="props">
              <td>{{ props.item.userName }}</td>
              <td>{{ props.item.name }}</td>
              <td>{{ props.item.surname }}</td>
              <td>{{ props.item.group }}</td>
              <td>{{ props.item.studentCode }}</td>
              <td>{{ props.item.email }}</td>
              <td>{{ props.item.uid }}</td>
              <td class="justify-center layout px-0">
              <v-icon
                small
                class="mr-2"
                @click="editItem(props.item)"
              >
                edit
              </v-icon>
              <v-icon
                small
                @click="deleteItem(props.item)"
              > 
                delete
              </v-icon>
            </td>
            </template>
          </v-data-table>

      </v-layout>
    </v-slide-y-transition>
  </v-container>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import { RegisteredUsers } from '../models/RegisteredUsers';
import axios from 'axios';

@Component({})
export default class FetchDataView extends Vue {
  private loading: boolean = true;
  private users: RegisteredUsers[] = [];
  private headers = [
    { text: 'Prisijungimo vardas', value: 'userName' },
    { text: 'Vardas', value: 'name' },
    { text: 'Pavardė', value: 'surname' },
    { text: 'Grupė', value: 'group' },
    { text: 'Vidko', value: 'studentCode' },
    { text: 'El. Paštas', value: 'email' },
    { text: 'UID', value: 'uid'},
    { text: '', value: ''},
  ];

  private created() {
    this.fetchUsers();
  }

  private fetchUsers() {
    axios.get<RegisteredUsers[]>('api/userlist/getusers')
      .then((response) => {
        this.users = response.data;
        this.loading = false;
      });
  }
}
</script>
