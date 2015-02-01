$(document).ready(function () {
    var viewModel = {
        success: ko.observable(true),
        processing: ko.observable(false),
        errors: ko.observableArray(null),
        warnings: ko.observableArray(null),
        status: ko.observable(null),
    }

    ko.applyBindings(viewModel);

    $("#btn-validate").click(function () {

        viewModel.processing(true);

        $.ajax("/Validator/Validate",
        {
            type: "POST",
            data: {
                xml : $("#inputReaxml").val(),
            },
            success: function(data) {
                viewModel.success(data.Success);
                viewModel.errors(data.Errors);
                viewModel.warnings(data.Warnings);
                viewModel.status(data.Status);

                viewModel.processing(false);
            },
            error: function(data) {
                viewModel.success(data.Success);
                viewModel.errors(data.Errors);
                viewModel.warnings(data.Warnings);
                viewModel.status(data.Status);

                viewModel.processing(false);
            }
        });

        
    });
})