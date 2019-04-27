<template>
  <v-layout row justify-center>
    <v-dialog v-model="dialog" persistent max-width="600px">
      <template v-slot:activator="{ on }">
        <v-btn color="primary" dark v-on="on">
          <v-icon
            small
            class="mr-1"
            @click="editItem(props.item)"
          >
            edit
          </v-icon>
        </v-btn>
      </template>
      <v-card>
        <v-card-title>
          <span class="headline">Konfiguruoti įrenginį</span>
        </v-card-title>
        <v-card-text>
          <v-container grid-list-md>
            <v-layout wrap>
              <v-flex xs12>
                <v-text-field label="Sąrašo nr." :value = "deviceObj.deviceId"  required readonly  outline></v-text-field>
              </v-flex>
              <v-flex xs12>
                <v-text-field label="Realus įrenginio ID" :value = "deviceObj.deviceIdReal"  required readonly  outline></v-text-field>
              </v-flex>
              <v-flex xs12>
                <v-text-field label="Laukiama atnaujinimo" :value = "deviceObj.updatePending" required readonly  outline></v-text-field>
              </v-flex>
              <v-flex xs12>
                <v-text-field label="Naujas įrenginio ID*" :value = "deviceObj.pendingDeviceId"></v-text-field>
              </v-flex>
              <v-flex xs12>
                <v-select
                  label="Auditorija*"
                  :items="classrooms"
                  name="classroomId"
                  :item-text="textProps"
                  :value="classrooms[deviceObj.classroomId]"
                  required
                ></v-select>
              </v-flex>
            </v-layout>
          </v-container>
          <small>*Būtini laukai</small>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn dark color="blue darken-1" flat @click="dialog = false">Uždaryti</v-btn>
          <v-btn dark color="blue darken-1" flat @click="dialog = false">Išsaugoti</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-layout>
</template>

<script>
  import { Device } from '../../models/Device';
  import { Classroom } from '../../models/Classroom';
  import { authHeader } from '../../components/login/auth-header';

  export default {
    name: 'EditDevice',
    props: {
      deviceObj: Object,
    },
    data: () => ({
      classrooms: [],
      dialog: false
    }),
    created () {
       const headers = {...authHeader()};
      axios.get(`api/lectures/getclassrooms`)
      .then(response => {
        // JSON responses are automatically parsed.
        this.classrooms = response.data
      });
      console.log(this.classrooms);
    },
    computed: {
      getClassrooms () {
        console.log(this.classrooms);
        return this.classrooms;
      },

      getNormalLocation(label, location){
        return label + " " + location
      }
      
    },
    methods: {
      textProps: item => item.classLocation + ' r.-' + item.classLabel
    }
}
</script>