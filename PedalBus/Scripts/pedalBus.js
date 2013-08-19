$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this);
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.attr.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-pedalbus-target"));
            $target.replace(data);
        });

        return false;
    }

    $("form[data-pedalbus-ajax='true']").submit(ajaxFormSubmit);
});