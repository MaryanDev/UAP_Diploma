Vue.component('v-map', Vue2Leaflet.Map);
Vue.component('v-tilelayer', Vue2Leaflet.TileLayer);
Vue.component('v-marker', Vue2Leaflet.Marker);

var MapResult = Vue.component('map-result',
    {
        name: 'MapResult',
        template: '#mapResultTmpl',
        data() {
            return {
                zoom: 13,
                center: [47.413220, -1.219482],
                url: 'http://{s}.tile.osm.org/{z}/{x}/{y}.png',
                attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
                markers: [L.latLng(47.413220, -1.219482), L.latLng(42.413220, -4.219482)]
            }
        }
    });