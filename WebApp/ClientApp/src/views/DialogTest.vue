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
              <form @submit.prevent="handleSubmit">
                <v-card-text>
                  <v-form>                  
                      <div class="form-group">
                        <div v-show="submitted && !username" class="invalid-feedback">Įveskite vartotojo vardą!</div>
                        <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !username }" v-model="username" prepend-icon="person" name="username" label="Vartotojo vardas" type="text"></v-text-field>
                      </div>
                      <div class="form-group">
                        <div v-show="submitted && !password" class="invalid-feedback">Įveskite slaptažodį!</div>
                        <v-text-field v-model="password" class="form-control" :class="{ 'is-invalid': submitted && !password }" id="password" prepend-icon="lock" name="password" label="Slaptažodis" type="password"></v-text-field>
                      </div>                  
                  </v-form>
                </v-card-text>
                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn color="red" @click="dialog = false">Uždaryti</v-btn>
                   <div class="form-group">
                     <button class="btn btn-primary">
                      <v-btn color="primary" @click="dialog = false">Prisijungti</v-btn>
                    </button>
                   </div>
                </v-card-actions>
              </form>
            </v-card>
      </v-dialog>
</template>

<script>
import { router } from '../router';
import { userService } from '../services';

  export default {
    data () {
      return {
        dialog: false,
        notifications: false,
        sound: true,
        widgets: false,
        username: '',
        password: '',
        submitted: false,
        loading: false,
        returnUrl: '',
        returnError: '',
      }
    },
    created () {
      // reset login status
      userService.logout();

      // get return url from route parameters or default to '/'
      this.returnUrl = this.$route.query.returnUrl || '/home';
    },
    methods: {
      handleSubmit (e) {
        this.submitted = true;
        const { username, password } = this;

        // stop here if form is invalid
        if (!(username && password)) {
            return;
        }

        this.loading = true;
        userService.login(username, password)
          .then(
              user => {
                router.push(this.returnUrl);
                this.dialog = false;
              },
              returnError => {
                  this.returnError = returnError;
                  this.loading = false;
              }
          );
      }
    }
  }
</script>