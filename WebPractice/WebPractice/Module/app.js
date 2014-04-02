var phonecatApp = angular.module('brfcatApp', [
  'ngRoute',
  'brfcatControllers'
]);

phonecatApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/Contact', {
            templateUrl: 'partials/phone-list.html',
            controller: 'PhoneListCtrl'
        }).
        //when('/phones/:phoneId', {
        //    templateUrl: 'partials/phone-detail.html',
        //    controller: 'PhoneDetailCtrl'
        //}).
        otherwise({
            redirectTo: '/phones'
        });
  }]);