function RatesViewModel() {

    var self = this;

    self.Rates = ko.observableArray();

    self.loadRates = function () {
        $.getJSON("/home/getrates", function (allData) {
            var mappedData = $.map(allData, function (item) { return new Rate(item.Code, item.BuyCash, item.SellCash) });
            self.Rates(mappedData);
        });
    };

    return self;

}

var viewModel = new RatesViewModel();

ko.applyBindings(viewModel);