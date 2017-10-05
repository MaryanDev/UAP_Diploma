(function (angular) {
    function searchFieldController($scope, $element, $attrs) {
        var self = this;

        self.repos = loadAll();
        self.querySearch = querySearch;

        function querySearch(query) {
            var results = query ? self.repos.filter(createFilterFor(query)) : self.repos;
            return results;
        }

        function loadAll() {
            var repos = [
                {
                    'name': 'AngularJS',
                    'url': 'https://github.com/angular/angular.js',
                    'watchers': '3,623',
                    'forks': '16,175',
                },
                {
                    'name': 'Angular',
                    'url': 'https://github.com/angular/angular',
                    'watchers': '469',
                    'forks': '760',
                },
                {
                    'name': 'AngularJS Material',
                    'url': 'https://github.com/angular/material',
                    'watchers': '727',
                    'forks': '1,241',
                },
                {
                    'name': 'Angular Material',
                    'url': 'https://github.com/angular/material2',
                    'watchers': '727',
                    'forks': '1,241',
                },
                {
                    'name': 'Bower Material',
                    'url': 'https://github.com/angular/bower-material',
                    'watchers': '42',
                    'forks': '84',
                },
                {
                    'name': 'Material Start',
                    'url': 'https://github.com/angular/material-start',
                    'watchers': '81',
                    'forks': '303',
                }
            ];
            return repos.map(function (repo) {
                repo.value = repo.name.toLowerCase();
                return repo;
            });
        }

        function createFilterFor(query) {
            var lowercaseQuery = angular.lowercase(query);

            return function filterFn(item) {
                return (item.value.indexOf(lowercaseQuery) === 0);
            };

        }
    }
    angular.module("pfscModule").component("searchField",
        {
            bindings: {

            },
            templateUrl: "/Scripts/pages/templates/searchField.html",
            controller: searchFieldController
        });
})(angular);