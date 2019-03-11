import '@babel/polyfill';
import Vue from 'vue';
import './plugins/axios';
import './plugins/vuetify';
import App from './App.vue';
import { router } from './router';
import store from '@/store/index';
import './registerServiceWorker';

Vue.config.productionTip = false;

// setup fake backend
import { configureFakeBackend } from './components/login/fake-backend.js';
configureFakeBackend();

new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount('#app');
