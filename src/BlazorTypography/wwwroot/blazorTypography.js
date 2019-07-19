window.blazorTypography = {
    addFont: function (fontlink) {
        link = document.createElement('link');
        document.head.insertBefore(link, document.head.firstChild);
        link.type = 'text/css';
        link.rel = 'stylesheet';
        link.href = fontlink;
        return true;
    }
};
