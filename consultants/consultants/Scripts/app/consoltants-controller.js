﻿angular.module('ConsApp', [])
   .controller('ConsCtrl', function ($scope, $http) {



        $http.get("http://localhost:58281/api/Assignment").success(function (data, status, headers, config) {
//            //$scope.assignments = data[0].Consultant.Assignments[0].Assignment_Name;
            $scope.assignments = data;
//            $scope.details = [];
           

//            angular.forEach(data.Assignments, function (value, key) {
//                $scope.details.push(value);
//            });
//            //angular.forEach($scope.artists, function (value, key) {
//            //    $scope.artists2.push(value.Assignments);
            



//            $scope.g = "TRUE11111";


        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... something went wrong";
           $scope.working = false;
           $scope.g = "FALSE";

        })
   });
        
   