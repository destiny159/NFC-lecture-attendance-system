<template>
      <v-dialog v-model="dialog" persistent max-width="600px">
        <template v-slot:activator="{ on }">
          <v-btn color="primary" dark v-on="on">Prisijungti</v-btn>
        </template>
        <v-card class="elevation-12">
              <v-toolbar dark color="primary">
                <v-toolbar-title>Prisijungimas</v-toolbar-title>
                <v-spacer></v-spacer>
                <v-tooltip right>
                  <template v-slot:activator="{ on }">
                    <v-btn :href="source" icon large target="_blank" v-on="on">
                      <v-icon large>code</v-icon>
                    </v-btn>
                  </template>
                  <span>Source</span>
                </v-tooltip>
              </v-toolbar>
              <v-card-text>
                <v-form>
                  <v-text-field prepend-icon="person" name="login" label="Vartotojo vardas" type="text"></v-text-field>
                  <v-text-field id="password" prepend-icon="lock" name="password" label="Slaptažodis" type="password"></v-text-field>
                </v-form>
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="red" @click="dialog = false">Uždaryti</v-btn>
                <v-btn color="primary" @click="dialog = false">Prisijungti</v-btn>
              </v-card-actions>
            </v-card>
      </v-dialog>
</template>

<script>
  export default {
    data () {
      return {
        dialog: false,
        notifications: false,
        sound: true,
        widgets: false
      }
    }
  }
</script>