(function(t){function e(e){for(var n,o,s=e[0],u=e[1],c=e[2],l=0,d=[];l<s.length;l++)o=s[l],a[o]&&d.push(a[o][0]),a[o]=0;for(n in u)Object.prototype.hasOwnProperty.call(u,n)&&(t[n]=u[n]);f&&f(e);while(d.length)d.shift()();return i.push.apply(i,c||[]),r()}function r(){for(var t,e=0;e<i.length;e++){for(var r=i[e],n=!0,o=1;o<r.length;o++){var s=r[o];0!==a[s]&&(n=!1)}n&&(i.splice(e--,1),t=u(u.s=r[0]))}return t}var n={},o={app:0},a={app:0},i=[];function s(t){return u.p+"js/"+({counter:"counter","fetch-data":"fetch-data"}[t]||t)+"."+{counter:"f8a955d8","fetch-data":"fd64a787"}[t]+".js"}function u(e){if(n[e])return n[e].exports;var r=n[e]={i:e,l:!1,exports:{}};return t[e].call(r.exports,r,r.exports,u),r.l=!0,r.exports}u.e=function(t){var e=[],r={"fetch-data":1};o[t]?e.push(o[t]):0!==o[t]&&r[t]&&e.push(o[t]=new Promise(function(e,r){for(var n="css/"+({counter:"counter","fetch-data":"fetch-data"}[t]||t)+"."+{counter:"31d6cfe0","fetch-data":"18a23afb"}[t]+".css",a=u.p+n,i=document.getElementsByTagName("link"),s=0;s<i.length;s++){var c=i[s],l=c.getAttribute("data-href")||c.getAttribute("href");if("stylesheet"===c.rel&&(l===n||l===a))return e()}var d=document.getElementsByTagName("style");for(s=0;s<d.length;s++){c=d[s],l=c.getAttribute("data-href");if(l===n||l===a)return e()}var f=document.createElement("link");f.rel="stylesheet",f.type="text/css",f.onload=e,f.onerror=function(e){var n=e&&e.target&&e.target.src||a,i=new Error("Loading CSS chunk "+t+" failed.\n("+n+")");i.request=n,delete o[t],f.parentNode.removeChild(f),r(i)},f.href=a;var p=document.getElementsByTagName("head")[0];p.appendChild(f)}).then(function(){o[t]=0}));var n=a[t];if(0!==n)if(n)e.push(n[2]);else{var i=new Promise(function(e,r){n=a[t]=[e,r]});e.push(n[2]=i);var c,l=document.createElement("script");l.charset="utf-8",l.timeout=120,u.nc&&l.setAttribute("nonce",u.nc),l.src=s(t),c=function(e){l.onerror=l.onload=null,clearTimeout(d);var r=a[t];if(0!==r){if(r){var n=e&&("load"===e.type?"missing":e.type),o=e&&e.target&&e.target.src,i=new Error("Loading chunk "+t+" failed.\n("+n+": "+o+")");i.type=n,i.request=o,r[1](i)}a[t]=void 0}};var d=setTimeout(function(){c({type:"timeout",target:l})},12e4);l.onerror=l.onload=c,document.head.appendChild(l)}return Promise.all(e)},u.m=t,u.c=n,u.d=function(t,e,r){u.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:r})},u.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},u.t=function(t,e){if(1&e&&(t=u(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var r=Object.create(null);if(u.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var n in t)u.d(r,n,function(e){return t[e]}.bind(null,n));return r},u.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return u.d(e,"a",e),e},u.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},u.p="/",u.oe=function(t){throw console.error(t),t};var c=window["webpackJsonp"]=window["webpackJsonp"]||[],l=c.push.bind(c);c.push=e,c=c.slice();for(var d=0;d<c.length;d++)e(c[d]);var f=l;i.push([0,"chunk-vendors"]),r()})({0:function(t,e,r){t.exports=r("cd49")},"034f":function(t,e,r){"use strict";var n=r("64a9"),o=r.n(n);o.a},"1f57":function(t,e,r){"use strict";function n(){var t=JSON.parse(localStorage.getItem("user"));return t&&t.token?{Authorization:"Bearer "+t.token}:{}}function o(t){for(var e=1;e<arguments.length;e++){var r=null!=arguments[e]?arguments[e]:{},n=Object.keys(r);"function"===typeof Object.getOwnPropertySymbols&&(n=n.concat(Object.getOwnPropertySymbols(r).filter(function(t){return Object.getOwnPropertyDescriptor(r,t).enumerable}))),n.forEach(function(e){a(t,e,r[e])})}return t}function a(t,e,r){return e in t?Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[e]=r,t}r.d(e,"a",function(){return i});var i={login:s,logout:u,register:c,getAll:l,getById:d,update:f,delete:p};function s(t,e){var r={method:"POST",headers:{"Content-Type":"application/json"},body:JSON.stringify({username:t,password:e})};return fetch("/login",r).then(m).then(function(t){return t.token&&localStorage.setItem("user",JSON.stringify(t)),t})}function u(){localStorage.removeItem("user")}function c(t,e,r,n,o,a,i){var s={method:"POST",headers:{"Content-Type":"application/json"},body:JSON.stringify({username:t,password:e,name:r,surname:n,studentCode:o,uid:a,email:i})};return fetch("/register",s).then(m).then(function(t){return t.token&&localStorage.setItem("user",JSON.stringify(t)),t})}function l(){var t={method:"GET",headers:n()};return fetch("".concat(config.apiUrl,"/users"),t).then(m)}function d(t){var e={method:"GET",headers:n()};return fetch("".concat(config.apiUrl,"/users/").concat(t),e).then(m)}function f(t){var e={method:"PUT",headers:o({},n(),{"Content-Type":"application/json"}),body:JSON.stringify(t)};return fetch("".concat(config.apiUrl,"/users/").concat(t.id),e).then(m)}function p(t){var e={method:"DELETE",headers:n()};return fetch("".concat(config.apiUrl,"/users/").concat(t),e).then(m)}function m(t){return t.text().then(function(e){var r=e&&JSON.parse(e);if(!t.ok){401===t.status&&(u(),location.reload(!0));var n=r&&r.message||t.statusText;return Promise.reject(n)}return r})}},"295f":function(t,e,r){"use strict";r.r(e);var n=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("v-dialog",{attrs:{persistent:"","max-width":"600px"},scopedSlots:t._u([{key:"activator",fn:function(e){var n=e.on;return[r("v-btn",t._g({attrs:{color:"primary",dark:""}},n),[t._v("Prisijungti")])]}}]),model:{value:t.dialog,callback:function(e){t.dialog=e},expression:"dialog"}},[r("v-card",{staticClass:"elevation-12"},[r("v-toolbar",{attrs:{dark:"",color:"primary"}},[r("v-toolbar-title",[t._v("Prisijungimas")]),r("v-spacer"),r("v-tooltip",{attrs:{right:""},scopedSlots:t._u([{key:"activator",fn:function(e){var n=e.on;return[r("v-btn",t._g({attrs:{href:t.source,icon:"",large:"",target:"_blank"}},n),[r("v-icon",{attrs:{large:""}},[t._v("code")])],1)]}}])},[r("span",[t._v("Source")])])],1),r("form",{on:{submit:function(e){return e.preventDefault(),t.handleSubmit(e)}}},[r("v-card-text",[r("v-form",[r("div",{staticClass:"form-group"},[r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.username},attrs:{"error-messages":t.idErrors,required:"","prepend-icon":"person",name:"username",label:"Vartotojo vardas",type:"text"},model:{value:t.username,callback:function(e){t.username=e},expression:"username"}})],1),r("div",{staticClass:"form-group"},[r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.password},attrs:{"error-messages":t.passwordErrors,required:"",id:"password","prepend-icon":"lock",name:"password",label:"Slaptažodis",type:"password"},model:{value:t.password,callback:function(e){t.password=e},expression:"password"}})],1)])],1),r("v-card-actions",[r("v-spacer"),r("div",{staticClass:"form-group"},[r("button",{staticClass:"btn btn-primary"},[r("v-btn",{attrs:{color:"primary"},on:{click:t.handleSubmit}},[t._v("Prisijungti")]),r("v-btn",{staticClass:"white--text",attrs:{color:"red"},on:{click:function(e){t.dialog=!1}}},[t._v("Uždaryti")])],1)])],1)],1)],1)],1)},o=[],a=r("1dce"),i=r("b5ae"),s=r("5f86"),u=r("dde5");function c(){return!0}function l(){return!0}var d={mixins:[a["validationMixin"]],validations:{username:{required:i["required"],isIdValid:l,minLength:Object(i["minLength"])(4)},password:{required:i["required"],doesPasswordMatch:c,minLength:Object(i["minLength"])(6)}},data:function(){return{dialog:!1,notifications:!1,sound:!0,widgets:!1,username:"",password:"",submitted:!1,loading:!1,returnUrl:"",returnError:""}},computed:{idErrors:function(){var t=[];return this.$v.username.$dirty?(
//!this.$v.user.isIdValid && errors.push('Tokio vartotojo nėra')
!this.$v.username.minLength&&t.push("Vartotojo vardas turi būti bent iš 4 simbolių"),!this.$v.username.required&&t.push("Privalomas laukas"),t):t},passwordErrors:function(){var t=[];return this.$v.password.$dirty?(//!this.$v.password.doesPasswordMatch && errors.push('Neteisingas slaptažodis')
!this.$v.password.minLength&&t.push("Slaptažodis turi būti bent iš 6 simbolių"),!this.$v.password.required&&t.push("Privalomas laukas"),t):t}},created:function(){u["a"].logout(),this.returnUrl=this.$route.query.returnUrl||"/home"},methods:{handleSubmit:function(t){var e=this;this.$v.$touch(),this.submitted=!0;var r=this.username,n=this.password;this.$v.$invalid||(this.loading=!0,u["a"].login(r,n).then(function(t){s["a"].push(e.returnUrl),e.dialog=!1},function(t){e.returnError=t,e.loading=!1}))},submit:function(){this.$v.$touch(),this.$v.$invalid||(this.dialog=!1)}}},f=d,p=r("2877"),m=Object(p["a"])(f,n,o,!1,null,null,null);e["default"]=m.exports},"5f86":function(t,e,r){"use strict";var n=r("2b0e"),o=r("8c4f"),a=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("v-container",{attrs:{fluid:""}},[n("v-layout",{attrs:{column:"","align-center":""}},[n("img",{staticClass:"mb-5",attrs:{src:r("cf05"),alt:"Vuetify.js"}}),n("HelloWorld",{attrs:{quote:"Welcome to Your ASP.NET Core + Vue.js + TypeScript App",author:"brought to you by Software Ateliers"}})],1),n("v-slide-y-transition",{attrs:{mode:"out-in"}},[n("v-layout",{attrs:{column:""}},[n("h1",{staticClass:"headline"},[t._v("Hello, world!")]),n("p",[t._v("Welcome to your new single-page application, built with: ")]),n("ul",[n("li",[n("a",{attrs:{href:"https://get.asp.net",target:"_blank"}},[t._v(" ASP.NET Core")]),t._v(" and\n          "),n("a",{attrs:{href:"https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx",target:"_blank"}},[t._v("C#")]),t._v(" for cross-platform server-side API code")]),n("li",[n("a",{attrs:{href:"https://vuejs.org",target:"_blank"}},[t._v(" Vue.js")]),t._v(" for client-side code")]),n("li",[n("a",{attrs:{href:"https://cli.vuejs.org",target:"_blank"}},[t._v(" Vue CLI")]),t._v(" for building, bundling and adding or removing vue plugins")]),n("li",[n("a",{attrs:{href:"https://webpack.js.org",target:"_blank"}},[t._v("Webpack")]),t._v(" internally used by Vue CLI")]),n("li",[n("a",{attrs:{href:"https://vuetifyjs.com",target:"_blank"}},[t._v("Vuetify")]),t._v(" for layout and styling")])]),n("h3",{staticClass:"headline mt-3"},[t._v("To help you get started, we've also set up:")]),n("ul",[n("li",[n("strong",[t._v("Client-side navigation")]),t._v(". For example, click "),n("em",[t._v("Counter")]),t._v(" then "),n("em",[t._v("Back")]),t._v(" to return here.")]),n("li",[n("strong",[t._v("Development server integration")]),t._v(". In development mode, the development server from\n          "),n("code",[t._v("vue-cli-service")]),t._v(" runs in the background automatically, so your client-side resources are dynamically built on \n          demand and the page refreshes when you modify any file.")]),n("li",[n("strong",[t._v("Efficient production builds")]),t._v(". In production mode, development-time features are disabled, and the\n          "),n("code",[t._v("webpack")]),t._v(" build tool produces minified static CSS and JavaScript files.")])]),n("h3",{staticClass:"headline mt-3"},[t._v("Integrated Vue plugins:")]),n("ul",[n("li",[n("a",{attrs:{href:"https://vuejs.org",target:"_blank"}},[t._v(" Vue.js")]),t._v(" - reactive, component-oriented view layer for modern web interfaces.")]),n("li",[n("a",{attrs:{href:"https://vuetifyjs.com",target:"_blank"}},[t._v("Vuetify")]),t._v(" - a reusable semantic component framework for Vue.js.")]),n("li",[n("a",{attrs:{href:"https://github.com/vuejs/vue-class-component#readme",target:"_blank"}},[t._v("Class Component")]),t._v(" - ES201X/Typescript class decorator for Vue components.")]),n("li",[n("a",{attrs:{href:"https://github.com/kaorun343/vue-property-decorator#readme",target:"_blank"}},[t._v("Property Decorator")]),t._v(" - property decorators for Vue components")]),n("li",[n("a",{attrs:{href:"https://github.com/vuejs/vue-router#readme",target:"_blank"}},[t._v("Router")]),t._v(" - official router for Vue.js 2")]),n("li",[n("a",{attrs:{href:"https://github.com/vuejs/vuex#readme",target:"_blank"}},[t._v("Vuex")]),t._v(" - state management for Vue.js")]),n("li",[n("a",{attrs:{href:"https://github.com/yyx990803/register-service-worker#readme",target:"_blank"}},[t._v("Register Service Worker")]),t._v(" - script for registering service \n          worker with hooks for common events to simplify PWA development.")])])])],1)],1)},i=[],s=r("9ab4"),u=r("60a3"),c=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("div",[r("blockquote",[t._v("\n    “"+t._s(t.quote)+"”\n    "),r("footer",[r("small",[r("em",[t._v("—"+t._s(t.author))])])])])])},l=[],d={name:"HelloWorld",props:{quote:String,author:String}},f=d,p=(r("8589"),r("2877")),m=Object(p["a"])(f,c,l,!1,null,"5a08b673",null),v=m.exports;function h(t){return h="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},h(t)}function g(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function b(t,e){return!e||"object"!==h(e)&&"function"!==typeof e?y(t):e}function y(t){if(void 0===t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return t}function w(t){return w=Object.setPrototypeOf?Object.getPrototypeOf:function(t){return t.__proto__||Object.getPrototypeOf(t)},w(t)}function _(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function");t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,writable:!0,configurable:!0}}),e&&k(t,e)}function k(t,e){return k=Object.setPrototypeOf||function(t,e){return t.__proto__=e,t},k(t,e)}var P=function(t){function e(){return g(this,e),b(this,w(e).apply(this,arguments))}return _(e,t),e}(u["b"]);P=s["a"]([Object(u["a"])({components:{HelloWorld:v}})],P);var j=P,S=j,x=Object(p["a"])(S,a,i,!1,null,null,null),C=x.exports,O=function(){var t=this,e=t.$createElement;t._self._c;return t._m(0)},E=[function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("div",[r("h2",[t._v("Prisijunkite!")])])}],$={},q=Object(p["a"])($,O,E,!1,null,null,null),N=q.exports;r.d(e,"a",function(){return V}),n["default"].use(o["a"]);var V=new o["a"]({mode:"history",base:"/",routes:[{path:"/home",name:"home",component:C},{path:"/",name:"login",component:N},{path:"/counter",name:"counter",component:function(){return r.e("counter").then(r.bind(null,"80d5"))}},{path:"/fetch-data",name:"fetch-data",component:function(){return r.e("fetch-data").then(r.bind(null,"c1ce"))}},{path:"/nfc-fetch",name:"nfc-fetch",component:function(){return r.e("fetch-data").then(r.bind(null,"6d98"))}},{path:"/timetable",name:"timetable",component:function(){return r.e("fetch-data").then(r.bind(null,"6738"))}},{path:"/dialog",name:"dialog",component:function(){return r.e("fetch-data").then(r.bind(null,"295f"))}},{path:"/login",name:"login",component:function(){return r.e("fetch-data").then(r.bind(null,"c032"))}},{path:"*",redirect:"/home"}]});V.beforeEach(function(t,e,r){var n=["/"],o=!n.includes(t.path),a=localStorage.getItem("user");if(o&&!a)return r({path:"/",query:{returnUrl:t.path}});r()})},"64a9":function(t,e,r){},8589:function(t,e,r){"use strict";var n=r("8cd0"),o=r.n(n);o.a},"8cd0":function(t,e,r){},cd49:function(t,e,r){"use strict";r.r(e);r("744f"),r("6c7b"),r("7514"),r("20d6"),r("1c4c"),r("6762"),r("cadf"),r("e804"),r("55dd"),r("d04f"),r("c8ce"),r("217b"),r("7f7f"),r("f400"),r("7f25"),r("536b"),r("d9ab"),r("f9ab"),r("32d7"),r("25c9"),r("9f3c"),r("042e"),r("c7c6"),r("f4ff"),r("049f"),r("7872"),r("a69f"),r("0b21"),r("6c1a"),r("c7c62"),r("84b4"),r("c5f6"),r("2e37"),r("fca0"),r("7cdf"),r("ee1d"),r("b1b1"),r("87f3"),r("9278"),r("5df2"),r("04ff"),r("f751"),r("4504"),r("fee7"),r("ffc1"),r("0d6d"),r("9986"),r("8e6e"),r("25db"),r("e4f7"),r("b9a1"),r("64d5"),r("9aea"),r("db97"),r("66c8"),r("57f0"),r("165b"),r("456d"),r("cf6a"),r("fd24"),r("8615"),r("551c"),r("097d"),r("df1b"),r("2397"),r("88ca"),r("ba16"),r("d185"),r("ebde"),r("2d34"),r("f6b3"),r("2251"),r("c698"),r("a19f"),r("9253"),r("9275"),r("3b2b"),r("3846"),r("4917"),r("a481"),r("28a5"),r("386d"),r("6b54"),r("4f7f"),r("8a81"),r("ac4d"),r("8449"),r("9c86"),r("fa83"),r("48c0"),r("a032"),r("aef6"),r("d263"),r("6c37"),r("9ec8"),r("5695"),r("2fdb"),r("d0b0"),r("5df3"),r("b54a"),r("f576"),r("ed50"),r("788d"),r("14b9"),r("f386"),r("f559"),r("1448"),r("673e"),r("242a"),r("c66f"),r("b05c"),r("34ef"),r("6aa2"),r("15ac"),r("af56"),r("b6e4"),r("9c29"),r("63d9"),r("4dda"),r("10ad"),r("c02b"),r("4795"),r("130f"),r("ac6a"),r("96cf");var n=r("2b0e"),o=r("bc3a"),a=r.n(o),i={},s=a.a.create(i);s.interceptors.request.use(function(t){return t},function(t){return Promise.reject(t)}),s.interceptors.response.use(function(t){return t},function(t){return Promise.reject(t)}),Plugin.install=function(t,e){t.axios=s,window.axios=s,Object.defineProperties(t.prototype,{axios:{get:function(){return s}},$axios:{get:function(){return s}}})},n["default"].use(Plugin);Plugin;var u=r("d437"),c=r.n(u),l=r("d421"),d=r.n(l),f=r("535c"),p=r.n(f),m=r("d0ba"),v=r.n(m),h=r("e1f0"),g=r.n(h),b=r("5d92"),y=r.n(b),w=r("6a6f"),_=r.n(w),k=r("d553"),P=r.n(k),j=r("12d0"),S=r.n(j),x=r("46db"),C=r.n(x),O=r("5933"),E=r.n(O),$=r("2330"),q=r.n($),N=r("656d"),V=r.n(N),T=r("c713"),A=r.n(T),F=r("cf3f"),I=r.n(F),L=r("8f6b"),R=r.n(L),D=r("4ec6"),U=r.n(D),J=r("fa50"),M=r.n(J),B=r("db3b"),W=r.n(B);r("da64");n["default"].use(c.a,{components:{VApp:d.a,VNavigationDrawer:p.a,VFooter:v.a,VList:g.a,VBtn:y.a,VIcon:_.a,VGrid:P.a,VToolbar:S.a,VDataTable:C.a,VProgressLinear:E.a,transitions:q.a,VCalendar:V.a,VCard:A.a,VDialog:I.a,VForm:R.a,VTooltip:U.a,VImg:M.a,VTextField:W.a},theme:{primary:"#1976D2",secondary:"#424242",accent:"#82B1FF",error:"#FF5252",info:"#2196F3",success:"#4CAF50",warning:"#FFC107"}});var H=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("v-app",[r("v-navigation-drawer",{attrs:{persistent:"","mini-variant":t.miniVariant,clipped:t.clipped,"enable-resize-watcher":"",fixed:"",app:""},model:{value:t.drawer,callback:function(e){t.drawer=e},expression:"drawer"}},[r("v-list",t._l(t.items,function(e,n){return r("v-list-tile",{key:n,attrs:{value:"true",to:e.link}},[r("v-list-tile-action",[r("v-icon",{domProps:{innerHTML:t._s(e.icon)}})],1),r("v-list-tile-content",[r("v-list-tile-title",{domProps:{textContent:t._s(e.title)}})],1)],1)}),1)],1),r("v-toolbar",{attrs:{app:"","clipped-left":t.clipped}},[r("v-toolbar-side-icon",{on:{click:function(e){e.stopPropagation(),t.drawer=!t.drawer}}}),r("v-btn",{attrs:{icon:""},on:{click:function(e){e.stopPropagation(),t.miniVariant=!t.miniVariant}}},[r("v-icon",{domProps:{innerHTML:t._s(t.miniVariant?"chevron_right":"chevron_left")}})],1),r("v-btn",{attrs:{icon:""},on:{click:function(e){e.stopPropagation(),t.clipped=!t.clipped}}},[r("v-icon",[t._v("web")])],1),r("v-toolbar-title",{domProps:{textContent:t._s(t.title)}}),r("v-spacer"),r("Registration",{attrs:{right:""}}),r("DialogTest",{attrs:{right:""}})],1),r("v-content",[r("router-view")],1),r("v-footer",{attrs:{app:""}},[r("span",[t._v(" R.A.V.E.D © 2019")])])],1)},G=[],z=r("9ab4"),X=r("60a3"),Y=r("295f"),K=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("v-dialog",{attrs:{persistent:"","max-width":"600px"},scopedSlots:t._u([{key:"activator",fn:function(e){var n=e.on;return[r("v-btn",t._g({attrs:{color:"primary",dark:""}},n),[t._v("Registruotis")])]}}]),model:{value:t.dialog,callback:function(e){t.dialog=e},expression:"dialog"}},[r("v-card",{staticClass:"elevation-12"},[r("v-toolbar",{attrs:{dark:"",color:"primary"}},[r("v-toolbar-title",[t._v("Registracija")]),r("v-spacer"),r("v-tooltip",{attrs:{right:""},scopedSlots:t._u([{key:"activator",fn:function(e){var n=e.on;return[r("v-btn",t._g({attrs:{href:t.source,icon:"",large:"",target:"_blank"}},n),[r("v-icon",{attrs:{large:""}},[t._v("code")])],1)]}}])},[r("span",[t._v("Source")])])],1),r("form",{on:{submit:function(e){return e.preventDefault(),t.handleSubmit(e)}}},[r("v-card-text",[r("form",[r("div",{staticClass:"form-group"},[r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.username},attrs:{"error-messages":t.usernameErrors,required:"","prepend-icon":"person",name:"username",label:"Vartotojo prisijungimo vardas",type:"text"},model:{value:t.username,callback:function(e){t.username=e},expression:"username"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.firstName},attrs:{"error-messages":t.firstNameErrors,required:"","prepend-icon":"person_outline",name:"firstName",label:"Studento vardas",type:"text"},model:{value:t.firstName,callback:function(e){t.firstName=e},expression:"firstName"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.lastName},attrs:{"error-messages":t.lastNameErrors,required:"","prepend-icon":"person_outline",name:"lastName",label:"Studento pavardė",type:"text"},model:{value:t.lastName,callback:function(e){t.lastName=e},expression:"lastName"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.studentCode},attrs:{"error-messages":t.studentCodeErrors,required:"","prepend-icon":"account_box",name:"studentCode",label:"Vidko kodas",type:"text"},model:{value:t.studentCode,callback:function(e){t.studentCode=e},expression:"studentCode"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.uid},attrs:{"error-messages":t.uidErrors,required:"","prepend-icon":"person_pin",name:"uid",label:"UID (LSP id)",type:"text"},model:{value:t.uid,callback:function(e){t.uid=e},expression:"uid"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.password},attrs:{"error-messages":t.passwordErrors,required:"",id:"password","prepend-icon":"lock",name:"password",label:"Slaptažodis",type:"password"},model:{value:t.password,callback:function(e){t.password=e},expression:"password"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.verificationPassword},attrs:{"error-messages":t.verificationPasswordErrors,required:"",id:"verificationPassword","prepend-icon":"lock",name:"password",label:"Pakartokite Slaptažodį",type:"password"},model:{value:t.verificationPassword,callback:function(e){t.verificationPassword=e},expression:"verificationPassword"}}),r("v-text-field",{staticClass:"form-control",class:{"is-invalid":t.submitted&&!t.email},attrs:{"error-messages":t.emailErrors,required:"","prepend-icon":"email",name:"email",label:"Elektroninis paštas",type:"email"},model:{value:t.email,callback:function(e){t.email=e},expression:"email"}})],1)])]),r("v-card-actions",[r("v-spacer"),r("div",{staticClass:"form-group"},[r("button",{staticClass:"btn btn-primary"},[r("v-btn",{attrs:{color:"primary"},on:{click:t.submit}},[t._v("Registruotis")]),r("v-btn",{staticClass:"white--text",attrs:{color:"yellow darken-2"},on:{click:t.clear}},[t._v("Išvalyti")]),r("v-btn",{staticClass:"white--text",attrs:{color:"red"},on:{click:function(e){t.dialog=!1}}},[t._v("Uždaryti")])],1)])],1)],1)],1)],1)},Q=[],Z=r("1dce"),tt=r("b5ae"),et=r("5f86"),rt=r("dde5");function nt(){return this.password===this.verificationPassword}var ot={mixins:[Z["validationMixin"]],validations:{username:{required:tt["required"]},firstName:{required:tt["required"]},lastName:{required:tt["required"]},studentCode:{required:tt["required"]},uid:{required:tt["required"]},password:{required:tt["required"],passwordsMustMatch:nt,minLength:Object(tt["minLength"])(8)},verificationPassword:{required:tt["required"],minLength:Object(tt["minLength"])(8)},email:{required:tt["required"],email:tt["email"]}},data:function(){return{dialog:!1,notifications:!1,sound:!0,widgets:!1,username:"",firstName:"",lastName:"",studentCode:"",uid:"",password:"",verificationPassword:"",email:"",submitted:!1,loading:!1,returnUrl:"",returnError:""}},computed:{usernameErrors:function(){var t=[];return this.$v.username.$dirty?(!this.$v.username.required&&t.push("Privalomas laukas"),t):t},firstNameErrors:function(){var t=[];return this.$v.firstName.$dirty?(!this.$v.firstName.required&&t.push("Privalomas laukas"),t):t},lastNameErrors:function(){var t=[];return this.$v.lastName.$dirty?(!this.$v.lastName.required&&t.push("Privalomas laukas"),t):t},studentCodeErrors:function(){var t=[];return this.$v.studentCode.$dirty?(!this.$v.studentCode.required&&t.push("Privalomas laukas"),t):t},uidErrors:function(){var t=[];return this.$v.uid.$dirty?(!this.$v.uid.required&&t.push("Privalomas laukas"),t):t},passwordErrors:function(){var t=[];return this.$v.password.$dirty?(!this.$v.password.minLength&&t.push("Slaptažodis turi būti iš bent 8 simbolių"),this.password!==this.verificationPassword&&t.push("Neteisingai pakartojote slaptažodį"),!this.$v.password.required&&t.push("Privalomas laukas"),t):t},verificationPasswordErrors:function(){var t=[];return this.$v.verificationPassword.$dirty?(!this.$v.verificationPassword.minLength&&t.push("Slaptažodis turi būti iš bent 8 simbolių"),this.password!==this.verificationPassword&&t.push("Neteisingai pakartojote slaptažodį"),!this.$v.verificationPassword.required&&t.push("Privalomas laukas"),t):t},emailErrors:function(){var t=[];return this.$v.email.$dirty?(!this.$v.email.email&&t.push("Netinkantis el. paštas"),!this.$v.email.required&&t.push("Privalomas laukas"),t):t}},methods:{handleSubmit:function(t){var e=this;this.submitted=!0;var r=this.username,n=this.password,o=(this.verificationPassword,this.uid),a=this.email,i=this.firstName,s=this.lastName;this.$v.$invalid||(this.loading=!0,rt["a"].register(r,i,s,studentCode,o,a,n).then(function(t){et["a"].push(e.returnUrl),e.dialog=!1},function(t){e.returnError=t,e.loading=!1}))},submit:function(){var t=this;if(this.$v.$touch(),!this.$v.$invalid){var e=this.username,r=this.firstName,n=this.lastName,o=this.studentCode,a=this.uid,i=this.password,s=(this.verificationPassword,this.email);this.loading=!0,rt["a"].register(e,i,r,n,o,a,s).then(function(e){et["a"].push(t.returnUrl),t.dialog=!1},function(e){t.returnError=e,t.loading=!1})}},clear:function(){this.$v.$reset(),this.firstName="",this.lastName="",this.username="",this.studentCode="",this.uid="",this.password="",this.verificationPassword="",this.email=""}}},at=ot,it=r("2877"),st=Object(it["a"])(at,K,Q,!1,null,null,null),ut=st.exports;function ct(t){return ct="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},ct(t)}function lt(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function dt(t,e){return!e||"object"!==ct(e)&&"function"!==typeof e?ft(t):e}function ft(t){if(void 0===t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return t}function pt(t){return pt=Object.setPrototypeOf?Object.getPrototypeOf:function(t){return t.__proto__||Object.getPrototypeOf(t)},pt(t)}function mt(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function");t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,writable:!0,configurable:!0}}),e&&vt(t,e)}function vt(t,e){return vt=Object.setPrototypeOf||function(t,e){return t.__proto__=e,t},vt(t,e)}var ht=function(t){function e(){var t;return lt(this,e),t=dt(this,pt(e).apply(this,arguments)),t.clipped=!0,t.drawer=!0,t.miniVariant=!1,t.right=!0,t.title="NFC lankomumo sistema",t.items=[{title:"Home",icon:"home",link:"/home"},{title:"Counter",icon:"touch_app",link:"/counter"},{title:"Fetch data",icon:"get_app",link:"/fetch-data"},{title:"NFC Scans",icon:"nfc",link:"/nfc-fetch"},{title:"DeadlineIsNear",icon:"timer",link:"/login"},{title:"Access",icon:"access_timer",link:"/dialog"},{title:"Timetable",icon:"warning",link:"/timetable"}],t}return mt(e,t),e}(X["b"]);ht=z["a"]([Object(X["a"])({components:{DialogTest:Y["default"],Registration:ut}})],ht);var gt=ht,bt=gt,yt=(r("034f"),Object(it["a"])(bt,H,G,!1,null,null,null)),wt=yt.exports,_t=r("2f62"),kt={currentCount:function(t){return t.counter}},Pt={increment:function(t){var e=t.commit;e("incrementCounter")},reset:function(t){var e=t.commit;e("resetCounter")}},jt={incrementCounter:function(t){t.counter++},resetCounter:function(t){t.counter=0}},St={counter:0},xt=!0,Ct={namespaced:xt,state:St,getters:kt,actions:Pt,mutations:jt},Ot={type:null,message:null},Et={success:function(t,e){var r=t.commit;r("success",e)},returnError:function(t,e){var r=t.commit;r("error",e)},clear:function(t,e){var r=t.commit;r("success",e)}},$t={success:function(t,e){t.type="alert-success",t.message=e},returnError:function(t,e){t.type="alert-danger",t.message=e},clear:function(t){t.type=null,t.message=null}},qt={namespaced:!0,state:Ot,actions:Et,mutations:$t},Nt=r("1f57"),Vt=JSON.parse(localStorage.getItem("user")),Tt=Vt?{status:{loggedIn:!0},user:Vt}:{status:{},user:null},At={login:function(t,e){var r=t.dispatch,n=t.commit,o=e.username,a=e.password;n("loginRequest",{username:o}),Nt["a"].login(o,a).then(function(t){n("loginSuccess",t),et["a"].push("/home")},function(t){n("loginFailure",t),r("alert/returnError",t,{root:!0})})},logout:function(t){var e=t.commit;Nt["a"].logout(),e("logout")},register:function(t,e){var r=t.dispatch,n=t.commit;n("registerRequest",e),Nt["a"].register(e).then(function(t){n("registerSuccess",t),et["a"].push("/"),setTimeout(function(){r("alert/success","Registration successful",{root:!0})})},function(t){n("registerFailure",t),r("alert/returnError",t,{root:!0})})}},Ft={loginRequest:function(t,e){t.status={loggingIn:!0},t.user=e},loginSuccess:function(t,e){t.status={loggedIn:!0},t.user=e},loginFailure:function(t){t.status={},t.user=null},logout:function(t){t.status={},t.user=null},registerRequest:function(t,e){t.status={registering:!0}},registerSuccess:function(t,e){t.status={}},registerFailure:function(t,e){t.status={}}},It={namespaced:!0,state:Tt,actions:At,mutations:Ft};function Lt(t,e){if(null==t)return{};var r,n,o=Rt(t,e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(t);for(n=0;n<a.length;n++)r=a[n],e.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(t,r)&&(o[r]=t[r])}return o}function Rt(t,e){if(null==t)return{};var r,n,o={},a=Object.keys(t);for(n=0;n<a.length;n++)r=a[n],e.indexOf(r)>=0||(o[r]=t[r]);return o}function Dt(t){for(var e=1;e<arguments.length;e++){var r=null!=arguments[e]?arguments[e]:{},n=Object.keys(r);"function"===typeof Object.getOwnPropertySymbols&&(n=n.concat(Object.getOwnPropertySymbols(r).filter(function(t){return Object.getOwnPropertyDescriptor(r,t).enumerable}))),n.forEach(function(e){Ut(t,e,r[e])})}return t}function Ut(t,e,r){return e in t?Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[e]=r,t}var Jt={all:{}},Mt={getAll:function(t){var e=t.commit;e("getAllRequest"),Nt["a"].getAll().then(function(t){return e("getAllSuccess",t)},function(t){return e("getAllFailure",t)})},delete:function(t,e){var r=t.commit;r("deleteRequest",e),Nt["a"].delete(e).then(function(t){return r("deleteSuccess",e)},function(t){return r("deleteSuccess",{id:e,returnError:t.toString()})})}},Bt={getAllRequest:function(t){t.all={loading:!0}},getAllSuccess:function(t,e){t.all={items:e}},getAllFailure:function(t,e){t.all={returnError:e}},deleteRequest:function(t,e){t.all.items=t.all.items.map(function(t){return t.id===e?Dt({},t,{deleting:!0}):t})},deleteSuccess:function(t,e){t.all.items=t.all.items.filter(function(t){return t.id!==e})},deleteFailure:function(t,e){var r=e.id,n=e.returnError;t.all.items=t.items.map(function(t){if(t.id===r){t.deleting;var e=Lt(t,["deleting"]);return Dt({},e,{deleteError:n})}return t})}},Wt={namespaced:!0,state:Jt,actions:Mt,mutations:Bt};n["default"].use(_t["a"]);var Ht={state:{version:"1.0.0"},modules:{counter:Ct,alert:qt,account:It,users:Wt}},Gt=(new _t["a"].Store(Ht),r("9483"));Object(Gt["a"])("".concat("/","service-worker.js"),{ready:function(){console.log("App is being served from cache by a service worker.\nFor more details, visit https://goo.gl/AFskqB")},cached:function(){console.log("Content has been cached for offline use.")},updated:function(){console.log("New content is available; please refresh.")},offline:function(){console.log("No internet connection found. App is running in offline mode.")},error:function(t){console.error("Error during service worker registration:",t)}}),n["default"].config.productionTip=!1,new n["default"]({router:et["a"],store:Ht,render:function(t){return t(wt)}}).$mount("#app")},cf05:function(t,e,r){t.exports=r.p+"img/logo.978a7dfc.png"},dde5:function(t,e,r){"use strict";var n=r("1f57");r.d(e,"a",function(){return n["a"]})}});
//# sourceMappingURL=app.6088d3d0.js.map