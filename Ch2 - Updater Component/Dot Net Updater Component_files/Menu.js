window.onunload = function(){saveState(menuId);}
getState(menuId);
var openDisplay = "block";
var closedDisplay = "none";

// expandit function
//   calls toggleSection function after a
//   short delay so that images display 
//   correctly
function expandit(itemId)
{
	window.setTimeout("toggleSection('" + itemId + "')",10);
}

// toggleSection function
//   opens or closes menu section 
function toggleSection(itemId) {
	var arrowId = itemId.replace("SectionPanel", "ArrowImage");
	var arrow, item;
    
	if (document.all) {
		item = document.all[itemId];
		arrow = document.all[arrowId];
	}
    
	if (!document.all && document.getElementById) {
		item = document.getElementById(itemId);
		arrow = document.getElementById(arrowId);
	}
        
	if (item.style.display == closedDisplay) {
		arrow.src = arrowDown.src;
		item.style.display = openDisplay;
	}
	else {
		arrow.src = arrowRight.src;	
		item.style.display = closedDisplay;		
	}
}

// saveState function
//   sets the state of each menu section and 
//   adds the open menu sections to a cookie
function saveState(menuId) {
	var cookieInfo = "";
	for (i = 0; i < sectionCount; i++) {
		var item;
		var itemId = menuClientId.replace(menuId + "_Menu",menuId + "_MenuSections__ctl" + i + "_SectionPanel");
		
		if (document.all) {
			item = document.all[itemId];
		}
		if (!document.all && document.getElementById) {
			item = document.getElementById(itemId);
		}
		if (item.style.display == openDisplay)
			cookieInfo = cookieInfo + "|" + i; 		
	}
	setCookie(menuCookieName,cookieInfo, getExpirationDate(1));
}

// getState function
//   gets and opens menu sections based on 
//   the values from the cookie set in saveState
function getState(menuId) {
	var sections = new Array();
	sections = getCookie(menuCookieName).split("|");
	for (i = 1; i < sections.length; i++) {
	    if (i < sectionCount-1) {
		    var itemId = menuClientId.replace(menuId + "_Menu",menuId + "_MenuSections__ctl" + sections[i] + "_SectionPanel");
		    expandit(itemId);
		}
	}
}	

// getCookie function
//   gets the menu cookie
function getCookie(cookieName) {
	var cookie;
	cookie = "" + document.cookie;
	var start = cookie.indexOf(cookieName);
	if (cookie == "" || start == -1) 
		return "";
	var end = cookie.indexOf(';',start);
	if (end == -1)
		end = cookie.length;
	return unescape(cookie.substring(start+cookieName.length + 1,end));
}

// setCookie function
//   sets the menu cookie
function setCookie(cookieName, value, expires) {
	cookieInfo = cookieName + "=" + escape(value) + ";path=/"
	document.cookie = cookieInfo;  
	return document.cookie;
}

// getExpirationDate function
//   gets the menu cookie from the browser
function getExpirationDate(days){
	today = new Date();
	today.setTime(Date.parse(today) + (days * 60 * 60 * 24 * 100));
	return  today.toUTCString();
}

