function AuthorFromViewModel() {

    var self = this;

    self.saveCompleted = ko.observable(false);

    self.author = {
        firstName: ko.observable(),
        lastName: ko.observable(),
        biography: ko.observable(),
    };

    self.validateAndSave = function (form) {
        if (!$(form).valid()) {
            return false;
        }

        self.sending(true);
        self.author._RequestVerificationToken = form[0].value;
        $.ajax({
            url: 'Create',
            type: 'post',
            contentType: 'application/x-www-form-urlencoded',
            data: ko.toJs(self.author)
        })
            .success(self.successfulSave)
            .error(self.errorSave)
            .complete(function () { self.sending(false) });
    };

    self.successfulSave = function () {
        self.saveCompleted(true);
        $('.body-content').prepend(
            '<div class="alert alert-success"><strong>Successed</strong>New author has been added.</div>');
        setTimeout(function () { location.href = './'; }, 1000);
    };

    self.errorSave = function () {
        $('.body-content').prepend(
            '<div class="alert alert-danger"><strong>Error!</strong>Inccorect author data.</div>');
    }
}