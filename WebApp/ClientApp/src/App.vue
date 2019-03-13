<template>
  <v-app>

    <v-navigation-drawer persistent :mini-variant="miniVariant" :clipped="clipped" v-model="drawer" enable-resize-watcher fixed app>
      <v-list>
        <v-list-tile value="true" v-for="(item, i) in items" :key="i" :to="item.link">
          <v-list-tile-action>
            <v-icon v-html="item.icon"></v-icon>
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title v-text="item.title"></v-list-tile-title>
          </v-list-tile-content>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer>

    <v-toolbar app :clipped-left="clipped">
      <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
      <v-btn icon @click.stop="miniVariant = !miniVariant">
        <v-icon v-html="miniVariant ? 'chevron_right' : 'chevron_left'"></v-icon>
      </v-btn>
      <v-btn icon @click.stop="clipped = !clipped">
        <v-icon>web</v-icon>
      </v-btn>
      <v-toolbar-title v-text="title"></v-toolbar-title>
      <v-spacer></v-spacer>
      <DialogTest right/>
    </v-toolbar>

    <v-content>
      <router-view/>
    </v-content>

    <v-footer app>
      <span>&nbsp;R.A.V.E.D&nbsp;&copy;&nbsp;2019</span>
    </v-footer>

  </v-app>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import DialogTest from './views/DialogTest.vue'; // @ is an alias to /src

@Component({
  components: {
    DialogTest,
  },
})

export default class App extends Vue {
  private clipped: boolean = true;
  private drawer: boolean = true;
  private miniVariant: boolean = false;
  private right: boolean = true;
  private title: string = 'NFC lankomumo sistema';
  private items = [
    { title: 'Home', icon: 'home', link: '/home' },
    { title: 'Counter', icon: 'touch_app', link: '/counter' },
    { title: 'Fetch data', icon: 'get_app', link: '/fetch-data' },
    { title: 'NFC Scans', icon: 'nfc', link: '/nfc-fetch' },
    { title: 'DeadlineIsNear', icon: 'timer', link: '/login' },
    { title: 'Access', icon: 'access_timer', link: '/dialog' },
    { title: 'Timetable', icon: 'warning', link: '/timetable' },
  ];
}
</script>

<style lang="css">
main.v-content {
  width: 100vw;
  height: calc(100vh - 64px);
  flex-direction: column;
  overflow: auto;
  margin-top: 64px;
  padding-top: 0 !important;
}
html {
  overflow: hidden;
}
</style>

