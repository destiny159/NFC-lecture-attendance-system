import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';
import LoginPage from './views/LoginPage.vue';

Vue.use(Router);

export const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/home',
      name: 'home',
      component: Home,
    },
    {
      path: '/',
      name: 'login',
      component: LoginPage,
    },
    {
      path: '/fetch-data',
      name: 'fetch-data',
      component: () => import(/* webpackChunkName: "fetch-data" */ './views/FetchData.vue'),
    },
    {
      path: '/nfc-fetch',
      name: 'nfc-fetch',
      component: () => import(/* webpackChunkName: "fetch-data" */ './views/NfcFetch.vue'),
    },
    {
      path: '/timetable',
      name: 'timetable',
      component: () => import(/* webpackChunkName: "fetch-data" */ './views/Timetable.vue'),
    },
    {
      path: '/login',
      name: 'login',
      component: () => import(/* webpackChunkName: "fetch-data" */ './views/LoginMock.vue'),
    },
    {
      path: '*',
      redirect: '/home',
    },
  ],
});

router.beforeEach((to, from, next) => {
  // redirect to login page if not logged in and trying to access a restricted page
  const publicPages = ['/'];
  const authRequired = !publicPages.includes(to.path);
  const loggedIn = localStorage.getItem('user');

  if (authRequired && !loggedIn) {
    return next({
      path: '/',
      query: { returnUrl: to.path },
    });
  }
  next();
});
