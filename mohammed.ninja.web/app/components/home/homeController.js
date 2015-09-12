"use strict";
(function() {
    define([
            "angular",
            "angular-animate",
            "moment",
            "lodash",
            "Repository/testRepository"
        ],
        function(angular, animate, moment, lodash, testRepo, activityRepo, projectRepo) {

            var homeController = function($scope) {

                $scope.page = "something";
                $scope.who = "";

                $scope.x = false;

                $scope.run = function () {
                    if ($scope.who.length > 0) {
                        $scope.page = "awesome";
                        $scope.x = true;
                    }
                };
            };

            return homeController;
        });
})();