window.blazorTypography = {
    addFont: function (fontlink) {
        const head = document.head;
        var found = false;
        var links = head.getElementsByTagName("link");
        for (let tag of links) {
            if (trimHref(tag.href) === trimHref(fontlink)) found = true;
        }
        if (!found) {
            link = document.createElement('link');
            head.insertBefore(link, document.head.firstChild);
            link.type = 'text/css';
            link.rel = 'stylesheet';
            link.href = fontlink;
        }
        return true;
    }
};

function trimHref(href) {
    return href.substring(href.indexOf("//") + 2);
}
