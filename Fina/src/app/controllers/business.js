angular.module('finaApp')
	.controller('BusinessCtrl', function ($scope, $mdDialog, Request, $mdToast) {
	    $scope.options = {
	        rowSelection: true,
	        multiSelect: true,
	        autoSelect: false,
	        decapitate: false,
	        largeEditDialog: false,
	        boundaryLinks: false,
	        limitSelect: true,
	        pageSelect: true
	    };
	    $scope.selected = [];
	    $scope.init = function () {
	        Request.get()
                .then(function (res) {
                    $scope.business = JSON.parse(res.data);
                    console.log($scope.business);
                }, function (err) {
                    console.log(err);
                });
	    };
	    $scope.showAdvanced = function (ev, b) {
	        $mdDialog.show({
	            controller: DialogController,
	            templateUrl: 'create.html',
	            parent: angular.element(document.body),
	            targetEvent: ev,
	            locals: {
	                data: b,
	                cb: $scope.init
	            },
	            clickOutsideToClose: true
	        });
	    };
	    $scope.delete = function (selected) {
	        var ids = selected.map(function (item) {
	            return item.Id;
	        })
	        Request.delete(ids).then(function (data) {
	            $scope.init();
	            $scope.selected = [];
	        }, function (err) {
	            console.log(err);
	        })
	        console.log(selected);
	    }

	    function DialogController($scope, $mdDialog, $mdToast, data, cb) {
            $scope.types = [
                { id: 0, name: "Despesas" },
                { id: 1, name: "Receitas" }
            ];
            if (data) {
                $scope.text = 'Editar';
                $scope.isEdit = true;
                $scope.business = {
                    Date: new Date(data.Date),
                    Value: data.Value,
                    Category: data.Category,
                    Type: data.Type,
                    Observation: data.Observation,
                    Id: data.Id

                };
            } else {
                $scope.text = 'Criar';
                $scope.isEdit = false;
                $scope.business = {
                    Date: new Date()
                };
            }
	        
	        $scope.cancel = function () {
	            $mdDialog.cancel();
	        };

	        $scope.save = function (business) {
	            Request.post(business).then(function (data) {
	                $mdDialog.cancel();
	                cb();
	            });
	        }

	        $scope.edit = function (business) {
	            Request.put(business).then(function (data) {
	                $mdDialog.cancel();
	                cb();
	            });
	        }
	    }
	});