<template>
  <v-dialog v-model="dialog" persistent max-width="600px">   
    <template v-slot:activator="{ on }">    
      <v-btn color="primary" dark v-on="on">Registruotis</v-btn>
    </template>
    <v-card class="elevation-12">
      <v-toolbar dark color="primary">
        <v-toolbar-title>Registracija</v-toolbar-title>
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
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !username }" v-model="username" prepend-icon="person" name="username" label="Vartotojo prisijungimo vardas" type="text"></v-text-field>
                </div>
                <div class="form-group">
                  <div v-show="submitted && !vardas" class="invalid-feedback">Įveskite savo vardą !</div>
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !vardas }" prepend-icon="person_outline" name="vardas" label="Studento vardas" type="text"></v-text-field>
                </div>
                <div class="form-group">
                  <div v-show="submitted && !pavarde" class="invalid-feedback">Įveskite savo pavardę !</div>
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !pavarde }" prepend-icon="person_outline" name="pavarde" label="Studento pavardė" type="text"></v-text-field>
                </div>
                <div class="form-group">
                  <div v-show="submitted && !grupe" class="invalid-feedback">Įveskite savo akademinę grupę !</div>
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !grupe }" prepend-icon="group" name="grupė" label="Studento akademinė grupė (pvz IFF-7/3)" type="text"></v-text-field>
                </div>
                <div class="form-group">
                  <div v-show="submitted && !uid" class="invalid-feedback">Įveskite UID!</div>
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !uid }" prepend-icon="person_pin" name="uid" label="UID (LSP id)" type="text"></v-text-field>
                </div>
                <div class="form-group">
                  <div v-show="submitted && !password1" class="invalid-feedback">Įveskite slaptažodį!</div>
                  <v-text-field v-model="password" class="form-control" :class="{ 'is-invalid': submitted && !password1 }" id="password1" prepend-icon="lock" name="password" label="Slaptažodis" type="password"></v-text-field>
                </div>     
                <div class="form-group">
                  <div v-show="submitted && !password2" class="invalid-feedback">Įveskite pakartotiną slaptažodį!</div>
                  <v-text-field v-model="password" class="form-control" :class="{ 'is-invalid': submitted && !password2 }" id="password2" prepend-icon="lock" name="password" label="Pakartokite Slaptažodį" type="password"></v-text-field>
                </div>      
                <div class="form-group">
                  <div v-show="submitted && !email" class="invalid-feedback">Įveskite e. paštą!</div>
                  <v-text-field class="form-control" :class="{ 'is-invalid': submitted && !email }" v-model="username" prepend-icon="email" name="email" label="Elektroninis paštas" type="email"></v-text-field>
                </div>       
            </v-form>
          </v-card-text>
          <v-card-actions>
            <v-spacer></v-spacer>
              <div class="form-group">
                <button class="btn btn-primary">
                <v-btn color="primary" @click="dialog = false">Registruotis</v-btn>
                <v-btn color="yellow darken-2" class="white--text" @click="clear">Išvalyti</v-btn>
                <v-btn color="red" class="white--text" @click="dialog = false">Uždaryti</v-btn>
              </button>
              </div>
          </v-card-actions>
        </form>
    </v-card>
  </v-dialog>
</template>

<script>
  export default {
      methods: {
        handleClick (e) {
            alert("Rokai, kur registracijos forma?????\n\n(┛◉Д◉)┛彡┻━┻ ");
        }
      }
  }
</script>