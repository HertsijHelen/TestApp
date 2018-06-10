(function () {
    'use strict';

    angular
        .module('testapp')
        .controller('testController', controller);
    function controller($scope, $http, testService)
    {
        $scope.itemsData = null;
        $scope.add = false;
        $scope.upd = false;
        //GetAllItems
        testService.GetAllRecords().then(function (response) {
            console.log("success");
            $scope.itemsData = response.data;
            $scope.clear();
        }, function ()
            {
            console.log('Failed Connection'); // Failed
        });
        $scope.Items = {
            Id: '',
            Name: '',
            Position: '',
            Age: '',
            StartDate: ''
        };

        $scope.ItemUpdate = {
            Id: '',
            Name: '',
            Position: '',
            Age: '',
            StartDate: ''
        };
        //clear add
        $scope.clear = function () {
            $scope.Items.Id = '';
            $scope.Items.Name = '';
            $scope.Items.Position = '',
            $scope.Items.Age = '',
            $scope.Items.StartDate = ''
        };

        // Delete item       
        $scope.delete = function (item) {
            console.log("delete");
            console.log(item.Id);
            var id = parseInt(item.Id);
            testService.DeleteRecords(id)
                .then(function successCallback(response) {
                    if (response.data!== null) {
                        console.log(response.data);
                        $scope.itemsData = response.data;
                        $scope.$apply();
                    }
                   
                },
                function errorCallback(response) {
                    alert("Error : " + response.data.ExceptionMessage);
                });
        };
        //cansel add form
        $scope.cancel = function () {
            $scope.clear();
            $scope.add = false;
        };

        //close update form
        $scope.close = function ()
        {
            $scope.upd = false;
        }

        //show AddForm
        $scope.showAdd = function ()
        {
            $scope.add = true;
        }

        //Add Item
        $scope.submit = function ()
        {
        console.log("submit");          
         testService.AddNewRecords($scope.Items)
             .then(function successCallback(response) {
                 if (response.data!== null) {
                     $scope.itemsData.push(response.data);
                     $scope.$apply();
                     $scope.clear(); 
                 }           
             },
             function errorCallback(response)
             {
               console.log("Error : " + response.data.ExceptionMessage);
             });
        }
       
        //edit
        $scope.edit = function (item) {
            $scope.ItemEdit = {Id:item.Id,Name:item.Name,Position:item.Position,Age:item.Age,StartDate:item.StartDate };
            $scope.upd = true;
        };
        //Update item       
        $scope.update = function ()
        {
            console.log("update");
            var itemId = $scope.ItemEdit.Id;
            var id = parseInt(itemId);
          
          testService.UpdateRecords(id,$scope.ItemEdit)
              .then(function successCallback(response)
              {
              if (response.data!== null)
              {
                  $scope.itemsData = response.data;
                  $scope.$apply();
                  $scope.clear();
              }                  
                },
              function errorCallback(response)
              {
                    alert("Error : " + response.data.ExceptionMessage);
                });
        };
        //make pagination
        $scope.itemsPerPage = 5;
        $scope.currentPage = 0;

        $scope.range = function () {
            var rangeSize = 4;
            var ps = [];
            var start;

            start = $scope.currentPage;
            if (start > $scope.pageCount() - rangeSize) {
                start = $scope.pageCount() - rangeSize + 1;
            }

            for (var i = start; i < start + rangeSize; i++) {
                if (i >= 0) {
                    ps.push(i);
                }
            }
            return ps;
        };

        $scope.prevPage = function () {
            if ($scope.currentPage > 0) {
                $scope.currentPage--;
            }
        };

        $scope.DisablePrevPage = function () {
            return $scope.currentPage === 0 ? "disabled" : "";
        };

        $scope.pageCount = function () {
            return Math.ceil($scope.itemsData.length / $scope.itemsPerPage) - 1;
        };

        $scope.nextPage = function () {
            if ($scope.currentPage < $scope.pageCount()) {
                $scope.currentPage++;
            }
        };

        $scope.DisableNextPage = function () {
            return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
        };

        $scope.setPage = function (n) {
            $scope.currentPage = n;
        };
        //datepicker
        $scope.today = function () {
            $scope.Items.StartDate = new Date();
        };
        $scope.today();

        $scope.clear = function () {
            $scope.Items.StartDate = null;
        };

        $scope.inlineOptions = {
            customClass: getDayClass,
            minDate: new Date(),
            showWeeks: true
        };

        $scope.dateOptions = {
            dateDisabled: disabled,
            formatYear: 'yy',
            maxDate: new Date(2050, 5, 5),
            minDate: new Date(2010, 5, 5),
            startingDay: 1
        };

        // Disable weekend selection
        function disabled(data) {
            var date = data.date,
                mode = data.mode;
            return mode === 'day' && (date.getDay() === 0 || date.getDay() === 6);
        }

        $scope.toggleMin = function () {
            $scope.inlineOptions.minDate = $scope.inlineOptions.minDate ? null : new Date();
            $scope.dateOptions.minDate = $scope.inlineOptions.minDate;
        };

        $scope.toggleMin();

        $scope.open2 = function () {
            console.log("open2");
            $scope.popup2.opened = true;

        };

        $scope.setDate = function (year, month, day) {
            $scope.dt = new Date(year, month, day);
        };

        $scope.formats = ['yyyy-MM-dd', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate'];
        $scope.format = $scope.formats[0];
        $scope.altInputFormats = ['M!/d!/yyyy'];

        $scope.popup1 = {
            opened: false
        };
        $scope.popup2 = {
            opened: false
        };
        var tomorrow = new Date();
        tomorrow.setDate(tomorrow.getDate() + 1);
        var afterTomorrow = new Date();
        afterTomorrow.setDate(tomorrow.getDate() + 1);
        $scope.events = [
            {
                date: tomorrow,
                status: 'full'
            },
            {
                date: afterTomorrow,
                status: 'partially'
            }
        ];

        function getDayClass(data) {
            var date = data.date,
                mode = data.mode;
            if (mode === 'day') {
                var dayToCheck = new Date(date).setHours(0, 0, 0, 0);

                for (var i = 0; i < $scope.events.length; i++) {
                    var currentDay = new Date($scope.events[i].date).setHours(0, 0, 0, 0);

                    if (dayToCheck === currentDay) {
                        return $scope.events[i].status;
                    }
                }
            }
            return '';
        }
    }  
})();

