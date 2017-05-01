var browserName = navigator.appName,
	addScroll = false,
	off = 0,
	txt = "",
	pX = 0,
	pY = 0;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) ||
	(navigator.userAgent.indexOf('MSIE 6')) > 0) {
	addScroll = true;
}

document.onmousemove = mouseMove;
if (browserName == "Netscape") {
	document.captureEvents(Event.MOUSEMOVE)
};

function mouseMove(evn) {
	if (browserName == "Netscape") {
		pX = evn.pageX - 5;
		pY = evn.pageY;
	}
	else {
		pX = event.x - 5;
		pY = event.y;
	}
	if (browserName == "Netscape") {
		if (document.layers['ToolTip'].visibility == 'show') {
			popTip();
		}
	}
	else {
		if (document.all['ToolTip'].style.visibility == 'visible') {
			popTip();
		}
	}
}

function popTip() {
	var theLayer;

	if (browserName == "Netscape") {
		theLayer = eval('document.layers[\'ToolTip\']');

		if ((pX + 120) > window.innerWidth) {
			pX = window.innerWidth - 150;
		}

		theLayer.left = pX + 10;
		theLayer.top = pY + 15;
		theLayer.visibility = 'show';
	}
	else {
		theLayer = eval('document.all[\'ToolTip\']');

		if (theLayer) {
			pX = event.x - 5;
			pY = event.y;

			if (addScroll) {
				pX = pX + document.body.scrollLeft;
				pY = pY + document.body.scrollTop;
			}

			if ((pX + 120) > document.body.clientWidth) {
				pX = pX - 150;
			}

			theLayer.style.pixelLeft = pX + 10;
			theLayer.style.pixelTop = pY + 15;
			theLayer.style.visibility = 'visible';
		}
	}
}

function hideTip() {
	var args = HideTip.arguments,
		id = 'ToolTip';
	hide(id);
}

function hideMenu1() {
	var id = 'menu1';
	hide(id);
}

function showMenu1() {
	var id = 'menu1';
	show(id);
}

function hideMenu2() {
	var id = 'menu2';
	hide(id);
}

function showMenu2() {
	var id = 'menu2';
	show(id);
}

function hide(id) {
	if (browserName == "Netscape") {
		document.layers[id].visibility = 'hide';
	}
	else {
		document.all[id].style.visibility = 'hidden';
	}
}

function show(id) {
	if (browserName == "Netscape") {
		theLayer = eval('document.layers[\'' + id + '\']');
		theLayer.visibility = 'show';
	}
	else {
		theLayer = eval('document.all[\'' + id + '\']');
		theLayer.style.visibility = 'visible';
	}
}