angular.module('finaApp')
    .service('Request', function ($http) {
        this.get = function () {
            return $http.get('/Business/GetAll');
        }
        this.post = function (data) {
            return $http.post('/Business/Insert',data);
        }
        this.delete = function (data) {
            return $http.post('/Business/Delete', data);
        }
        this.put = function (data) {
            return $http.post('/Business/Update',data);
        }
    });