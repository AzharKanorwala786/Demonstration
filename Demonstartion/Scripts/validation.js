$.validator.setDefaults({
    onfocusout: function (element) {
        $(element).valid();
    }
});