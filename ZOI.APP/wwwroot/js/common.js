function fnCheckEmail(event) {
	var charCode = (event.key).charCodeAt();
	if (charCode > 63 && charCode < 91 || charCode > 96 && charCode < 123 || charCode == 50 || charCode > 47 && charCode < 58 || charCode == 18 || charCode == 46) {
		return true;
	} else {
		event.preventDefault();
	}
}

function fnRegexEmail(email) {	
	var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	return regex.test(email);
}

function fnRegexMobile(mobile) {
	var regex = /([6-9]){1}([0-9]){9}$/;
	return regex.test(mobile);
}

function fnRegexAadhar(aadhar) {
	var regex = /^[0-9]*$/;
	return regex.test(aadhar);
}

function fnRegexPan(pan) {
	var regex = /([A-Z]){5}([0-9]){4}([A-Z]){1}$/;
	return regex.test(pan);
}

function fnAlphabetWithSpace(event) {
	var charCode = (event.key).charCodeAt();
	if (charCode > 64 && charCode < 91 || charCode > 96 && charCode < 123 || charCode == 32) {
		return true;
	} else {
		event.preventDefault();
	}
}

function fnNumeric(event) {
	var charCode = (event.key).charCodeAt();
	if (charCode > 47 && charCode < 58) {
		return true;
	} else {
		event.preventDefault();
	}
}



function fnNumericWithDot(event) {
	var charCode = (event.key).charCodeAt();
	if (charCode > 46 && charCode < 58) {
		return true;
	} else {
		event.preventDefault();
	}
}


function fnAlphaNumericWithoutSpace(event) {
	var charCode = (event.key).charCodeAt();
	if (charCode > 64 && charCode < 91 || charCode > 96 && charCode < 123 || charCode > 47 && charCode < 58) {
		return true;
	} else {
		event.preventDefault();
	}
}

