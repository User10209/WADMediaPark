var MyApp = angular.module("MyApp", []);

MyApp.controller("ProductController", function ($scope, $http) {

    $scope.btnSaveText = "Save";

    $scope.SaveData = function () {

        $scope.btnSaveText = "Saving...";
        $http({
            method: 'POST',
            url: '/Product/Save_Info',
            data: $scope.ProductDAO
        }).success(function (a) {
            $scope.btnSaveText = "Save";
            $scope.ProductDAO = null;
            alert(a);
            $window.location.href = '/ListView.html';
        }).error(function () {
            alert("Failed");
        });
    }


    $scope.UpdateData = function () {
        $scope.btnSaveText = "Updating...";
        $http({
            method: 'POST',
            url: '/Product/Update_Info',
            data: $scope.ProductDAO
        }).success(function (a) {

            $scope.btnSaveText = "Update";
            $scope.ProductDAO = null;
            alert(a);
        }).error(function () {
            alert("Failed");
        });
    }


    $http.get("/Product/LoadData").then(function (d) {

        $scope.Product = d.data;
    }, function (error) {
        alert("Failed");
    });

    $scope.GetOneRecord = function (MasterId) {
        $scope.btnSaveText = "Update";

        $http.get("/Product/GetMAsterDataByID?MasterId=" + MasterId).then(function (d) {


            $scope.ProductDAO = d.data[0];
        }, function (error) {
            alert("Failed");
        });
    };

    $scope.DeleteMAsterData = function (ProductId) {

        $http.get("/Product/ReomveDataByMAsterId?ProductId=" + ProductId).then(function (d) {

            alert(d.data);
            $http.get("/Product/LoadData").then(function (d) {

                $scope.Product = d.data;
            }, function (error) {
                alert("Failed");
            });

        },
            function (error) {
                alert("Failed");
            }
        );
    };
});