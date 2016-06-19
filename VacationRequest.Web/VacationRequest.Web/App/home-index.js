var homeIndex = angular.module("homeIndex", ['ngRoute']);

homeIndex.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "vacationRequestController",
        templateUrl: "App/views/VacationRequest.html"
    });
    $routeProvider.otherwise({ redirectTo: "/" });
}]);


var vacationRequestController = ['$scope', function ($scope) {

    $(function () {
        $("#datepicker").datepicker();
    });

}];