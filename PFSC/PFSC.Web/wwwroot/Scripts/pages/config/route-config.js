(function (angular) {
    angular.module("pfscModule").config(function routeConfig($routeProvider) {
        $routeProvider.when("/",
            {
                template: "<list-result-area></list-result-area>"
            })
            .when("/listView",
            {
                template: "<list-result-area></list-result-area>"
            })
            .when("/mapView",
            {
                template: "<map-area></map-area>"
            })
            .otherwise({ redirectTo: "/" });
    });
})(angular);