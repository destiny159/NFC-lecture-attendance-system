(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["fetch-data"],{c1ce:function(t,e,r){"use strict";r.r(e);var n=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("v-container",{attrs:{fluid:""}},[r("v-slide-y-transition",{attrs:{mode:"out-in"}},[r("v-layout",{attrs:{column:""}},[r("h1",[t._v("Weather forecast")]),r("p",[t._v("This component demonstrates fetching data from the server.")]),r("v-data-table",{staticClass:"elevation-1",attrs:{headers:t.headers,items:t.forecasts,"hide-actions":"",loading:t.loading},scopedSlots:t._u([{key:"items",fn:function(e){return[r("td",[t._v(t._s(e.item.dateFormatted))]),r("td",[t._v(t._s(e.item.temperatureC))]),r("td",[t._v(t._s(e.item.temperatureF))]),r("td",[t._v(t._s(e.item.summary))])]}}])},[r("v-progress-linear",{attrs:{color:"blue",indeterminate:""},scopedSlots:t._u([{key:"progress",fn:function(){},proxy:!0}])})],1)],1)],1)],1)},o=[],a=r("9ab4"),i=r("60a3"),u=r("bc3a"),s=r.n(u);function c(t){return c="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},c(t)}function f(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function l(t,e){for(var r=0;r<e.length;r++){var n=e[r];n.enumerable=n.enumerable||!1,n.configurable=!0,"value"in n&&(n.writable=!0),Object.defineProperty(t,n.key,n)}}function p(t,e,r){return e&&l(t.prototype,e),r&&l(t,r),t}function m(t,e){return!e||"object"!==c(e)&&"function"!==typeof e?y(t):e}function y(t){if(void 0===t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return t}function d(t){return d=Object.setPrototypeOf?Object.getPrototypeOf:function(t){return t.__proto__||Object.getPrototypeOf(t)},d(t)}function b(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function");t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,writable:!0,configurable:!0}}),e&&h(t,e)}function h(t,e){return h=Object.setPrototypeOf||function(t,e){return t.__proto__=e,t},h(t,e)}var v=function(t){function e(){var t;return f(this,e),t=m(this,d(e).apply(this,arguments)),t.loading=!0,t.forecasts=[],t.headers=[{text:"Date",value:"dateFormatted"},{text:"Temp. (C)",value:"temperatureC"},{text:"Temp. (F)",value:"temperatureF"},{text:"Summary",value:"summary"}],t}return b(e,t),p(e,[{key:"created",value:function(){this.fetchWeatherForecasts()}},{key:"fetchWeatherForecasts",value:function(){var t=this;s.a.get("api/SampleData/WeatherForecasts").then(function(e){t.forecasts=e.data,t.loading=!1})}}]),e}(i["b"]);v=a["a"]([Object(i["a"])({})],v);var _=v,w=_,g=r("2877"),O=Object(g["a"])(w,n,o,!1,null,null,null);e["default"]=O.exports}}]);
//# sourceMappingURL=fetch-data.9f53edcf.js.map