var routesTable = [
    { path: '/', component: ListResult },
    { path: '/listView', component: ListResult },
    { path: '/mapView', component: MapResult }
];

var router = new VueRouter({
    routes: routesTable
});
