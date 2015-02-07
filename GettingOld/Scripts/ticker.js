$(function () {
    var tick = function ($container, countUp) {
        var value = parseInt($container.html().replace(/,/g, ''));
        if (countUp) {
            value = (value + 1)
        }
        else {
            value = (value - 1)
        }
        $container.html(value.toLocaleString('en-US'));
    };

    $.each($('span.seconds'), function (key, value) {        
        window.setInterval(tick, 1000, $(value), true);
    });

    $.each($('span.minutes'), function (key, value) {
        window.setInterval(tick, 60000, $(value), true);
    });

    $.each($('span.seconds-down'), function (key, value) {
        window.setInterval(tick, 1000, $(value), false);
    });

    $.each($('span.minutes-down'), function (key, value) {
        window.setInterval(tick, 60000, $(value), false);
    });
});