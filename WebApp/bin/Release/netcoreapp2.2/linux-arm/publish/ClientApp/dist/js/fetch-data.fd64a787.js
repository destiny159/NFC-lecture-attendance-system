(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["fetch-data"],{6738:function(t,e,n){"use strict";n.r(e);var r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("v-layout",[n("v-flex",[n("v-sheet",[n("v-calendar",{ref:"calendar",attrs:{now:t.today,value:t.today,color:"primary",type:"week","interval-minutes":"30","first-interval":"16","interval-count":"22","interval-height":"45"},scopedSlots:t._u([{key:"dayHeadere",fn:function(e){var r=e.date;return[t._l(t.eventsMap[r],function(e){return[e.time?t._e():n("div",{key:e.title,staticClass:"my-event",domProps:{innerHTML:t._s(e.title)},on:{click:function(n){return t.open(e)}}})]})]}},{key:"dayBody",fn:function(e){var r=e.date,o=e.timeToY,a=e.minutesToPixels;return[t._l(t.eventsMap[r],function(e){return[e.time?n("div",{key:e.title,staticClass:"my-event with-time",style:{top:o(e.time)+"px",height:a(e.duration)+"px"},domProps:{innerHTML:t._s(e.title)},on:{click:function(n){return t.open(e)}}}):t._e()]})]}}])})],1)],1)],1)},o=[],a={data:function(){return{today:"2019-01-08",events:[{title:"Random lesson ",date:"2019-01-07",time:"09:00",duration:90},{title:"Random lesson 2",date:"2019-01-10",time:"11:00",duration:90},{title:"Random lesson 2",date:"2019-01-11",time:"11:00",duration:90},{title:"Random lesson 2",date:"2019-01-12",time:"15:30",duration:90}]}},computed:{eventsMap:function(){var t={};return this.events.forEach(function(e){return(t[e.date]=t[e.date]||[]).push(e)}),t}},mounted:function(){this.$refs.calendar.scrollToTime("08:00")},methods:{open:function(t){alert(t.title)}}},i=a,s=(n("a37e"),n("2877")),c=Object(s["a"])(i,r,o,!1,null,"b815d798",null);e["default"]=c.exports},"6d98":function(t,e,n){"use strict";n.r(e);var r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("v-container",{attrs:{fluid:""}},[n("v-slide-y-transition",{attrs:{mode:"out-in"}},[n("v-layout",{attrs:{column:""}},[n("h1",[t._v("NFC fetch")]),n("p",[t._v("This component demonstrates fetching data from the server.")]),n("v-data-table",{staticClass:"elevation-1",attrs:{headers:t.headers,items:t.scans,"hide-actions":"",loading:t.loading},scopedSlots:t._u([{key:"items",fn:function(e){return[n("td",[t._v(t._s(e.item.uid))]),n("td",[t._v(t._s(e.item.timeStamp))]),n("td",[t._v(t._s(e.item.dateTime))])]}}])},[n("v-progress-linear",{attrs:{color:"blue",indeterminate:""},scopedSlots:t._u([{key:"progress",fn:function(){},proxy:!0}])})],1)],1)],1)],1)},o=[],a=n("9ab4"),i=n("60a3"),s=n("bc3a"),c=n.n(s);function u(t){return u="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},u(t)}function l(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function f(t,e){for(var n=0;n<e.length;n++){var r=e[n];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(t,r.key,r)}}function p(t,e,n){return e&&f(t.prototype,e),n&&f(t,n),t}function d(t,e){return!e||"object"!==u(e)&&"function"!==typeof e?v(t):e}function v(t){if(void 0===t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return t}function m(t){return m=Object.setPrototypeOf?Object.getPrototypeOf:function(t){return t.__proto__||Object.getPrototypeOf(t)},m(t)}function y(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function");t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,writable:!0,configurable:!0}}),e&&b(t,e)}function b(t,e){return b=Object.setPrototypeOf||function(t,e){return t.__proto__=e,t},b(t,e)}var h=function(t){function e(){var t;return l(this,e),t=d(this,m(e).apply(this,arguments)),t.loading=!0,t.scans=[],t.headers=[{text:"UID",value:"uid"},{text:"TimeStamp",value:"timeStamp"},{text:"DateTime",value:"dateTime"}],t}return y(e,t),p(e,[{key:"created",value:function(){this.fetcNfc()}},{key:"fetcNfc",value:function(){var t=this;c.a.get("api/nfcscan/getscans").then(function(e){t.scans=e.data,t.loading=!1})}}]),e}(i["b"]);h=a["a"]([Object(i["a"])({})],h);var _=h,g=_,w=n("2877"),O=Object(w["a"])(g,r,o,!1,null,null,null);e["default"]=O.exports},"8ee4":function(t,e,n){},a37e:function(t,e,n){"use strict";var r=n("8ee4"),o=n.n(r);o.a},c032:function(t,e,n){"use strict";n.r(e);var r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("v-app",{attrs:{id:"inspire"}},[n("v-content",[n("v-container",{attrs:{fluid:"","fill-height":""}},[n("v-layout",{attrs:{"align-center":"","justify-center":""}},[n("v-flex",{attrs:{xs12:"",sm8:"",md4:""}},[n("v-card",{staticClass:"elevation-12"},[n("v-toolbar",{attrs:{dark:"",color:"primary"}},[n("v-toolbar-title",[t._v("Login form")]),n("v-spacer"),n("v-tooltip",{attrs:{bottom:""},scopedSlots:t._u([{key:"activator",fn:function(e){var r=e.on;return[n("v-btn",t._g({attrs:{href:t.source,icon:"",large:"",target:"_blank"}},r),[n("v-icon",{attrs:{large:""}},[t._v("code")])],1)]}}])},[n("span",[t._v("Source")])]),n("v-tooltip",{attrs:{right:""},scopedSlots:t._u([{key:"activator",fn:function(e){var r=e.on;return[n("v-btn",t._g({attrs:{icon:"",large:"",href:"https://codepen.io/johnjleider/pen/wyYVVj",target:"_blank"}},r),[n("v-icon",{attrs:{large:""}},[t._v("mdi-codepen")])],1)]}}])},[n("span",[t._v("Codepen")])])],1),n("v-card-text",[n("v-form",[n("v-text-field",{attrs:{"prepend-icon":"person",name:"login",label:"Login",type:"text"}}),n("v-text-field",{attrs:{id:"password","prepend-icon":"lock",name:"password",label:"Password",type:"password"}})],1)],1),n("v-card-actions",[n("v-spacer"),n("v-btn",{attrs:{color:"primary"}},[t._v("Login")])],1)],1)],1)],1)],1)],1)],1)},o=[],a={data:function(){return{drawer:null}},props:{source:String}},i=a,s=n("2877"),c=Object(s["a"])(i,r,o,!1,null,null,null);e["default"]=c.exports},c1ce:function(t,e,n){"use strict";n.r(e);var r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("v-container",{attrs:{fluid:""}},[n("v-slide-y-transition",{attrs:{mode:"out-in"}},[n("v-layout",{attrs:{column:""}},[n("h1",[t._v("Weather forecast")]),n("p",[t._v("This component demonstrates fetching data from the server.")]),n("v-data-table",{staticClass:"elevation-1",attrs:{headers:t.headers,items:t.forecasts,"hide-actions":"",loading:t.loading},scopedSlots:t._u([{key:"items",fn:function(e){return[n("td",[t._v(t._s(e.item.dateFormatted))]),n("td",[t._v(t._s(e.item.temperatureC))]),n("td",[t._v(t._s(e.item.temperatureF))]),n("td",[t._v(t._s(e.item.summary))])]}}])},[n("v-progress-linear",{attrs:{color:"blue",indeterminate:""},scopedSlots:t._u([{key:"progress",fn:function(){},proxy:!0}])})],1)],1)],1)],1)},o=[],a=n("9ab4"),i=n("60a3"),s=n("bc3a"),c=n.n(s);function u(t){return u="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},u(t)}function l(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function f(t,e){for(var n=0;n<e.length;n++){var r=e[n];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(t,r.key,r)}}function p(t,e,n){return e&&f(t.prototype,e),n&&f(t,n),t}function d(t,e){return!e||"object"!==u(e)&&"function"!==typeof e?v(t):e}function v(t){if(void 0===t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return t}function m(t){return m=Object.setPrototypeOf?Object.getPrototypeOf:function(t){return t.__proto__||Object.getPrototypeOf(t)},m(t)}function y(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function");t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,writable:!0,configurable:!0}}),e&&b(t,e)}function b(t,e){return b=Object.setPrototypeOf||function(t,e){return t.__proto__=e,t},b(t,e)}var h=function(t){function e(){var t;return l(this,e),t=d(this,m(e).apply(this,arguments)),t.loading=!0,t.forecasts=[],t.headers=[{text:"Date",value:"dateFormatted"},{text:"Temp. (C)",value:"temperatureC"},{text:"Temp. (F)",value:"temperatureF"},{text:"Summary",value:"summary"}],t}return y(e,t),p(e,[{key:"created",value:function(){this.fetchWeatherForecasts()}},{key:"fetchWeatherForecasts",value:function(){var t=this;c.a.get("api/SampleData/WeatherForecasts").then(function(e){t.forecasts=e.data,t.loading=!1})}}]),e}(i["b"]);h=a["a"]([Object(i["a"])({})],h);var _=h,g=_,w=n("2877"),O=Object(w["a"])(g,r,o,!1,null,null,null);e["default"]=O.exports}}]);
//# sourceMappingURL=fetch-data.fd64a787.js.map