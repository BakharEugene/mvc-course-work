//swap pictures
(function () {
    var mass, ind, len, tim, d;
    d = document;
    mass = ["Images/wallpapper1.jpg", "Images/wallpapper2.jpg", "Images/wallpapper3.jpg", "Images/wallpapper4.jpg"];
    len = mass.length;
    ind = 0;
    tim = 5000;//8сек = 8000
    onload = function () {
        start();
    };
    function start() {
        if (++ind >= len)
            ind = 0;
        d.body.style.backgroundImage = 'url("' + mass[ind] + '")';
        setTimeout(function () { start(); }, tim);
    };
})();