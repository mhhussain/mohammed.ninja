"use strict";
(function() {
    define([
            "angular",
            "angular-route",
            "componentsPath/home/homeController",
            "shared/ckEditor"
        ],
        function(
            angular,
            angularRoute,
            homeController,
            ckEditor) {

            var myApp = angular.module("myApp", ["ngRoute"]);

            //ckeditor
            myApp.directive("ckEditor", ckEditor);

            //This is how the module will be loaded to the page
            //Normally one uses ng-app="myApp" in an HTML tag
            //This is the alternative so Angular can load properly with Require
            myApp.init = function() {
                angular.bootstrap(document, ["myApp"]);
            }

            //Set routing information, including assigning controllers to pages
            myApp.config([
                "$routeProvider",
                function($routeProvider) {
                    $routeProvider.
                        when("/home", {
                            templateUrl: "app/components/home/home.html",
                            controller: "homeController"
                        }).
                        otherwise({
                            redirectTo: "/home"
                        });
                }
            ]);

            //Sets the controllers for this module 
            myApp.controller("homeController", homeController);

            //Returning myApp allows us to access this module outside this file, i.e. in RequireConfig.js
            return myApp;
        });
})();