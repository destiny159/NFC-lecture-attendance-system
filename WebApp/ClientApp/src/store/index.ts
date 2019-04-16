import Vue from 'vue';
import Vuex, { StoreOptions } from 'vuex';
import { RootState } from './types';
import { counter } from './counter/index';
// @ts-ignore
import { alert } from './login/alert.module.js';
// @ts-ignore
import { account } from './login/account.module.js';
// @ts-ignore
import { users } from './login/users.module.js';

Vue.use(Vuex);

// Vuex structure based on https://codeburst.io/vuex-and-typescript-3427ba78cfa8

export const store: StoreOptions<RootState> = {
  state: {
    version: '1.0.0', // a simple property
  },
  modules: {
    counter,
    alert,
    account,
    users,
  },
};

export default new Vuex.Store<RootState>(store);
