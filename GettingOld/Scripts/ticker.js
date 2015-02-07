$(function () {
    var tick = function ($container) {
        $container.html((parseInt($container.html().replace(/,/g, '')) + 1).toLocaleString('en-US'));
    };

    $.each($('span.seconds'), function (key, value) {        
        window.setInterval(tick, 1000, $(value));
    });

    $.each($('span.minutes'), function (key, value) {
        window.setInterval(tick, 60000, $(value));
    });
});