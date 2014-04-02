var brfcatApp = angular.module('brfcatApp', []);

brfcatApp.controller('ManagementListCtrl', function ($scope) {
    $scope.test = "a fine little test";
    $scope.people = [
      {
          name: 'Erik Olofsson',
          role: 'Ordförande'
      },
      {
          name: 'Karin Hallbeck',
          role: 'Sekreterare'
      },
      {
          name: 'Gunnvi Crona',
          role: ''
      }
    ];
});