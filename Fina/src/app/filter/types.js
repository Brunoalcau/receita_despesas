angular.module('finaApp')
    .filter('types', function () {
        return function (item) {
            return item ? 'Receitas' : 'Despesas';
        }
    })