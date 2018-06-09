(function () {
    'use strict';

    angular
        .module('testapp')
        .factory('testService', factory);

    factory.$inject = ['$http'];

    function factory($http) {
        var fac = {};
        fac.GetAllRecords = function () {
            return $http.get('/api/Employees/');
        };
        fac.AddNewRecords = function (item) {
            return $http.post('/api/Employees/',item);
        };
        fac.DeleteRecords = function(id) {
            return $http.delete('/api/Employees/'+id);
        };
        fac.UpdateRecords = function (id,item) {
            return $http.put('/api/Employees/'+id,item);
        };
        return fac;
    }
})();